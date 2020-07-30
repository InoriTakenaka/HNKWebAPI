using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNKWebAPI.Entities {
    public class Users {
        public int Id { get; set; }
        public int AccountStatus { get; set; }
        public string UserAccount { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string IdCard { get; set; }       
        public DateTime CreateDate { get; set; }
    }
}
