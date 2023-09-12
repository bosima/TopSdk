using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.reimbursement.appstatus.sync
    /// </summary>
    public class OapiAlitripBtripReimbursementAppstatusSyncRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripReimbursementAppstatusSyncResponse>
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public string Rq { get; set; }

        public OpenApiUpdateAppStatusRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.reimbursement.appstatus.sync";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("rq", this.Rq);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("rq", this.Rq);
        }

	/// <summary>
/// OpenApiUpdateAppStatusRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiUpdateAppStatusRqDomain : TopObject
{
	        /// <summary>
	        /// corp id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 是否已经安装（app是否正常提供服务）
	        /// </summary>
	        [XmlElement("installed")]
	        public Nullable<bool> Installed { get; set; }
	
	        /// <summary>
	        /// isv 代码
	        /// </summary>
	        [XmlElement("isv_code")]
	        public string IsvCode { get; set; }
	
	        /// <summary>
	        /// app版本
	        /// </summary>
	        [XmlElement("version")]
	        public string Version { get; set; }
}

        #endregion
    }
}
