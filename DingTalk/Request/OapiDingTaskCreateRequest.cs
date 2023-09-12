using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ding.task.create
    /// </summary>
    public class OapiDingTaskCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingTaskCreateResponse>
    {
        /// <summary>
        /// 任务对外接口
        /// </summary>
        public string TaskSendVO { get; set; }

        public TaskSendVoDomain TaskSendVO_ { set { this.TaskSendVO = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ding.task.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
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
/// AttachmentVoDomain Data Structure.
/// </summary>
[Serializable]

public class AttachmentVoDomain : TopObject
{
	        /// <summary>
	        /// 文件后缀, 用于展示文件对应图标
	        /// </summary>
	        [XmlElement("detail_type")]
	        public string DetailType { get; set; }
	
	        /// <summary>
	        /// 上传DING盘后的文件ID
	        /// </summary>
	        [XmlElement("file_id")]
	        public string FileId { get; set; }
	
	        /// <summary>
	        /// 文件名
	        /// </summary>
	        [XmlElement("file_name")]
	        public string FileName { get; set; }
	
	        /// <summary>
	        /// 文件大小(单位:Byte, 最大2G)
	        /// </summary>
	        [XmlElement("file_size")]
	        public Nullable<long> FileSize { get; set; }
	
	        /// <summary>
	        /// 上传DING盘后的SpaceId
	        /// </summary>
	        [XmlElement("file_space_id")]
	        public string FileSpaceId { get; set; }
	
	        /// <summary>
	        /// 链接缩略图
	        /// </summary>
	        [XmlElement("link_pic_url")]
	        public string LinkPicUrl { get; set; }
	
	        /// <summary>
	        /// 链接摘要
	        /// </summary>
	        [XmlElement("link_text")]
	        public string LinkText { get; set; }
	
	        /// <summary>
	        /// 链接标题
	        /// </summary>
	        [XmlElement("link_title")]
	        public string LinkTitle { get; set; }
	
	        /// <summary>
	        /// 链接URL
	        /// </summary>
	        [XmlElement("link_url")]
	        public string LinkUrl { get; set; }
	
	        /// <summary>
	        /// 附件类型:img-图片,link-链接,file-文件
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// TaskSendVoDomain Data Structure.
/// </summary>
[Serializable]

public class TaskSendVoDomain : TopObject
{
	        /// <summary>
	        /// 附件
	        /// </summary>
	        [XmlElement("attachment")]
	        public AttachmentVoDomain Attachment { get; set; }
	
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
	
	        /// <summary>
	        /// 任务截止前提醒时间
	        /// </summary>
	        [XmlElement("task_ahead_remind_time")]
	        public Nullable<long> TaskAheadRemindTime { get; set; }
	
	        /// <summary>
	        /// 提醒类型:1-应用内
	        /// </summary>
	        [XmlElement("task_ahead_remind_type")]
	        public Nullable<long> TaskAheadRemindType { get; set; }
}

        #endregion
    }
}
