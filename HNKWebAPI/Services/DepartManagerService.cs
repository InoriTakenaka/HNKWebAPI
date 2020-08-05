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
    public class DepartManagerService:IDepartmentService {
        public ResponseModel AddDepartment(Department department) {
            ResponseModel response = new ResponseModel();
            db_.Departments.Add(department);
            db_.SaveChanges();
            return response;
        }

        public ResponseModel EditDepartment(Department department) {
            ResponseModel response = new ResponseModel();
            Department target = db_.Departments.AsNoTracking()
                                   .Where(p => p.DepartID == department.DepartID)
                                   .FirstOrDefault();
            if (null != target) {
                db_.Update(department);
                db_.SaveChanges();
                response.Data = department;
            }
            else {
                response.Code = 0;
                response.Message = "specificed Objective dose NOT exist";
            }
            return response;
        }

        public ResponseModel RemoveDeparment(int departmentId) {
            ResponseModel response = new ResponseModel();
            Department target = db_.Departments.AsNoTracking()
                                   .Where(p => p.DepartID == departmentId)
                                   .FirstOrDefault();
            if (null != target) {
                db_.Remove(target);
                db_.SaveChanges();
                response.Data = target;
            }
            else {
                response.Code = 0;
                response.Message = "specificed Objective dose NOT exist";
            }
            return response;
        }

        public ResponseModel RetriveDepartment(int departmentId) {
            ResponseModel response = new ResponseModel();
            Department target = db_.Departments.AsNoTracking()
                                   .Where(p => p.DepartID == departmentId)
                                   .FirstOrDefault();
            if (null != target) {
                response.Data = target;
            }
            else {
                response.Code = 0;
                response.Message = "specificed Objective dose NOT exist";
            }
            return response;
        }

        public ResponseModel FetchDepartments() {
            ResponseModel response = new ResponseModel();
            List<Department> departments = db_.Departments.ToList();
            if (null != departments) {
                response.Data = departments;
                response.DataCount = departments.Count();
            }
            else {
                response.Data = null;
                response.DataCount = 0;
                response.Message = "No Data";
            }
            return response;
        }

        public DepartManagerService(DataSourceContext dataSourceContext) {
            db_ = dataSourceContext;
        }

        private DataSourceContext db_;
    }
}
