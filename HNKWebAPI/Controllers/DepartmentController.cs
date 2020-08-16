using HNKWebAPI.IService;
using HNKWebAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HNKWebAPI.Entities;


namespace HNKWebAPI.Controllers {
    [Route("api/departservice/[action]")]
    [ApiController]
    public class DepartmentController : ControllerBase {
        public DepartmentController(IDepartmentService DepartmentService) {
            service_ = DepartmentService;
        }
        [HttpGet]
        public Task<ResponseModel> FetchDepartments() {
            return Task.Run(() => {
                return service_.FetchDepartments();
            });
        }
        [HttpPut]
        public Task<ResponseModel> SaveDepartment(Department department) {
            return Task.Run(() => {
                return service_.SaveDepartmentInfo(department);
            });
        }
        [HttpDelete]
        public Task<ResponseModel> DeleteDepartment(int id) {
            return Task.Run(() => {
                return service_.RemoveDeparment(id);
            });
        }
        private readonly IDepartmentService service_;
    }
}
