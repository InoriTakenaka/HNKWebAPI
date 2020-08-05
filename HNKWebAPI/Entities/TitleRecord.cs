using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HNKWebAPI.Entities {
    public class TitleRecord {
        public int TitleID { get; set; }
        /// <summary>
        /// 职称名称
        /// </summary>
        public string TitleName { get; set; }
        /// <summary>
        /// 员工序号
        /// </summary>
        public string EmployeeNo { get; set; }
        /// <summary>
        /// 职称取得日期
        /// </summary>
        public string TitleObtainDate { get; set; }
        /// <summary>
        /// 取得方式
        /// </summary>
        public string ObtainType { get; set; }
        /// <summary>
        /// 聘用单位
        /// </summary>
        public string EmployUnit { get; set; }
        /// <summary>
        /// 聘用技术职务
        /// </summary>
        public string EmployTitle { get; set; }
        /// <summary>
        /// 聘用起始日期
        /// </summary>
        public string EmployBegin { get; set; }
        /// <summary>
        /// 聘用结束日期
        /// </summary>
        public string EmployEnd { get; set; }
        /// <summary>
        /// 称职英语级别
        /// </summary>
        public string EnglishClass { get; set; }
        /// <summary>
        /// 职称英语日期
        /// </summary>
        public string EnglishDate { get; set; }
        /// <summary>
        /// 职称电脑级别
        /// </summary>
        public string ComputerClass { get; set; }
        /// <summary>
        /// 职称电脑日期
        /// </summary>
        public string ComputerDate { get; set; }
        /// <summary>
        /// 职称信息备注
        /// </summary>
        public string TitleRemark { get; set; }
    }
}
