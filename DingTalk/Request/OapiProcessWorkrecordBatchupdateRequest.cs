using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.workrecord.batchupdate
    /// </summary>
    public class OapiProcessWorkrecordBatchupdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessWorkrecordBatchupdateResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public BatchUpdateProcessInstanceRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.workrecord.batchupdate";
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
/// UpdateProcessInstanceRequestDomain Data Structure.
/// </summary>
[Serializable]

public class UpdateProcessInstanceRequestDomain : TopObject
{
	        /// <summary>
	        /// 实例id，通过创建待办实例接口获取
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
	
	        /// <summary>
	        /// 任务结果，分为agree和refuse
	        /// </summary>
	        [XmlElement("result")]
	        public string Result { get; set; }
	
	        /// <summary>
	        /// 实例状态，分为COMPLETED, TERMINATED
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
}

	/// <summary>
/// BatchUpdateProcessInstanceRequestDomain Data Structure.
/// </summary>
[Serializable]

public class BatchUpdateProcessInstanceRequestDomain : TopObject
{
	        /// <summary>
	        /// 企业应用标识
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 实例列表
	        /// </summary>
	        [XmlArray("instances")]
	        [XmlArrayItem("update_process_instance_request")]
	        public List<UpdateProcessInstanceRequestDomain> Instances { get; set; }
}

        #endregion
    }
}
