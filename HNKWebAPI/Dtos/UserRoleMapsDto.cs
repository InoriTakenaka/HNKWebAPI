using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNKWebAPI.Dtos {
    public class UserRoleMapsDto {
        public int id { get; set; }
        public int user_id { get; set; }
        public int role_id { get; set; }
        public int auth_id { get; set; }
    }
}
