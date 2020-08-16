using HNKWebAPI.Entities;
using HNKWebAPI.Models;
using System.Threading.Tasks;
using HNKWebAPI.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HNKWebAPI.Controllers {
    [Route("api/menuservices/[action]")]
    [ApiController]
    public class MenuController : ControllerBase {
        private readonly IMenuService service_;

        public MenuController(IMenuService service) {
            service_ = service;
        }
        [HttpGet]
        public Task<ResponseModel> GetMenus() {
            return Task.Run(() => {
                return service_.GetMenus();
            });
        }

        [HttpPost]
        public Task<ResponseModel> AddMenu(Menus menu) {
            return Task.Run(() => {
                return service_.AddMenu(menu);
            });
        }

        [HttpPut]
        public Task<ResponseModel> SaveMenus([FromBody] List<Menus> menus) {
            return Task.Run(() => {
                return service_.SaveMenus(menus);
            });
        }

        [HttpPost]
        public Task<ResponseModel> ModifyMenu(Menus menu) {
            return Task.Run(() => {
                return service_.ModifyMenu(menu);
            });
        }

        [HttpGet]
        public Task<ResponseModel> DeleteMenu(int id) {
            return Task.Run(() => {
                return service_.DeleteMenu(id);
            });
        }

        [HttpGet]
        public Task<ResponseModel> GetMenu(int id) {
            return Task.Run(() => {
                return service_.GetMenu(id);
            });
        }
        [HttpGet]
        public Task<ResponseModel> GetMenuByUser(int userid) {
            return Task.Run(() => {
                return service_.GetMenuByUser(userid);
            });
        }
        [HttpGet]
        public Task<ResponseModel> GetMenuByRole(int roleid) {
            return Task.Run(() => {
                return service_.GetMenuByRole(roleid);
            });
        }
    }
}
