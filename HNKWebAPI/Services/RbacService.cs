using HNKWebAPI.Entities;
using HNKWebAPI.IService;
using HNKWebAPI.Models;
using HNKWebAPI.DataSource;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HNKWebAPI.Services {
    public class RbacService : IRbacService {
        public RbacService(DataSourceContext dataSourceContext) {
            db = dataSourceContext;
        }
        public ResponseModel AddUser(Users user) {
            ResponseModel response = new ResponseModel();
            if (user.UserAccount.ToLower().Equals("admin") ||
              user.UserAccount.ToLower().Equals("administrator")) {
                response.Code = 0;
                response.Message = "User Account is Invalid";
            }
            else {
                Users entity = db.Users.AsNoTracking().Where(p => p.UserAccount.Equals(user.UserAccount)).FirstOrDefault();
                if (entity != null) {
                    response.Code = 0;
                    response.Message = "User already Existed";
                }
                else {
                    db.Users.Add(user);
                    db.SaveChanges();
                    response.Code = 1;
                    response.Data = user;
                    response.Message = "User create Success";
                }

            }
            return response;
        }

        public ResponseModel DeleteRole(int id) {
            throw new System.NotImplementedException();
        }

        public ResponseModel DeleteUser(Users user) {
            throw new System.NotImplementedException();
        }

        public ResponseModel GetPermissions() {
            throw new System.NotImplementedException();
        }

        public ResponseModel GetRole(int id) {
            throw new System.NotImplementedException();
        }

        public ResponseModel GetRoleByUser(int userid) {
            throw new System.NotImplementedException();
        }

        public ResponseModel GetRoles() {
            throw new System.NotImplementedException();
        }

        public ResponseModel GetUser(int id) {
            throw new System.NotImplementedException();
        }

        public ResponseModel GetUsers() {
            throw new System.NotImplementedException();
        }

        public ResponseModel Modify(Users user) {
            throw new System.NotImplementedException();
        }

        public ResponseModel SaveRole(Roles role) {
            throw new System.NotImplementedException();
        }

        public ResponseModel SaveRoleMenu(RoleMenuMaps[] roleMenuMaps) {
            throw new System.NotImplementedException();
        }

        public ResponseModel SaveRolePermission(RolePermissionMaps[] rolePermissionMaps) {
            throw new System.NotImplementedException();
        }

        public ResponseModel SaveUserRole(UserRoleMaps[] userRoleMaps) {
            throw new System.NotImplementedException();
        }

        public ResponseModel UserLogin(string username, string password) {
            throw new System.NotImplementedException();
        }

        private readonly DataSourceContext db;
    }
}
