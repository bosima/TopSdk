using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.shift.updatepunches
    /// </summary>
    public class OapiAttendanceShiftUpdatepunchesRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceShiftUpdatepunchesResponse>
    {
        /// <summary>
        /// 操作者userId
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string Punches { get; set; }

        public List<TopPunchVODomain> Punches_ { set { this.Punches = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 班次id
        /// </summary>
        public Nullable<long> ShiftId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.shift.updatepunches";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("punches", this.Punches);
            parameters.Add("shift_id", this.ShiftId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
            RequestValidator.ValidateObjectMaxListSize("punches", this.Punches, 20);
            RequestValidator.ValidateRequired("shift_id", this.ShiftId);
        }

	/// <summary>
/// TopPunchVODomain Data Structure.
/// </summary>
[Serializable]

public class TopPunchVODomain : TopObject
{
	        /// <summary>
	        /// 是否无需打卡 true：开启无需打卡，false：关闭无需打卡
	        /// </summary>
	        [XmlElement("free_check")]
	        public Nullable<bool> FreeCheck { get; set; }
	
	        /// <summary>
	        /// 卡点id
	        /// </summary>
	        [XmlElement("id")]
	        public Nullable<long> Id { get; set; }
}

        #endregion
    }
}
