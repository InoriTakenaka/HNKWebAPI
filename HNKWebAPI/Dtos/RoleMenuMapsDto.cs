using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNKWebAPI.Dtos {
    public class RoleMenuMapsDto {
        public int id { get; set; }
        public int role_id { get; set; }
        public int menu_id { get; set; }
    }
}
