using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.openencrypt.updateconfig
    /// </summary>
    public class OapiOpenencryptUpdateconfigRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiOpenencryptUpdateconfigResponse>
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public string TopResourceKmsConfig { get; set; }

        public TopResourceKmsConfigDomain TopResourceKmsConfig_ { set { this.TopResourceKmsConfig = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.openencrypt.updateconfig";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("top_resource_kms_config", this.TopResourceKmsConfig);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("top_resource_kms_config", this.TopResourceKmsConfig);
        }

	/// <summary>
/// TopResourceKmsConfigDomain Data Structure.
/// </summary>
[Serializable]

public class TopResourceKmsConfigDomain : TopObject
{
	        /// <summary>
	        /// 企业内部应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 扩展字段,json格式
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
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
	
	        /// <summary>
	        /// 轮转周期
	        /// </summary>
	        [XmlElement("rotate_period_day")]
	        public Nullable<long> RotatePeriodDay { get; set; }
}

        #endregion
    }
}
