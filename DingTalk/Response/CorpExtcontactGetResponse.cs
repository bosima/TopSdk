using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpExtcontactGetResponse.
    /// </summary>
    public class CorpExtcontactGetResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// OpenExtContactDomain Data Structure.
/// </summary>
[Serializable]

public class OpenExtContactDomain : TopObject
{
	        /// <summary>
	        /// 地址
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 公司名
	        /// </summary>
	        [XmlElement("company_name")]
	        public string CompanyName { get; set; }
	
	        /// <summary>
	        /// 扩展属性，可以设置多种属性
	        /// </summary>
	        [XmlElement("ext_attr")]
	        public string ExtAttr { get; set; }
	
	        /// <summary>
	        /// 负责人UserID
	        /// </summary>
	        [XmlElement("follower_user_id")]
	        public string FollowerUserId { get; set; }
	
	        /// <summary>
	        /// 标签
	        /// </summary>
	        [XmlArray("label_ids")]
	        [XmlArrayItem("number")]
	        public List<long> LabelIds { get; set; }
	
	        /// <summary>
	        /// 手机号
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 共享部门ID列表
	        /// </summary>
	        [XmlArray("share_dept_ids")]
	        [XmlArrayItem("number")]
	        public List<long> ShareDeptIds { get; set; }
	
	        /// <summary>
	        /// 共享员工UserID列表
	        /// </summary>
	        [XmlArray("share_user_ids")]
	        [XmlArrayItem("string")]
	        public List<string> ShareUserIds { get; set; }
	
	        /// <summary>
	        /// 国家码
	        /// </summary>
	        [XmlElement("state_code")]
	        public string StateCode { get; set; }
	
	        /// <summary>
	        /// 职位
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 外部联系人UserID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlElement("result")]
	        public OpenExtContactDomain Result { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
