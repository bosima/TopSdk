using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.live.query
    /// </summary>
    public class OapiLiveQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiLiveQueryResponse>
    {
        /// <summary>
        /// 直播查询请求model
        /// </summary>
        public string Request { get; set; }

        public GetDetailReqModelDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.live.query";
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
/// GetDetailReqModelDomain Data Structure.
/// </summary>
[Serializable]

public class GetDetailReqModelDomain : TopObject
{
	        /// <summary>
	        /// 直播UUID,必填
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

        #endregion
    }
}
