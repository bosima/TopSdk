using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.calendar.v2.event.update
    /// </summary>
    public class OapiCalendarV2EventUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCalendarV2EventUpdateResponse>
    {
        /// <summary>
        /// 开放平台应用对应的AgentId
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 日程创建对象
        /// </summary>
        public string Event { get; set; }

        public EventDomain Event_ { set { this.Event = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.calendar.v2.event.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("event", this.Event);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("event", this.Event);
        }

	/// <summary>
/// AttendeeDomain Data Structure.
/// </summary>
[Serializable]

public class AttendeeDomain : TopObject
{
	        /// <summary>
	        /// 添加或者删除状态，add:添加；remove:删除；若通过该接口新增或删除参会人，则该字段必填
	        /// </summary>
	        [XmlElement("attendee_status")]
	        public string AttendeeStatus { get; set; }
	
	        /// <summary>
	        /// 员工工号,若通过该接口新增或删除参会人，则该字段必填
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
	        public Nullable<long> Timestamp { get; set; }
	
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
	        /// 开始前提醒的分钟数,有效值为0，5，15，30，60，1440
	        /// </summary>
	        [XmlElement("minutes")]
	        public Nullable<long> Minutes { get; set; }
}

	/// <summary>
/// LocationVoDomain Data Structure.
/// </summary>
[Serializable]

public class LocationVoDomain : TopObject
{
	        /// <summary>
	        /// 纬度
	        /// </summary>
	        [XmlElement("latitude")]
	        public string Latitude { get; set; }
	
	        /// <summary>
	        /// 经度
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
	        /// 日程参与者，参与人数最多100人，包括组织者
	        /// </summary>
	        [XmlArray("attendees")]
	        [XmlArrayItem("attendee")]
	        public List<AttendeeDomain> Attendees { get; set; }
	
	        /// <summary>
	        /// 日历ID,目前仅支持传primary,表示修改当前用户“我的日程”下的日程
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
	        /// 日程Id
	        /// </summary>
	        [XmlElement("event_id")]
	        public string EventId { get; set; }
	
	        /// <summary>
	        /// 地址
	        /// </summary>
	        [XmlElement("location")]
	        public LocationVoDomain Location { get; set; }
	
	        /// <summary>
	        /// 日程组织者,暂不支持修改
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

        #endregion
    }
}
