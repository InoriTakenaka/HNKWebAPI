using HNKWebAPI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNKWebAPI.Dtos {
    public class UsersDto {
        [DataMap("Id")]
        public int id { get; set; }
        [DataMap("AccountStatus")]
        public int user_status { get; set; }
        [DataMap("UserAccount")]
        public string user_code { get; set; }
        [DataMap("UserName")]
        public string user_name { get; set; }
        [DataMap("UserPassword")]
        public string user_password { get; set; }
        [DataMap("IdCard")]
        public string user_id { get; set; }
        [DataMap("CreateDate")]
        public DateTime create_time { get; set; }
    }
}
