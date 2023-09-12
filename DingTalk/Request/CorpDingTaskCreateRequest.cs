using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.ding.task.create
    /// </summary>
    public class CorpDingTaskCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpDingTaskCreateResponse>
    {
        /// <summary>
        /// 任务对外接口
        /// </summary>
        public string TaskSendVO { get; set; }

        public TaskSendVoDomain TaskSendVO_ { set { this.TaskSendVO = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.ding.task.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("task_send_v_o", this.TaskSendVO);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("task_send_v_o", this.TaskSendVO);
        }

	/// <summary>
/// TaskSendVoDomain Data Structure.
/// </summary>
[Serializable]

public class TaskSendVoDomain : TopObject
{
	        /// <summary>
	        /// 任务内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 任务内容类型；1-文本；目前只支持文本；
	        /// </summary>
	        [XmlElement("content_type")]
	        public Nullable<long> ContentType { get; set; }
	
	        /// <summary>
	        /// 任务截止时间（单位：毫秒），datetime转成long
	        /// </summary>
	        [XmlElement("dead_line")]
	        public Nullable<long> DeadLine { get; set; }
	
	        /// <summary>
	        /// 任务执行人
	        /// </summary>
	        [XmlElement("receiver_userid")]
	        public string ReceiverUserid { get; set; }
	
	        /// <summary>
	        /// 提醒时间（单位：毫秒），datetime转成long
	        /// </summary>
	        [XmlElement("remind_time")]
	        public Nullable<long> RemindTime { get; set; }
	
	        /// <summary>
	        /// 提醒方式；1-应用内；目前只支持应用内；
	        /// </summary>
	        [XmlElement("remind_type")]
	        public Nullable<long> RemindType { get; set; }
	
	        /// <summary>
	        /// 发送者ID
	        /// </summary>
	        [XmlElement("send_userid")]
	        public string SendUserid { get; set; }
}

        #endregion
    }
}
