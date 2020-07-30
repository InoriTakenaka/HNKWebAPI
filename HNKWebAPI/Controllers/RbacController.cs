using HNKWebAPI.Entities;
using HNKWebAPI.IService;
using HNKWebAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HNKWebAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class RbacController : ControllerBase {
        private readonly IRbacService service;
        [HttpPost]
        public  async Task<ResponseModel> AddUser(Users user) {
            ResponseModel response = await Task.Run(() => { return service.AddUser(user); });
            return response;
        }
    }
}
