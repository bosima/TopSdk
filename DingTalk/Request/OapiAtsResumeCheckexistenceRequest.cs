using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.resume.checkexistence
    /// </summary>
    public class OapiAtsResumeCheckexistenceRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsResumeCheckexistenceResponse>
    {
        /// <summary>
        /// 业务唯一标识
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 结构化简历详情
        /// </summary>
        public string ResumeDetailInfo { get; set; }

        public ResumeDetailInfoDomain ResumeDetailInfo_ { set { this.ResumeDetailInfo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.resume.checkexistence";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("resume_detail_info", this.ResumeDetailInfo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
        }

	/// <summary>
/// ProjectInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ProjectInfoDomain : TopObject
{
	        /// <summary>
	        /// 项目所属公司名称
	        /// </summary>
	        [XmlElement("company")]
	        public string Company { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_date")]
	        public string EndDate { get; set; }
	
	        /// <summary>
	        /// 项目描述
	        /// </summary>
	        [XmlElement("project_description")]
	        public string ProjectDescription { get; set; }
	
	        /// <summary>
	        /// 项目名称
	        /// </summary>
	        [XmlElement("project_name")]
	        public string ProjectName { get; set; }
	
	        /// <summary>
	        /// 项目职责
	        /// </summary>
	        [XmlElement("responsibilities")]
	        public string Responsibilities { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public string StartDate { get; set; }
	
	        /// <summary>
	        /// 项目职位
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// ExperienceInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ExperienceInfoDomain : TopObject
{
	        /// <summary>
	        /// 工作业绩
	        /// </summary>
	        [XmlElement("achievement")]
	        public string Achievement { get; set; }
	
	        /// <summary>
	        /// 公司名称
	        /// </summary>
	        [XmlElement("company")]
	        public string Company { get; set; }
	
	        /// <summary>
	        /// 公司描述
	        /// </summary>
	        [XmlElement("company_description")]
	        public string CompanyDescription { get; set; }
	
	        /// <summary>
	        /// 所在部门
	        /// </summary>
	        [XmlElement("department")]
	        public string Department { get; set; }
	
	        /// <summary>
	        /// 终止时间
	        /// </summary>
	        [XmlElement("end_date")]
	        public string EndDate { get; set; }
	
	        /// <summary>
	        /// 汇报对象
	        /// </summary>
	        [XmlElement("leader")]
	        public string Leader { get; set; }
	
	        /// <summary>
	        /// 工作地点
	        /// </summary>
	        [XmlElement("location")]
	        public string Location { get; set; }
	
	        /// <summary>
	        /// 其它信息
	        /// </summary>
	        [XmlElement("others")]
	        public string Others { get; set; }
	
	        /// <summary>
	        /// 工作时间段
	        /// </summary>
	        [XmlElement("periods_of_time")]
	        public string PeriodsOfTime { get; set; }
	
	        /// <summary>
	        /// 离职原因
	        /// </summary>
	        [XmlElement("reason_of_leaving")]
	        public string ReasonOfLeaving { get; set; }
	
	        /// <summary>
	        /// 薪水
	        /// </summary>
	        [XmlElement("salary")]
	        public string Salary { get; set; }
	
	        /// <summary>
	        /// 公司规模
	        /// </summary>
	        [XmlElement("size")]
	        public string Size { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public string StartDate { get; set; }
	
	        /// <summary>
	        /// 工作描述
	        /// </summary>
	        [XmlElement("summary")]
	        public string Summary { get; set; }
	
	        /// <summary>
	        /// 职务
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 公司性质
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 下属人数
	        /// </summary>
	        [XmlElement("underling_number")]
	        public string UnderlingNumber { get; set; }
	
	        /// <summary>
	        /// 所属行业
	        /// </summary>
	        [XmlElement("vocation")]
	        public string Vocation { get; set; }
	
	        /// <summary>
	        /// 工作类型（实习经历、工作经历）
	        /// </summary>
	        [XmlElement("work_type")]
	        public string WorkType { get; set; }
}

	/// <summary>
/// EducationInfoDomain Data Structure.
/// </summary>
[Serializable]

public class EducationInfoDomain : TopObject
{
	        /// <summary>
	        /// 学位
	        /// </summary>
	        [XmlElement("advanced_degree")]
	        public string AdvancedDegree { get; set; }
	
	        /// <summary>
	        /// 院系
	        /// </summary>
	        [XmlElement("department")]
	        public string Department { get; set; }
	
	        /// <summary>
	        /// 学历
	        /// </summary>
	        [XmlElement("education")]
	        public string Education { get; set; }
	
	        /// <summary>
	        /// 终止时间
	        /// </summary>
	        [XmlElement("end_date")]
	        public string EndDate { get; set; }
	
	        /// <summary>
	        /// 其它内容
	        /// </summary>
	        [XmlElement("others")]
	        public string Others { get; set; }
	
	        /// <summary>
	        /// 学校名称
	        /// </summary>
	        [XmlElement("school")]
	        public string School { get; set; }
	
	        /// <summary>
	        /// 学校特征标签
	        /// </summary>
	        [XmlElement("school_label")]
	        public string SchoolLabel { get; set; }
	
	        /// <summary>
	        /// 院校类别：取值为 0：普通，1：211 院校，2：985 院校，3：既是 211 又是 985 院校，4：外国 5：台湾大学
	        /// </summary>
	        [XmlElement("school_type")]
	        public string SchoolType { get; set; }
	
	        /// <summary>
	        /// 专业
	        /// </summary>
	        [XmlElement("speciality")]
	        public string Speciality { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public string StartDate { get; set; }
	
	        /// <summary>
	        /// 统招或自考
	        /// </summary>
	        [XmlElement("student_type")]
	        public string StudentType { get; set; }
	
	        /// <summary>
	        /// 留学经历
	        /// </summary>
	        [XmlElement("study_abroad_experience")]
	        public string StudyAbroadExperience { get; set; }
	
	        /// <summary>
	        /// 详细介绍
	        /// </summary>
	        [XmlElement("summary")]
	        public string Summary { get; set; }
}

	/// <summary>
/// ResumeDetailInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ResumeDetailInfoDomain : TopObject
{
	        /// <summary>
	        /// 教育经历
	        /// </summary>
	        [XmlArray("education_info_list")]
	        [XmlArrayItem("education_info")]
	        public List<EducationInfoDomain> EducationInfoList { get; set; }
	
	        /// <summary>
	        /// 邮箱
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// 工作经历
	        /// </summary>
	        [XmlArray("experience_info_list")]
	        [XmlArrayItem("experience_info")]
	        public List<ExperienceInfoDomain> ExperienceInfoList { get; set; }
	
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 手机号
	        /// </summary>
	        [XmlElement("phone_num")]
	        public string PhoneNum { get; set; }
	
	        /// <summary>
	        /// 项目经历
	        /// </summary>
	        [XmlArray("project_info_list")]
	        [XmlArrayItem("project_info")]
	        public List<ProjectInfoDomain> ProjectInfoList { get; set; }
}

        #endregion
    }
}
