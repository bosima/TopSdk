using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.schedule.clear
    /// </summary>
    public class OapiAttendanceGroupScheduleClearRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupScheduleClearResponse>
    {
        /// <summary>
        /// 操作者userid
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string Param { get; set; }

        public TopClearScheduleParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.group.schedule.clear";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("param", this.Param);
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
/// TopClearScheduleParamDomain Data Structure.
/// </summary>
[Serializable]

public class TopClearScheduleParamDomain : TopObject
{
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("from_date")]
	        public Nullable<long> FromDate { get; set; }
	
	        /// <summary>
	        /// 考勤组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("to_date")]
	        public Nullable<long> ToDate { get; set; }
	
	        /// <summary>
	        /// 用户userId列表
	        /// </summary>
	        [XmlArray("user_ids")]
	        [XmlArrayItem("string")]
	        public List<string> UserIds { get; set; }
}

        #endregion
    }
}
