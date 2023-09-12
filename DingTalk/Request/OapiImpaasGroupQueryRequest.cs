using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.group.query
    /// </summary>
    public class OapiImpaasGroupQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasGroupQueryResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Request { get; set; }

        public GetGroupInfoRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.group.query";
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
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// GetGroupInfoRequestDomain Data Structure.
/// </summary>
[Serializable]

public class GetGroupInfoRequestDomain : TopObject
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
