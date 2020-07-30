using HNKWebAPI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNKWebAPI.Entities {
    public class Users {
        [DataMap("id")]
        public int Id { get; set; }
        [DataMap("user_status")]
        public int AccountStatus { get; set; }
        [DataMap("user_code")]
        public string UserAccount { get; set; }
        [DataMap("user_name")]
        public string UserName { get; set; }
        [DataMap("user_password")]
        public string UserPassword { get; set; }
        [DataMap("user_id")]
        public string IdCard { get; set; }
        [DataMap("create_time")]
        public DateTime CreateDate { get; set; }
    }
}
