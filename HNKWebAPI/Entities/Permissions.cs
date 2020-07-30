using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNKWebAPI.Entities {
    public class Permissions {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string ActionCode { get; set; }
        public string ActionName { get; set; }
    }
}
