using HNKWebAPI.Models;
using HNKWebAPI.Entities;


namespace HNKWebAPI.IService {
    public interface IDepartmentService {
        ResponseModel SaveDepartmentInfo(Department department);
        ResponseModel RemoveDeparment(int departmentId);
        ResponseModel RetriveDepartment(int departmentId);
        ResponseModel FetchDepartments();
    }
}
