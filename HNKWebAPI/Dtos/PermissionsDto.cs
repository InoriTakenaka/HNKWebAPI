using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNKWebAPI.Dtos {
    public class PermissionsDto {
        public int id { get; set; }
        public int menu_id { get; set; }
        public string action_code { get; set; }
        public string action_name { get; set; }
    }
}
