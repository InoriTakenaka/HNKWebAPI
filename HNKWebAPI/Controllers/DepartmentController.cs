using HNKWebAPI.IService;
using HNKWebAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HNKWebAPI.Entities;


namespace HNKWebAPI.Controllers {
    [Route("api/departservice/[action]")]
    [ApiController]
    public class DepartmentController : ControllerBase {
        [HttpGet]
        public Task<ResponseModel> FetchDepartments() {
            return Task.Run(() => {
                return service_.FetchDepartments();
            });
        }
        public DepartmentController(IDepartmentService DepartmentService) {
            service_ = DepartmentService;
        }
        private readonly IDepartmentService service_;
    }
}
