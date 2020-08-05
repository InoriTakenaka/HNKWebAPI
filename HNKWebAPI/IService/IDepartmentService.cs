using HNKWebAPI.Models;
using HNKWebAPI.Entities;


namespace HNKWebAPI.IService {
    public interface IDepartmentService {
        ResponseModel AddDepartment(Department department);
        ResponseModel EditDepartment(Department department);
        ResponseModel RemoveDeparment(int departmentId);
        ResponseModel RetriveDepartment(int departmentId);
        ResponseModel FetchDepartments();
    }
}
