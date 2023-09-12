using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.course.participant.remove
    /// </summary>
    public class OapiEduCourseParticipantRemoveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCourseParticipantRemoveResponse>
    {
        /// <summary>
        /// 课程编码
        /// </summary>
        public string CourseCode { get; set; }

        /// <summary>
        /// 当前用户ID
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 参与方的组织CropId
        /// </summary>
        public string ParticipantCorpid { get; set; }

        /// <summary>
        /// 参与方ID。participant_type=1时，participant_id表示用户ID；participant_type=2时，participant_id表示部门ID；participant_type=3时，participant_id表示组织ID；
        /// </summary>
        public string ParticipantId { get; set; }

        /// <summary>
        /// 1：用户、2：部门（对应家校通讯录中的班级、年级。详情请参考https://ding-doc.dingtalk.com/doc#/serverapi3/gga05a/z3y0h）、3：组织
        /// </summary>
        public Nullable<long> ParticipantType { get; set; }

        /// <summary>
        /// student：学生、guardian: 监护人、teacher：老师（注意：授课老师不支持移除）
        /// </summary>
        public string Role { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.course.participant.remove";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("course_code", this.CourseCode);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("participant_corpid", this.ParticipantCorpid);
            parameters.Add("participant_id", this.ParticipantId);
            parameters.Add("participant_type", this.ParticipantType);
            parameters.Add("role", this.Role);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("course_code", this.CourseCode);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("participant_corpid", this.ParticipantCorpid);
            RequestValidator.ValidateRequired("participant_id", this.ParticipantId);
            RequestValidator.ValidateRequired("participant_type", this.ParticipantType);
            RequestValidator.ValidateRequired("role", this.Role);
        }

        #endregion
    }
}
