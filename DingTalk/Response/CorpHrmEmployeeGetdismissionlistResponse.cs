using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpHrmEmployeeGetdismissionlistResponse.
    /// </summary>
    public class CorpHrmEmployeeGetdismissionlistResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// HrmApiDismissionModelDomain Data Structure.
/// </summary>
[Serializable]

public class HrmApiDismissionModelDomain : TopObject
{
	        /// <summary>
	        /// 入职时间
	        /// </summary>
	        [XmlElement("confirm_join_time")]
	        public string ConfirmJoinTime { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 离职描述
	        /// </summary>
	        [XmlElement("dismission_memo")]
	        public string DismissionMemo { get; set; }
	
	        /// <summary>
	        /// 离职原因（1：家庭原因，2:个人原因，3：发展原因，4：合同到期不续签，5：协议解除，6：无法胜任工作，7：经济性裁员，8：严重违法违纪，9：其他）
	        /// </summary>
	        [XmlElement("dismission_reason")]
	        public string DismissionReason { get; set; }
	
	        /// <summary>
	        /// email
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// 员工状态（-1:无状态，1:待入职，2:试用，3:正式，4:离职，5:待离职）
	        /// </summary>
	        [XmlElement("employee_status")]
	        public string EmployeeStatus { get; set; }
	
	        /// <summary>
	        /// 员工类型（0:无类型，1:全职，2:兼职，3:实习，4:劳务派遣，5:退休返聘，6:劳务外包）
	        /// </summary>
	        [XmlElement("employee_type")]
	        public string EmployeeType { get; set; }
	
	        /// <summary>
	        /// 离职时间
	        /// </summary>
	        [XmlElement("last_work_date")]
	        public string LastWorkDate { get; set; }
	
	        /// <summary>
	        /// 名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 职位
	        /// </summary>
	        [XmlElement("position")]
	        public string Position { get; set; }
	
	        /// <summary>
	        /// userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// HrmApiPageDomain Data Structure.
/// </summary>
[Serializable]

public class HrmApiPageDomain : TopObject
{
	        /// <summary>
	        /// 当前页
	        /// </summary>
	        [XmlElement("current")]
	        public long Current { get; set; }
	
	        /// <summary>
	        /// 实际每条数据
	        /// </summary>
	        [XmlArray("data_list")]
	        [XmlArrayItem("hrm_api_dismission_model")]
	        public List<HrmApiDismissionModelDomain> DataList { get; set; }
	
	        /// <summary>
	        /// 每页最大数量，最大100
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 总数
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
	
	        /// <summary>
	        /// 总页数
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 分页数据
	        /// </summary>
	        [XmlElement("page")]
	        public HrmApiPageDomain Page { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
