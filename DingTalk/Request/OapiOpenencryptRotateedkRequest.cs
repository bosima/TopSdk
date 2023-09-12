using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.openencrypt.rotateedk
    /// </summary>
    public class OapiOpenencryptRotateedkRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiOpenencryptRotateedkResponse>
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public string TopEdkRotateManual { get; set; }

        public TopEdkRotateManualDomain TopEdkRotateManual_ { set { this.TopEdkRotateManual = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.openencrypt.rotateedk";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("top_edk_rotate_manual", this.TopEdkRotateManual);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("top_edk_rotate_manual", this.TopEdkRotateManual);
        }

	/// <summary>
/// TopEdkRotateManualDomain Data Structure.
/// </summary>
[Serializable]

public class TopEdkRotateManualDomain : TopObject
{
	        /// <summary>
	        /// 企业内部应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
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
