using HNKWebAPI.DataSource;
using HNKWebAPI.Dtos;
using HNKWebAPI.Entities;
using HNKWebAPI.IService;
using HNKWebAPI.Models;
using HNKWebAPI.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HNKWebAPI.Services {
    public class MenuService : IMenuService {
        public MenuService(DataSourceContext dataSourceContext) {
            db_ = dataSourceContext;
        }
        public ResponseModel AddMenu(Menus menu) {
            ResponseModel response = new ResponseModel();
            db_.Menus.Add(menu);
            db_.SaveChanges();
            return response;
        }

        public ResponseModel DeleteMenu(int id) {
            ResponseModel response = new ResponseModel();
            Menus menu = db_.Menus.Where(p => p.Id.Equals(id)).FirstOrDefault();
            if (null != menu) {
                db_.Menus.Remove(menu);
                db_.SaveChanges();
            }
            return response;
        }

        public ResponseModel GetMenu(int id) {
            ResponseModel response = new ResponseModel();
            Menus menu = db_.Menus.Where(p => p.Id.Equals(id)).FirstOrDefault();
            if (null != menu)
                response.Data = menu;
            return response;
        }

        public ResponseModel GetMenuByRole(int roleid) {
            ResponseModel response = new ResponseModel();
            var menu = (from p in db_.RoleMenuMaps
                          join q in db_.Menus
                          on p.MenuId equals q.Id
                          where p.RoleId == roleid
                          select new Menus {
                              Id = q.Id,
                              ParentId = q.Id,
                              ParentName = q.MenuName,
                              MenuPath = q.MenuPath,
                              Index = q.Index
                          }).ToList();
            response.Data = menu;
            response.DataCount = menu.Count();
            return response;
        }

        public ResponseModel GetMenuByUser(int userid) {
            ResponseModel response = new ResponseModel();
            if(-1 == userid) {
                List<Menus> menu = db_.Menus.ToList();
                response.Data = menu;
                response.DataCount = menu.Count;
            }
            else {
                List<Menus> menu = (from p in db_.UserRoleMaps
                             join q in db_.RoleMenuMaps on p.RoleId equals q.RoleId
                             join r in db_.Menus on q.MenuId equals r.Id
                             where userid == p.UserId
                             select new Menus {
                                 Id = r.Id,
                                 ParentId = r.ParentId,
                                 ParentName = r.ParentName,
                                 MenuName = r.MenuName,
                                 MenuPath = r.MenuPath,
                                 Index = r.Index
                             }).Distinct().ToList();
                response.Data = menu;
                response.DataCount = menu.Count();
            }
            return response;
        }

        public ResponseModel GetMenus() {
            ResponseModel response = new ResponseModel();
            List<Menus> menu = db_.Menus.ToList();
            response.Data = menu;
            response.DataCount = menu.Count();
            return response;
        }

        public ResponseModel ModifyMenu(Menus menu) {
            ResponseModel response = new ResponseModel();
            Menus target = db_.Menus.AsNoTracking().Where(p => p.Id == menu.Id).FirstOrDefault();
            if (null != target) {
                db_.Menus.Update(menu);
                db_.SaveChanges();
                response.Data = menu;
            }
            else {
                response.Code = 0;
                response.Message = "specificed Objective dose NOT exist";
            }
            return response;
        }

        private readonly DataSourceContext db_;
    }
}
