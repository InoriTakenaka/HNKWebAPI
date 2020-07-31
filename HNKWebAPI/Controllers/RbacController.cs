using HNKWebAPI.Dtos;
using HNKWebAPI.IService;
using HNKWebAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HNKWebAPI.Entities;

namespace HNKWebAPI.Controllers {
    [Route("api/rbacservices/[action]")]
    [ApiController]
    public class RbacController : ControllerBase {
        private readonly IRbacService service_;
        public RbacController(IRbacService service) {
            this.service_ = service;
        }
        [HttpPost]
        public async Task<ResponseModel> AddUser(UsersDto user) {
            //Queues the specified work to run on the ThreadPool and returns 
            //a task or Task<TResult> handle for that work.
            ResponseModel response = await Task.Run(() => { 
                return service_.AddUser(user); 
            });
            return response;
        }
        [HttpPost]
        public Task<ResponseModel> ModifyUser(UsersDto user) {
            return Task.Run(() => {
                return service_.ModifyUser(user);
            });
        }
        [HttpDelete]
        public Task<ResponseModel> DeleteUser(int id) {
            return Task.Run(() => { 
                return service_.DeleteUser(id); 
            });
        }
        [HttpGet]
        public Task<ResponseModel> GetUser(int id) {
            return Task.Run(() => {
                return service_.GetUser(id);
            });
        }
        [HttpGet]
        public Task<ResponseModel> GetUsers() {
            return Task.Run(() => {
                return service_.GetUsers();
            });
        }
        [HttpPost]
        public Task<ResponseModel> SaveRole(Roles role) {
            return Task.Run(() => {
                return service_.SaveRole(role);
            });
        }
        [HttpDelete]
        public Task<ResponseModel> DeleteRole(int id) {
            return Task.Run(() => {
                return service_.DeleteRole(id);
            });
        }
        [HttpGet]
        public Task<ResponseModel> GetRole(int id) {
            return Task.Run(() => {
                return service_.GetRole(id);
            });
        }
        [HttpGet]
        public Task<ResponseModel> GetRoles() {
            return Task.Run(() => {
                return service_.GetRoles();
            });
        }
        [HttpPost]
        public Task<ResponseModel> SaveUserRole(UserRoleMaps[] maps) {
            return Task.Run(() => {
                return service_.SaveUserRole(maps);
            });
        }
        [HttpGet]
        public Task<ResponseModel> GetPermissions() {
            return Task.Run(() => {
                return service_.GetPermissions();
            });
        }
        [HttpGet]
        public Task<ResponseModel> SaveRolePermissionMap(RolePermissionMaps[] maps) {
            return Task.Run(() => {
                return service_.SaveRolePermission(maps);
            });
        }
        [HttpPost]
        public Task<ResponseModel> SaveRoleMenuMap(RoleMenuMaps[] maps) {
            return Task.Run(() => {
                return service_.SaveRoleMenu(maps);
            });
        }
        [HttpGet]
        public Task<ResponseModel> UserLogin(string user_account,string user_password) {
            return Task.Run(() => {
                return service_.UserLogin(user_account, user_password);
            });
        }
    }//class RbacController
}//namespace HNKWebAPI.Controllers
