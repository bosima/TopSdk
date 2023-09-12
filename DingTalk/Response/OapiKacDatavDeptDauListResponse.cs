using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavDeptDauListResponse.
    /// </summary>
    public class OapiKacDatavDeptDauListResponse : DingTalkResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public DeptDauSummaryResponseDomain Result { get; set; }

	/// <summary>
/// DeptDauSummaryVoDomain Data Structure.
/// </summary>
[Serializable]

public class DeptDauSummaryVoDomain : TopObject
{
	        /// <summary>
	        /// 钉钉app端登录人数
	        /// </summary>
	        [XmlElement("app_active_users")]
	        public long AppActiveUsers { get; set; }
	
	        /// <summary>
	        /// 通讯录人数
	        /// </summary>
	        [XmlElement("contacts_number")]
	        public long ContactsNumber { get; set; }
	
	        /// <summary>
	        /// 日活跃人数
	        /// </summary>
	        [XmlElement("daily_active_users")]
	        public long DailyActiveUsers { get; set; }
	
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 钉钉pc端登录人数
	        /// </summary>
	        [XmlElement("pc_active_users")]
	        public long PcActiveUsers { get; set; }
}

	/// <summary>
/// DeptDauSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DeptDauSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// 数据列表
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("dept_dau_summary_vo")]
	        public List<DeptDauSummaryVoDomain> Data { get; set; }
	
	        /// <summary>
	        /// 是否有下一页；true则存在更多分页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一次请求的分页游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
