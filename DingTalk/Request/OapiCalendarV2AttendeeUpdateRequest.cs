using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.calendar.v2.attendee.update
    /// </summary>
    public class OapiCalendarV2AttendeeUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCalendarV2AttendeeUpdateResponse>
    {
        /// <summary>
        /// 开放平台应用对应的AgentId
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 参与者列表
        /// </summary>
        public string Attendees { get; set; }

        public List<AttendeeDomain> Attendees_ { set { this.Attendees = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 日历id,目前仅支持传primary，表示修改的是“我的日程”下的日程
        /// </summary>
        public string CalendarId { get; set; }

        /// <summary>
        /// 加密后的日程Id
        /// </summary>
        public string EventId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.calendar.v2.attendee.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("attendees", this.Attendees);
            parameters.Add("calendar_id", this.CalendarId);
            parameters.Add("event_id", this.EventId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("attendees", this.Attendees);
            RequestValidator.ValidateObjectMaxListSize("attendees", this.Attendees, 20);
            RequestValidator.ValidateRequired("calendar_id", this.CalendarId);
            RequestValidator.ValidateMaxLength("calendar_id", this.CalendarId, 64);
            RequestValidator.ValidateRequired("event_id", this.EventId);
            RequestValidator.ValidateMaxLength("event_id", this.EventId, 64);
        }

	/// <summary>
/// AttendeeDomain Data Structure.
/// </summary>
[Serializable]

public class AttendeeDomain : TopObject
{
	        /// <summary>
	        /// 添加或者删除状态，add:添加；remove:删除
	        /// </summary>
	        [XmlElement("attendee_status")]
	        public string AttendeeStatus { get; set; }
	
	        /// <summary>
	        /// 员工工号
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
