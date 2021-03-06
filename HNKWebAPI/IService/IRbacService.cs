﻿using HNKWebAPI.Models;
using HNKWebAPI.Dtos;
using HNKWebAPI.Entities;

namespace HNKWebAPI.IService {
   public interface IRbacService {
        ResponseModel AddUser(UsersDto user);
        ResponseModel ModifyUser(UsersDto user);
        ResponseModel DeleteUser(int id);
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
