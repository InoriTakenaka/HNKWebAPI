using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HNKWebAPI.Entities {
    public class Menus {
        public int Id { get; set; }
        [DefaultValue(0)]
        public int ParentId { get; set; }
        public int MenuId { get; set; }
        public int Index { get; set; }
        public string MenuPath { get; set; }
        public string ParentName { get; set; }
        public string MenuName { get; set; }
    }
}
