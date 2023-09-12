using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.group.member.update
    /// </summary>
    public class OapiAttendanceGroupMemberUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceGroupMemberUpdateResponse>
    {
        /// <summary>
        /// 考勤组id
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 0表示从今天开始排班，1表示从明天
        /// </summary>
        public Nullable<long> ScheduleFlag { get; set; }

        /// <summary>
        /// 更新入参
        /// </summary>
        public string UpdateParam { get; set; }

        public TopGroupMemberUpdateParamDomain UpdateParam_ { set { this.UpdateParam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.group.member.update";
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
            parameters.Add("schedule_flag", this.ScheduleFlag);
            parameters.Add("update_param", this.UpdateParam);
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
            RequestValidator.ValidateRequired("schedule_flag", this.ScheduleFlag);
            RequestValidator.ValidateRequired("update_param", this.UpdateParam);
        }

	/// <summary>
/// TopGroupMemberUpdateParamDomain Data Structure.
/// </summary>
[Serializable]

public class TopGroupMemberUpdateParamDomain : TopObject
{
	        /// <summary>
	        /// 要添加的考勤部门，没有的话，无需赋值
	        /// </summary>
	        [XmlArray("add_depts")]
	        [XmlArrayItem("string")]
	        public List<string> AddDepts { get; set; }
	
	        /// <summary>
	        /// 要添加的无需考勤人员，没有的话，无需赋值
	        /// </summary>
	        [XmlArray("add_extra_users")]
	        [XmlArrayItem("string")]
	        public List<string> AddExtraUsers { get; set; }
	
	        /// <summary>
	        /// 要添加的考勤人员，没有的话，无需赋值
	        /// </summary>
	        [XmlArray("add_users")]
	        [XmlArrayItem("string")]
	        public List<string> AddUsers { get; set; }
	
	        /// <summary>
	        /// 要删除的考勤部门，没有的话，无需赋值
	        /// </summary>
	        [XmlArray("remove_depts")]
	        [XmlArrayItem("string")]
	        public List<string> RemoveDepts { get; set; }
	
	        /// <summary>
	        /// 要删除的无需考勤人员，没有的话，无需赋值
	        /// </summary>
	        [XmlArray("remove_extra_users")]
	        [XmlArrayItem("string")]
	        public List<string> RemoveExtraUsers { get; set; }
	
	        /// <summary>
	        /// 要删除的考勤人员，没有的话，无需赋值
	        /// </summary>
	        [XmlArray("remove_users")]
	        [XmlArrayItem("string")]
	        public List<string> RemoveUsers { get; set; }
}

        #endregion
    }
}
