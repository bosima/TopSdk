using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.workrecord.task.create
    /// </summary>
    public class OapiProcessWorkrecordTaskCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessWorkrecordTaskCreateResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public SaveTaskRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.workrecord.task.create";
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
	        /// 跳转url
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// SaveTaskRequestDomain Data Structure.
/// </summary>
[Serializable]

public class SaveTaskRequestDomain : TopObject
{
	        /// <summary>
	        /// 节点id
	        /// </summary>
	        [XmlElement("activity_id")]
	        public string ActivityId { get; set; }
	
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
