using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.workrecord.update
    /// </summary>
    public class OapiProcessWorkrecordUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessWorkrecordUpdateResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public UpdateProcessInstanceRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.workrecord.update";
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
/// UpdateProcessInstanceRequestDomain Data Structure.
/// </summary>
[Serializable]

public class UpdateProcessInstanceRequestDomain : TopObject
{
	        /// <summary>
	        /// 应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 取消任务
	        /// </summary>
	        [XmlElement("cancel_running_task")]
	        public Nullable<bool> CancelRunningTask { get; set; }
	
	        /// <summary>
	        /// 实例id
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
	
	        /// <summary>
	        /// 实例结果, 如果实例状态是COMPLETED，需要设置result，分为agree和refuse
	        /// </summary>
	        [XmlElement("result")]
	        public string Result { get; set; }
	
	        /// <summary>
	        /// 实例状态，分为COMPLETED, TERMINATED
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

        #endregion
    }
}
