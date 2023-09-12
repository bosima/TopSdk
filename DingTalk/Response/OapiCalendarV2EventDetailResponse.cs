using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCalendarV2EventDetailResponse.
    /// </summary>
    public class OapiCalendarV2EventDetailResponse : DingTalkResponse
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
        /// 日程对象
        /// </summary>
        [XmlElement("result")]
        public EventDomain Result { get; set; }

        /// <summary>
        /// 结果是否正确
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// AttendeeDomain Data Structure.
/// </summary>
[Serializable]

public class AttendeeDomain : TopObject
{
	        /// <summary>
	        /// 员工工号
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// DateTimeDomain Data Structure.
/// </summary>
[Serializable]

public class DateTimeDomain : TopObject
{
	        /// <summary>
	        /// 日期，全天日程使用，格式必须为'yyyy-mm-dd',和timestamp字段互斥，该字段有值时，则忽略timestamp字段
	        /// </summary>
	        [XmlElement("date")]
	        public string Date { get; set; }
	
	        /// <summary>
	        /// 时间戳，单位为秒。非全天日程使用，与date字段互斥
	        /// </summary>
	        [XmlElement("timestamp")]
	        public long Timestamp { get; set; }
	
	        /// <summary>
	        /// 时区信息，默认为"Asia/Shanghai"。date有值时，timezone 为 UTC；
	        /// </summary>
	        [XmlElement("timezone")]
	        public string Timezone { get; set; }
}

	/// <summary>
/// OpenCalendarReminderVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCalendarReminderVoDomain : TopObject
{
	        /// <summary>
	        /// 提醒方式.app表示应用内提醒
	        /// </summary>
	        [XmlElement("method")]
	        public string Method { get; set; }
	
	        /// <summary>
	        /// 会议开始前多少分钟提醒
	        /// </summary>
	        [XmlElement("minutes")]
	        public long Minutes { get; set; }
}

	/// <summary>
/// LocationVoDomain Data Structure.
/// </summary>
[Serializable]

public class LocationVoDomain : TopObject
{
	        /// <summary>
	        /// 经度
	        /// </summary>
	        [XmlElement("latitude")]
	        public string Latitude { get; set; }
	
	        /// <summary>
	        /// 纬度
	        /// </summary>
	        [XmlElement("longitude")]
	        public string Longitude { get; set; }
	
	        /// <summary>
	        /// 地址详情
	        /// </summary>
	        [XmlElement("place")]
	        public string Place { get; set; }
}

	/// <summary>
/// EventDomain Data Structure.
/// </summary>
[Serializable]

public class EventDomain : TopObject
{
	        /// <summary>
	        /// 日程参与者
	        /// </summary>
	        [XmlArray("attendees")]
	        [XmlArrayItem("attendee")]
	        public List<AttendeeDomain> Attendees { get; set; }
	
	        /// <summary>
	        /// primary表示创建的日程在“我的日程”下
	        /// </summary>
	        [XmlElement("calendar_id")]
	        public string CalendarId { get; set; }
	
	        /// <summary>
	        /// 日程描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end")]
	        public DateTimeDomain End { get; set; }
	
	        /// <summary>
	        /// 日程id
	        /// </summary>
	        [XmlElement("event_id")]
	        public string EventId { get; set; }
	
	        /// <summary>
	        /// 地址
	        /// </summary>
	        [XmlElement("location")]
	        public LocationVoDomain Location { get; set; }
	
	        /// <summary>
	        /// 会前提醒方式
	        /// </summary>
	        [XmlElement("notification_type")]
	        public string NotificationType { get; set; }
	
	        /// <summary>
	        /// 日程组织者
	        /// </summary>
	        [XmlElement("organizer")]
	        public AttendeeDomain Organizer { get; set; }
	
	        /// <summary>
	        /// 会议开始前提醒
	        /// </summary>
	        [XmlElement("reminder")]
	        public OpenCalendarReminderVoDomain Reminder { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start")]
	        public DateTimeDomain Start { get; set; }
	
	        /// <summary>
	        /// 日程主题
	        /// </summary>
	        [XmlElement("summary")]
	        public string Summary { get; set; }
}

    }
}
