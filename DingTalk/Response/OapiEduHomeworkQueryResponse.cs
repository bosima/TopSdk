using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduHomeworkQueryResponse.
    /// </summary>
    public class OapiEduHomeworkQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误编码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public OpenHwDetailResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenHwDetailResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenHwDetailResponseDomain : TopObject
{
	        /// <summary>
	        /// 扩展属性
	        /// </summary>
	        [XmlElement("attributes")]
	        public string Attributes { get; set; }
	
	        /// <summary>
	        /// 作业内容
	        /// </summary>
	        [XmlElement("hw_content")]
	        public string HwContent { get; set; }
	
	        /// <summary>
	        /// 作业视频
	        /// </summary>
	        [XmlElement("hw_media")]
	        public string HwMedia { get; set; }
	
	        /// <summary>
	        /// 作业图片
	        /// </summary>
	        [XmlElement("hw_photo")]
	        public string HwPhoto { get; set; }
	
	        /// <summary>
	        /// 作业状态
	        /// </summary>
	        [XmlElement("hw_status")]
	        public string HwStatus { get; set; }
	
	        /// <summary>
	        /// 作业标题
	        /// </summary>
	        [XmlElement("hw_title")]
	        public string HwTitle { get; set; }
	
	        /// <summary>
	        /// 作业录音
	        /// </summary>
	        [XmlElement("hw_video")]
	        public string HwVideo { get; set; }
	
	        /// <summary>
	        /// 是否定时作业
	        /// </summary>
	        [XmlElement("scheduled_release")]
	        public string ScheduledRelease { get; set; }
	
	        /// <summary>
	        /// 定时发送事件
	        /// </summary>
	        [XmlElement("scheduled_time")]
	        public string ScheduledTime { get; set; }
	
	        /// <summary>
	        /// 发送时间
	        /// </summary>
	        [XmlElement("send_time")]
	        public string SendTime { get; set; }
	
	        /// <summary>
	        /// 老师ID
	        /// </summary>
	        [XmlElement("teacher_id")]
	        public string TeacherId { get; set; }
	
	        /// <summary>
	        /// 老师姓名
	        /// </summary>
	        [XmlElement("teacher_name")]
	        public string TeacherName { get; set; }
}

    }
}
