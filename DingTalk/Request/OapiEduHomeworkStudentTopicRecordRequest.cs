using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.homework.student.topic.record
    /// </summary>
    public class OapiEduHomeworkStudentTopicRecordRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduHomeworkStudentTopicRecordResponse>
    {
        /// <summary>
        /// 答题记录详情
        /// </summary>
        public string StudentAnswerDetails { get; set; }

        public List<StudentAnswerDetailDomain> StudentAnswerDetails_ { set { this.StudentAnswerDetails = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.homework.student.topic.record";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("student_answer_details", this.StudentAnswerDetails);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("student_answer_details", this.StudentAnswerDetails, 20);
        }

	/// <summary>
/// StudentAnswerDetailDomain Data Structure.
/// </summary>
[Serializable]

public class StudentAnswerDetailDomain : TopObject
{
	        /// <summary>
	        /// 学生答题时间戳
	        /// </summary>
	        [XmlElement("answer_time")]
	        public Nullable<long> AnswerTime { get; set; }
	
	        /// <summary>
	        /// 扩展属性
	        /// </summary>
	        [XmlElement("attributes")]
	        public string Attributes { get; set; }
	
	        /// <summary>
	        /// 业务编码
	        /// </summary>
	        [XmlElement("biz_code")]
	        public string BizCode { get; set; }
	
	        /// <summary>
	        /// 班级ID
	        /// </summary>
	        [XmlElement("class_id")]
	        public string ClassId { get; set; }
	
	        /// <summary>
	        /// 作业ID
	        /// </summary>
	        [XmlElement("hw_id")]
	        public Nullable<long> HwId { get; set; }
	
	        /// <summary>
	        /// 是否答对
	        /// </summary>
	        [XmlElement("is_right")]
	        public string IsRight { get; set; }
	
	        /// <summary>
	        /// 题目ID
	        /// </summary>
	        [XmlElement("question_id")]
	        public string QuestionId { get; set; }
	
	        /// <summary>
	        /// 做了多少次
	        /// </summary>
	        [XmlElement("redo_times")]
	        public Nullable<long> RedoTimes { get; set; }
	
	        /// <summary>
	        /// 做题时间
	        /// </summary>
	        [XmlElement("spend_time")]
	        public Nullable<long> SpendTime { get; set; }
	
	        /// <summary>
	        /// 学生提交的答案
	        /// </summary>
	        [XmlElement("student_answer")]
	        public string StudentAnswer { get; set; }
	
	        /// <summary>
	        /// 学生ID
	        /// </summary>
	        [XmlElement("student_id")]
	        public string StudentId { get; set; }
	
	        /// <summary>
	        /// 学生姓名
	        /// </summary>
	        [XmlElement("student_name")]
	        public string StudentName { get; set; }
}

        #endregion
    }
}
