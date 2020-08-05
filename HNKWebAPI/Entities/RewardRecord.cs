using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HNKWebAPI.Entities {    
    public class RewardRecord {
        public int RecordID { get; set; }
        /// <summary>
        /// 员工序号
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// 奖惩原因
        /// </summary>
        public string AwardReason { get; set; }
        /// <summary>
        /// 奖惩级别
        /// </summary>
        public string AwardClass { get; set; }
        /// <summary>
        /// 奖惩状态
        /// </summary>
        public string AwardState { get; set; }
        /// <summary>
        /// 奖惩金额
        /// </summary>
        public decimal AwardMoney { get; set; }
        /// <summary>
        /// 奖惩日期
        /// </summary>
        public string AwardDate { get; set; }
        /// <summary>
        /// 取消日期
        /// </summary>
        public string CancelDate { get; set; }
        /// <summary>
        /// 批准部门
        /// </summary>
        public string ApproveDepart { get; set; }
        /// <summary>
        /// 批准人
        /// </summary>
        public string Approver { get; set; }
    }
}
