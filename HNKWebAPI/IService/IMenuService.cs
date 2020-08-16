using HNKWebAPI.Models;
using HNKWebAPI.Entities;
using System.Collections.Generic;

namespace HNKWebAPI.IService {
    public interface IMenuService {
        ResponseModel AddMenu(Menus menu);
        ResponseModel SaveMenus(List<Menus> menus);
        ResponseModel ModifyMenu(Menus menu);
        ResponseModel DeleteMenu(int id);
        ResponseModel GetMenus();
        ResponseModel GetMenu(int id);
        ResponseModel GetMenuByUser(int userid);
        ResponseModel GetMenuByRole(int roleid);
    }
}
