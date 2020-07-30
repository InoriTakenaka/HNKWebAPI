using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNKWebAPI.Dtos {
    public class RolePermissionMapsDto {
        public int id { get; set; }
        public int role_id { get; set; }
        public string permission_id { get; set; }
    }
}
