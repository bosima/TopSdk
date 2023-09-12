using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.schedule.async
    /// </summary>
    public class OapiAttendanceGroupScheduleAsyncRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupScheduleAsyncResponse>
    {
        /// <summary>
        /// 考勤组id
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        /// <summary>
        /// 操作者userId
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string Schedules { get; set; }

        public List<TopScheduleParamDomain> Schedules_ { set { this.Schedules = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.group.schedule.async";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_id", this.GroupId);
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("schedules", this.Schedules);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_id", this.GroupId);
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
            RequestValidator.ValidateObjectMaxListSize("schedules", this.Schedules, 201);
        }

	/// <summary>
/// TopScheduleParamDomain Data Structure.
/// </summary>
[Serializable]

public class TopScheduleParamDomain : TopObject
{
	        /// <summary>
	        /// 是否休息（true表示休息，shift_id传1）
	        /// </summary>
	        [XmlElement("is_rest")]
	        public Nullable<bool> IsRest { get; set; }
	
	        /// <summary>
	        /// 班次id（休息班传1，清空班次传-2）
	        /// </summary>
	        [XmlElement("shift_id")]
	        public Nullable<long> ShiftId { get; set; }
	
	        /// <summary>
	        /// 人员userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 排班日期
	        /// </summary>
	        [XmlElement("work_date")]
	        public Nullable<long> WorkDate { get; set; }
}

        #endregion
    }
}
