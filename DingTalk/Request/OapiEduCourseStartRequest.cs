using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.start
    /// </summary>
    public class OapiEduCourseStartRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseStartResponse>
    {
        /// <summary>
        /// 需要开始的课程编码
        /// </summary>
        public string CourseCode { get; set; }

        /// <summary>
        /// 操作用户id
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 开始课程的可选属性设定
        /// </summary>
        public string StartOption { get; set; }

        public StartOptionDomain StartOption_ { set { this.StartOption = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.start";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("course_code", this.CourseCode);
            parameters.Add("op_user_id", this.OpUserId);
            parameters.Add("start_option", this.StartOption);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("course_code", this.CourseCode);
            RequestValidator.ValidateRequired("op_user_id", this.OpUserId);
        }

	/// <summary>
/// StartOptionDomain Data Structure.
/// </summary>
[Serializable]

public class StartOptionDomain : TopObject
{
	        /// <summary>
	        /// 该课堂是否允许提前进入，时效最早为提前30分钟
	        /// </summary>
	        [XmlElement("b_allow_join_in_advance")]
	        public Nullable<bool> BAllowJoinInAdvance { get; set; }
}

        #endregion
    }
}
