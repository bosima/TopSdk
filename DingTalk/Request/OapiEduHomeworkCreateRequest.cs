using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.homework.create
    /// </summary>
    public class OapiEduHomeworkCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduHomeworkCreateResponse>
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
        /// 作业课程名称
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// 作业内容
        /// </summary>
        public string HwContent { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        public Nullable<long> HwDeadline { get; set; }

        /// <summary>
        /// 是否开启截止时间
        /// </summary>
        public string HwDeadlineOpen { get; set; }

        /// <summary>
        /// 作业视频
        /// </summary>
        public string HwMedia { get; set; }

        /// <summary>
        /// 作业图片
        /// </summary>
        public string HwPhoto { get; set; }

        /// <summary>
        /// 作业标题
        /// </summary>
        public string HwTitle { get; set; }

        /// <summary>
        /// 作业类型
        /// </summary>
        public string HwType { get; set; }

        /// <summary>
        /// 作业录音
        /// </summary>
        public string HwVideo { get; set; }

        /// <summary>
        /// 幂等ID字段
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// 是否开始定时调度
        /// </summary>
        public string ScheduledRelease { get; set; }

        /// <summary>
        /// 定时调度时间
        /// </summary>
        public string ScheduledTime { get; set; }

        /// <summary>
        /// 选择的布置班级
        /// </summary>
        public string SelectClass { get; set; }

        public List<ClassInfoItemDomain> SelectClass_ { set { this.SelectClass = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 选择班级对应学生
        /// </summary>
        public string SelectStu { get; set; }

        public List<SelectStuItemDomain> SelectStu_ { set { this.SelectStu = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 发送对象
        /// </summary>
        public string TargetRole { get; set; }

        /// <summary>
        /// 老师名称
        /// </summary>
        public string TeacherName { get; set; }

        /// <summary>
        /// 老师userid
        /// </summary>
        public string TeacherUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.homework.create";
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
            parameters.Add("course_name", this.CourseName);
            parameters.Add("hw_content", this.HwContent);
            parameters.Add("hw_deadline", this.HwDeadline);
            parameters.Add("hw_deadline_open", this.HwDeadlineOpen);
            parameters.Add("hw_media", this.HwMedia);
            parameters.Add("hw_photo", this.HwPhoto);
            parameters.Add("hw_title", this.HwTitle);
            parameters.Add("hw_type", this.HwType);
            parameters.Add("hw_video", this.HwVideo);
            parameters.Add("identifier", this.Identifier);
            parameters.Add("scheduled_release", this.ScheduledRelease);
            parameters.Add("scheduled_time", this.ScheduledTime);
            parameters.Add("select_class", this.SelectClass);
            parameters.Add("select_stu", this.SelectStu);
            parameters.Add("status", this.Status);
            parameters.Add("target_role", this.TargetRole);
            parameters.Add("teacher_name", this.TeacherName);
            parameters.Add("teacher_userid", this.TeacherUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("course_name", this.CourseName);
            RequestValidator.ValidateRequired("hw_content", this.HwContent);
            RequestValidator.ValidateRequired("hw_title", this.HwTitle);
            RequestValidator.ValidateRequired("identifier", this.Identifier);
            RequestValidator.ValidateObjectMaxListSize("select_class", this.SelectClass, 50);
            RequestValidator.ValidateObjectMaxListSize("select_stu", this.SelectStu, 50);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateRequired("teacher_name", this.TeacherName);
            RequestValidator.ValidateRequired("teacher_userid", this.TeacherUserid);
        }

	/// <summary>
/// ClassInfoItemDomain Data Structure.
/// </summary>
[Serializable]

public class ClassInfoItemDomain : TopObject
{
	        /// <summary>
	        /// 班级ID
	        /// </summary>
	        [XmlElement("class_id")]
	        public Nullable<long> ClassId { get; set; }
	
	        /// <summary>
	        /// 班级名称
	        /// </summary>
	        [XmlElement("class_name")]
	        public string ClassName { get; set; }
}

	/// <summary>
/// StuInfoItemDomain Data Structure.
/// </summary>
[Serializable]

public class StuInfoItemDomain : TopObject
{
	        /// <summary>
	        /// 学生userid
	        /// </summary>
	        [XmlElement("stu_id")]
	        public string StuId { get; set; }
	
	        /// <summary>
	        /// 学生姓名
	        /// </summary>
	        [XmlElement("stu_name")]
	        public string StuName { get; set; }
}

	/// <summary>
/// SelectStuItemDomain Data Structure.
/// </summary>
[Serializable]

public class SelectStuItemDomain : TopObject
{
	        /// <summary>
	        /// 班级ID
	        /// </summary>
	        [XmlElement("class_id")]
	        public Nullable<long> ClassId { get; set; }
	
	        /// <summary>
	        /// 班级名称
	        /// </summary>
	        [XmlElement("class_name")]
	        public string ClassName { get; set; }
	
	        /// <summary>
	        /// 选择学生列表
	        /// </summary>
	        [XmlArray("class_stu")]
	        [XmlArrayItem("stu_info_item")]
	        public List<StuInfoItemDomain> ClassStu { get; set; }
}

        #endregion
    }
}
