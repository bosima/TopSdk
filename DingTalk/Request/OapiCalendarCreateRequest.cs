using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.calendar.create
    /// </summary>
    public class OapiCalendarCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCalendarCreateResponse>
    {
        /// <summary>
        /// 创建日程实体
        /// </summary>
        public string CreateVo { get; set; }

        public OpenCalendarCreateVoDomain CreateVo_ { set { this.CreateVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.calendar.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("create_vo", this.CreateVo);
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
/// OpenCalendarReminderVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCalendarReminderVoDomain : TopObject
{
	        /// <summary>
	        /// 距开始时多久进行提醒(单位:分钟)
	        /// </summary>
	        [XmlElement("minutes")]
	        public Nullable<long> Minutes { get; set; }
	
	        /// <summary>
	        /// 提醒类型:app-应用内;
	        /// </summary>
	        [XmlElement("remind_type")]
	        public string RemindType { get; set; }
}

	/// <summary>
/// DatetimeVoDomain Data Structure.
/// </summary>
[Serializable]

public class DatetimeVoDomain : TopObject
{
	        /// <summary>
	        /// 时区
	        /// </summary>
	        [XmlElement("timezone")]
	        public string Timezone { get; set; }
	
	        /// <summary>
	        /// 结束的unix时间戳(单位:毫秒)
	        /// </summary>
	        [XmlElement("unix_timestamp")]
	        public Nullable<long> UnixTimestamp { get; set; }
}

	/// <summary>
/// OpenCalendarSourceVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCalendarSourceVoDomain : TopObject
{
	        /// <summary>
	        /// 日程来源
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 点击日程跳转目标地址
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// OpenCalendarCreateVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCalendarCreateVoDomain : TopObject
{
	        /// <summary>
	        /// 业务方自己的主键
	        /// </summary>
	        [XmlElement("biz_id")]
	        public string BizId { get; set; }
	
	        /// <summary>
	        /// 日程类型:task-任务;meeting-会议;notification-提醒
	        /// </summary>
	        [XmlElement("calendar_type")]
	        public string CalendarType { get; set; }
	
	        /// <summary>
	        /// 创建者工号
	        /// </summary>
	        [XmlElement("creator_userid")]
	        public string CreatorUserid { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public DatetimeVoDomain EndTime { get; set; }
	
	        /// <summary>
	        /// 地点
	        /// </summary>
	        [XmlElement("location")]
	        public string Location { get; set; }
	
	        /// <summary>
	        /// 接收者工号
	        /// </summary>
	        [XmlArray("receiver_userids")]
	        [XmlArrayItem("string")]
	        public List<string> ReceiverUserids { get; set; }
	
	        /// <summary>
	        /// 事项开始前提醒
	        /// </summary>
	        [XmlElement("reminder")]
	        public OpenCalendarReminderVoDomain Reminder { get; set; }
	
	        /// <summary>
	        /// 显示日程来源
	        /// </summary>
	        [XmlElement("source")]
	        public OpenCalendarSourceVoDomain Source { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public DatetimeVoDomain StartTime { get; set; }
	
	        /// <summary>
	        /// 主题
	        /// </summary>
	        [XmlElement("summary")]
	        public string Summary { get; set; }
	
	        /// <summary>
	        /// 请求的唯一标识, 保证请求唯一性
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

        #endregion
    }
}
