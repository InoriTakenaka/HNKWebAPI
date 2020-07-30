using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HNKWebAPI.Dtos {
    public class MenusDto {
        public int id { get; set; }
        public int parent_id { get; set; }
        public int index { get; set; }
        public string menu_path { get; set; }
        public string parent_name { get; set; }
        public string menu_name { get; set; }
    }
}
