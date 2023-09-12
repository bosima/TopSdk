using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.group.dismiss
    /// </summary>
    public class OapiImpaasGroupDismissRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasGroupDismissResponse>
    {
        /// <summary>
        /// 解散群请求
        /// </summary>
        public string Request { get; set; }

        public DismissGroupRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.group.dismiss";
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
/// DismissGroupRequestDomain Data Structure.
/// </summary>
[Serializable]

public class DismissGroupRequestDomain : TopObject
{
	        /// <summary>
	        /// 群ID
	        /// </summary>
	        [XmlElement("chatid")]
	        public string Chatid { get; set; }
}

        #endregion
    }
}
