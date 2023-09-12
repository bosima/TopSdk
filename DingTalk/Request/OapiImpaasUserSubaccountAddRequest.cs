using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.user.subaccount.add
    /// </summary>
    public class OapiImpaasUserSubaccountAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasUserSubaccountAddResponse>
    {
        /// <summary>
        /// 添加子账号入参
        /// </summary>
        public string Request { get; set; }

        public AddSubAccountReqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.user.subaccount.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
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
/// AddSubAccountReqDomain Data Structure.
/// </summary>
[Serializable]

public class AddSubAccountReqDomain : TopObject
{
	        /// <summary>
	        /// 主账号id
	        /// </summary>
	        [XmlElement("adminaccount_id")]
	        public string AdminaccountId { get; set; }
	
	        /// <summary>
	        /// 业务方channel
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 子账号id
	        /// </summary>
	        [XmlElement("subaccount_id")]
	        public string SubaccountId { get; set; }
}

        #endregion
    }
}
