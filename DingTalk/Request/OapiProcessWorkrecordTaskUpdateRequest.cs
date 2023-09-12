using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.workrecord.task.update
    /// </summary>
    public class OapiProcessWorkrecordTaskUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessWorkrecordTaskUpdateResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public UpdateTaskRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.workrecord.task.update";
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
/// TaskTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class TaskTopVoDomain : TopObject
{
	        /// <summary>
	        /// 任务结果，分为agree和refuse。当status为CANCELED时，不需要传result
	        /// </summary>
	        [XmlElement("result")]
	        public string Result { get; set; }
	
	        /// <summary>
	        /// 任务状态，分为CANCELED和COMPLETED
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 任务id
	        /// </summary>
	        [XmlElement("task_id")]
	        public Nullable<long> TaskId { get; set; }
}

	/// <summary>
/// UpdateTaskRequestDomain Data Structure.
/// </summary>
[Serializable]

public class UpdateTaskRequestDomain : TopObject
{
	        /// <summary>
	        /// 应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 实例id
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
	
	        /// <summary>
	        /// 任务列表
	        /// </summary>
	        [XmlArray("tasks")]
	        [XmlArrayItem("task_top_vo")]
	        public List<TaskTopVoDomain> Tasks { get; set; }
}

        #endregion
    }
}
