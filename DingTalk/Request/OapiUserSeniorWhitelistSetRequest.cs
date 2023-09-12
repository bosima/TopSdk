using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.senior.whitelist.set
    /// </summary>
    public class OapiUserSeniorWhitelistSetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserSeniorWhitelistSetResponse>
    {
        /// <summary>
        /// 高管白名单设置请求对象
        /// </summary>
        public string SeniorWhitelistRequest { get; set; }

        public SeniorWhitelistRequestDomain SeniorWhitelistRequest_ { set { this.SeniorWhitelistRequest = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.senior.whitelist.set";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("senior_whitelist_request", this.SeniorWhitelistRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// SeniorWhitelistRequestDomain Data Structure.
/// </summary>
[Serializable]

public class SeniorWhitelistRequestDomain : TopObject
{
	        /// <summary>
	        /// 高管白名单部门列表
	        /// </summary>
	        [XmlArray("senior_permit_deptids")]
	        [XmlArrayItem("number")]
	        public List<string> SeniorPermitDeptids { get; set; }
	
	        /// <summary>
	        /// 高管白名单角色列表
	        /// </summary>
	        [XmlArray("senior_permit_roleids")]
	        [XmlArrayItem("number")]
	        public List<string> SeniorPermitRoleids { get; set; }
	
	        /// <summary>
	        /// 高管白名单员工列表
	        /// </summary>
	        [XmlArray("senior_permit_userids")]
	        [XmlArrayItem("string")]
	        public List<string> SeniorPermitUserids { get; set; }
	
	        /// <summary>
	        /// 高管工号
	        /// </summary>
	        [XmlElement("senior_userid")]
	        public string SeniorUserid { get; set; }
}

        #endregion
    }
}
