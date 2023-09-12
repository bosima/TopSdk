using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.participant.batchadd
    /// </summary>
    public class OapiEduCourseParticipantBatchaddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseParticipantBatchaddResponse>
    {
        /// <summary>
        /// 课程编码集合
        /// </summary>
        public string CourseCodes { get; set; }

        /// <summary>
        /// 参与方列表
        /// </summary>
        public string CourseParticipants { get; set; }

        public List<CourseParticipantBaseDTODomain> CourseParticipants_ { set { this.CourseParticipants = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 当前用户ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 参与方的组织CropId
        /// </summary>
        public string ParticipantCorpid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.participant.batchadd";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("course_codes", this.CourseCodes);
            parameters.Add("course_participants", this.CourseParticipants);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("participant_corpid", this.ParticipantCorpid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("course_codes", this.CourseCodes);
            RequestValidator.ValidateMaxListSize("course_codes", this.CourseCodes, 10);
            RequestValidator.ValidateRequired("course_participants", this.CourseParticipants);
            RequestValidator.ValidateObjectMaxListSize("course_participants", this.CourseParticipants, 100);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("participant_corpid", this.ParticipantCorpid);
        }

	/// <summary>
/// CourseParticipantOptionDomain Data Structure.
/// </summary>
[Serializable]

public class CourseParticipantOptionDomain : TopObject
{
	        /// <summary>
	        /// 群类型：teacherStudentGroup（师生群）、officialClassGroup（家校群）
	        /// </summary>
	        [XmlElement("groupType")]
	        public string GroupType { get; set; }
}

	/// <summary>
/// CourseParticipantBaseDTODomain Data Structure.
/// </summary>
[Serializable]

public class CourseParticipantBaseDTODomain : TopObject
{
	        /// <summary>
	        /// 参与方选项信息
	        /// </summary>
	        [XmlElement("option")]
	        public CourseParticipantOptionDomain Option { get; set; }
	
	        /// <summary>
	        /// 参与方ID。participant_type=1时，participant_id表示用户ID；participant_type=2时，participant_id表示部门ID；participant_type=3时，participant_id表示组织ID；
	        /// </summary>
	        [XmlElement("participant_id")]
	        public string ParticipantId { get; set; }
	
	        /// <summary>
	        /// 参与方类型。1：用户、2：部门（对应家校通讯录中的班级、年级。详情请参考https://ding-doc.dingtalk.com/doc#/serverapi3/gga05a/z3y0h）、3：组织
	        /// </summary>
	        [XmlElement("participant_type")]
	        public Nullable<long> ParticipantType { get; set; }
	
	        /// <summary>
	        /// 参与方角色。student：学生、guardian: 监护人、teacher：老师（注意：授课老师只支持通过课程创建和修改接口，进行添加和修改）
	        /// </summary>
	        [XmlElement("role")]
	        public string Role { get; set; }
}

        #endregion
    }
}
