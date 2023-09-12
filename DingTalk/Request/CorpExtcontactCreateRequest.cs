using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.extcontact.create
    /// </summary>
    public class CorpExtcontactCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpExtcontactCreateResponse>
    {
        /// <summary>
        /// 外部联系人信息
        /// </summary>
        public string Contact { get; set; }

        public OpenExtContactDomain Contact_ { set { this.Contact = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.extcontact.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("contact", this.Contact);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("contact", this.Contact);
        }

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
	        /// 企业名
	        /// </summary>
	        [XmlElement("company_name")]
	        public string CompanyName { get; set; }
	
	        /// <summary>
	        /// 负责人userId
	        /// </summary>
	        [XmlElement("follower_user_id")]
	        public string FollowerUserId { get; set; }
	
	        /// <summary>
	        /// 标签列表
	        /// </summary>
	        [XmlArray("label_ids")]
	        [XmlArrayItem("number")]
	        public List<string> LabelIds { get; set; }
	
	        /// <summary>
	        /// 手机号
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 共享给的部门ID
	        /// </summary>
	        [XmlArray("share_dept_ids")]
	        [XmlArrayItem("number")]
	        public List<string> ShareDeptIds { get; set; }
	
	        /// <summary>
	        /// 共享给的员工userId列表
	        /// </summary>
	        [XmlArray("share_user_ids")]
	        [XmlArrayItem("string")]
	        public List<string> ShareUserIds { get; set; }
	
	        /// <summary>
	        /// 手机号国家码
	        /// </summary>
	        [XmlElement("state_code")]
	        public string StateCode { get; set; }
	
	        /// <summary>
	        /// 职位
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

        #endregion
    }
}
