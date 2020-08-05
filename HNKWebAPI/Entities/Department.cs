using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HNKWebAPI.Entities {
    public class Department {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartName { get; set; }
        /// <summary>
        /// 部门领导
        /// </summary>
        public string DepartLeader { get; set; }
        /// <summary>
        /// 部门编号
        /// </summary>
        public string DepartNo { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public int DepartID { get; set; }       
    }
}
