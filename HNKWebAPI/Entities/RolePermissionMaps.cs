using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNKWebAPI.Entities {
    public class RolePermissionMaps {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string PermissionId { get; set; }
    }
}
