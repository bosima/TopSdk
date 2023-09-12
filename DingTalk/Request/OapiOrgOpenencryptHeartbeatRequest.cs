using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.org.openencrypt.heartbeat
    /// </summary>
    public class OapiOrgOpenencryptHeartbeatRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiOrgOpenencryptHeartbeatResponse>
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public string TopKmsHeartbeat { get; set; }

        public TopKMSHeartbeatDomain TopKmsHeartbeat_ { set { this.TopKmsHeartbeat = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.org.openencrypt.heartbeat";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("top_kms_heartbeat", this.TopKmsHeartbeat);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("top_kms_heartbeat", this.TopKmsHeartbeat);
        }

	/// <summary>
/// TopKMSHeartbeatDomain Data Structure.
/// </summary>
[Serializable]

public class TopKMSHeartbeatDomain : TopObject
{
	        /// <summary>
	        /// 企业内部应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 附加数据，json格式
	        /// </summary>
	        [XmlElement("payload")]
	        public string Payload { get; set; }
	
	        /// <summary>
	        /// 请求id
	        /// </summary>
	        [XmlElement("requestid")]
	        public string Requestid { get; set; }
}

        #endregion
    }
}
