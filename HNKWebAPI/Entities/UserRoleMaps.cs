﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNKWebAPI.Entities {
    public class UserRoleMaps {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleInd { get; set; }
        public int AurthorizeId { get; set; }
    }
}