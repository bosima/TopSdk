using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmEmployeeListdimissionResponse.
    /// </summary>
    public class OapiSmartworkHrmEmployeeListdimissionResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("emp_dimission_info_vo")]
        public List<EmpDimissionInfoVoDomain> Result { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// EmpDeptVODomain Data Structure.
/// </summary>
[Serializable]

public class EmpDeptVODomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门路径
	        /// </summary>
	        [XmlElement("dept_path")]
	        public string DeptPath { get; set; }
}

	/// <summary>
/// EmpDimissionInfoVoDomain Data Structure.
/// </summary>
[Serializable]

public class EmpDimissionInfoVoDomain : TopObject
{
	        /// <summary>
	        /// 离职部门列表
	        /// </summary>
	        [XmlArray("dept_list")]
	        [XmlArrayItem("emp_dept_v_o")]
	        public List<EmpDeptVODomain> DeptList { get; set; }
	
	        /// <summary>
	        /// 离职交接人
	        /// </summary>
	        [XmlElement("handover_userid")]
	        public string HandoverUserid { get; set; }
	
	        /// <summary>
	        /// 最后工作日
	        /// </summary>
	        [XmlElement("last_work_day")]
	        public long LastWorkDay { get; set; }
	
	        /// <summary>
	        /// 离职前主部门id
	        /// </summary>
	        [XmlElement("main_dept_id")]
	        public long MainDeptId { get; set; }
	
	        /// <summary>
	        /// 离职前主部门名称
	        /// </summary>
	        [XmlElement("main_dept_name")]
	        public string MainDeptName { get; set; }
	
	        /// <summary>
	        /// 离职前工作状态：1，待入职；2，试用期；3，正式
	        /// </summary>
	        [XmlElement("pre_status")]
	        public long PreStatus { get; set; }
	
	        /// <summary>
	        /// 离职原因备注
	        /// </summary>
	        [XmlElement("reason_memo")]
	        public string ReasonMemo { get; set; }
	
	        /// <summary>
	        /// 离职原因类型：1，家庭原因；2，个人原因；3，发展原因；4，合同到期不续签；5，协议解除；6，无法胜任工作；7，经济性裁员；8，严重违法违纪；9，其他
	        /// </summary>
	        [XmlElement("reason_type")]
	        public long ReasonType { get; set; }
	
	        /// <summary>
	        /// 离职状态：1，待离职；2，已离职
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
