using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiExtcontactListResponse.
    /// </summary>
    public class OapiExtcontactListResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("open_ext_contact")]
        public List<OpenExtContactDomain> Results { get; set; }

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
	        /// 邮箱
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
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

    }
}
