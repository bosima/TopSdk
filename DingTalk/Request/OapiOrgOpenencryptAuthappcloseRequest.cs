using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.org.openencrypt.authappclose
    /// </summary>
    public class OapiOrgOpenencryptAuthappcloseRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiOrgOpenencryptAuthappcloseResponse>
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public string TopAuthMicroAppClose { get; set; }

        public TopAuthMicroAppCloseDomain TopAuthMicroAppClose_ { set { this.TopAuthMicroAppClose = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.org.openencrypt.authappclose";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("top_auth_micro_app_close", this.TopAuthMicroAppClose);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("top_auth_micro_app_close", this.TopAuthMicroAppClose);
        }

	/// <summary>
/// TopAuthMicroAppCloseDomain Data Structure.
/// </summary>
[Serializable]

public class TopAuthMicroAppCloseDomain : TopObject
{
	        /// <summary>
	        /// 企业内部应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 授权码
	        /// </summary>
	        [XmlElement("authcode")]
	        public string Authcode { get; set; }
	
	        /// <summary>
	        /// 请求id
	        /// </summary>
	        [XmlElement("requestid")]
	        public string Requestid { get; set; }
	
	        /// <summary>
	        /// 资源路径
	        /// </summary>
	        [XmlElement("resource")]
	        public string Resource { get; set; }
}

        #endregion
    }
}
