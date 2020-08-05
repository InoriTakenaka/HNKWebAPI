using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HNKWebAPI.Entities {
    public class StaffInfo {
        public int StaffID { get; set; }
        /// <summary>
        /// 帐套ID
        /// </summary>
        public string SetAccountID { set; get; }
        /// <summary>
        /// 部门号
        /// </summary>
        public int DepartID { set; get; }
        /// <summary>
        /// 员工编号 
        /// </summary>
        public string EmployeeNo { set; get; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmployeeName { set; get; }
        /// <summary>
        /// 姓名拼音
        /// </summary>
        public string EmployeeNamePY { set; get; }
        /// <summary>
        /// 员工身份证号
        /// </summary>
        public string EmployeeIDNumber { set; get; }
        /// <summary>
        /// 员工性别
        /// </summary>
        public string EmployeeGender { set; get; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public string BirthDate { set; get; }
        /// <summary>
        /// 婚恋状况
        /// </summary>
        public string MaritalStatus { set; get; }
        /// <summary>
        /// 员工照片
        /// </summary>
        public byte[] Photo { set; get; }
        /// <summary>
        /// 民族
        /// </summary>
        public string EmployeeNation { set; get; }
        /// <summary>
        /// 电话
        /// </summary>
        public string EmployeePhone { set; get; }
        /// <summary>
        /// 职务
        /// </summary>
        public string EmployeePost { set; get; }
        /// <summary>
        /// 支持哪个
        /// </summary>
        public string EmployeeTitle { set; get; }
        /// <summary>
        /// 政治地位
        /// </summary>
        public string PoliticalStatus { set; get; }
        /// <summary>
        /// 学历
        /// </summary>
        public string EmployeeEducation { set; get; }
        /// <summary>
        /// 专业
        /// </summary>
        public string EmployeeMajor { set; get; }
        /// <summary>
        /// 毕业院校
        /// </summary>
        public string GraduSchool { set; get; }
        /// <summary>
        /// 入职日期
        /// </summary>
        public string JoinDate { set; get; }
        /// <summary>
        /// 聘用形式
        /// </summary>
        public string EmployeeType { set; get; }
        /// <summary>
        /// 家庭地址
        /// </summary>
        public string HomeAddress { set; get; }
        /// <summary>
        /// 合同签订日期
        /// </summary>
        public string SignDate { set; get; }
        /// <summary>
        /// 合同到期日期
        /// </summary>
        public string ExpireDate { set; get; }
        /// <summary>
        /// 公积金帐号
        /// </summary>
        public string AccumAccount { set; get; }
        /// <summary>
        /// 是否离职
        /// </summary>
        public bool IsQuit { set; get; }
        /// <summary>
        /// 离职日期
        /// </summary>
        public string QuitDate { set; get; }
        /// <summary>
        /// 离职原因
        /// </summary>
        public string QuitReason { set; get; }
        /// <summary>
        /// 员工备注
        /// </summary>
        public string EmployeeRemark { set; get; }
    }
}
