using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.form.condition.list
    /// </summary>
    public class OapiProcessFormConditionListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessFormConditionListResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public QureyProcessRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.form.condition.list";
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
/// QureyProcessRequestDomain Data Structure.
/// </summary>
[Serializable]

public class QureyProcessRequestDomain : TopObject
{
	        /// <summary>
	        /// 应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 审批模板id
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
}

        #endregion
    }
}
