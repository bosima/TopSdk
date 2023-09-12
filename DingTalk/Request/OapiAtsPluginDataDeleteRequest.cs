using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.plugin.data.delete
    /// </summary>
    public class OapiAtsPluginDataDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsPluginDataDeleteResponse>
    {
        /// <summary>
        /// 业务唯一标识，接入前请提前沟通
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 推送头信息
        /// </summary>
        public string Header { get; set; }

        public PushHeaderVODomain Header_ { set { this.Header = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 外部业务唯一ID
        /// </summary>
        public string OutId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.plugin.data.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("header", this.Header);
            parameters.Add("out_id", this.OutId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("header", this.Header);
            RequestValidator.ValidateRequired("out_id", this.OutId);
        }

	/// <summary>
/// PushHeaderVODomain Data Structure.
/// </summary>
[Serializable]

public class PushHeaderVODomain : TopObject
{
	        /// <summary>
	        /// 插件唯一标识，接入前请提前沟通
	        /// </summary>
	        [XmlElement("plugin_code")]
	        public string PluginCode { get; set; }
	
	        /// <summary>
	        /// schema唯一标识，接入前请提前沟通
	        /// </summary>
	        [XmlElement("schema_id")]
	        public string SchemaId { get; set; }
}

        #endregion
    }
}
