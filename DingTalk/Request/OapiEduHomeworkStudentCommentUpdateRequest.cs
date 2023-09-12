using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.homework.student.comment.update
    /// </summary>
    public class OapiEduHomeworkStudentCommentUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduHomeworkStudentCommentUpdateResponse>
    {
        /// <summary>
        /// 扩展属性
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// 业务编码
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 班级ID
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 评论ID
        /// </summary>
        public Nullable<long> CommentId { get; set; }

        /// <summary>
        /// 作业ID
        /// </summary>
        public Nullable<long> HwId { get; set; }

        /// <summary>
        /// 视频
        /// </summary>
        public string Media { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// 学生ID
        /// </summary>
        public string StudentId { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// 老师UserId
        /// </summary>
        public string TeacherUserid { get; set; }

        /// <summary>
        /// 音频
        /// </summary>
        public string Video { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.homework.student.comment.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attributes", this.Attributes);
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("class_id", this.ClassId);
            parameters.Add("comment", this.Comment);
            parameters.Add("comment_id", this.CommentId);
            parameters.Add("hw_id", this.HwId);
            parameters.Add("media", this.Media);
            parameters.Add("photo", this.Photo);
            parameters.Add("student_id", this.StudentId);
            parameters.Add("student_name", this.StudentName);
            parameters.Add("teacher_userid", this.TeacherUserid);
            parameters.Add("video", this.Video);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("class_id", this.ClassId);
            RequestValidator.ValidateRequired("comment_id", this.CommentId);
            RequestValidator.ValidateRequired("student_id", this.StudentId);
            RequestValidator.ValidateRequired("teacher_userid", this.TeacherUserid);
        }

        #endregion
    }
}
