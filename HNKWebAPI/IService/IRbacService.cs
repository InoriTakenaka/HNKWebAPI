using HNKWebAPI.Models;
using HNKWebAPI.Dtos;
using HNKWebAPI.Entities;

namespace HNKWebAPI.IService {
    interface IRbacService {
        ResponseModel AddUser(UsersDto user);
        ResponseModel Modify(Users user);
        ResponseModel DeleteUser(Users user);
        ResponseModel GetUser(int id);
        ResponseModel GetUsers();
        ResponseModel SaveRole(Roles role);
        ResponseModel DeleteRole(int id);
        ResponseModel GetRole(int id);
        ResponseModel GetRoleByUser(int userid);
        ResponseModel GetRoles();
        ResponseModel SaveUserRole(UserRoleMaps[] userRoleMaps);
        ResponseModel GetPermissions();
        ResponseModel SaveRolePermission(RolePermissionMaps[] rolePermissionMaps);
        ResponseModel SaveRoleMenu(RoleMenuMaps[] roleMenuMaps);
        ResponseModel UserLogin(string username, string password);
    }
}
