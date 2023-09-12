using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.delete
    /// </summary>
    public class OapiProcessDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessDeleteResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Request { get; set; }

        public DeleteProcessRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.delete";
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
/// DeleteProcessRequestDomain Data Structure.
/// </summary>
[Serializable]

public class DeleteProcessRequestDomain : TopObject
{
	        /// <summary>
	        /// 微应用agentId，ISV必填
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 是否清理运行中的任务
	        /// </summary>
	        [XmlElement("clean_running_task")]
	        public Nullable<bool> CleanRunningTask { get; set; }
	
	        /// <summary>
	        /// 流程code
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
}

        #endregion
    }
}
