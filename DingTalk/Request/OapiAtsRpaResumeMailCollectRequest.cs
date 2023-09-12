using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.rpa.resume.mail.collect
    /// </summary>
    public class OapiAtsRpaResumeMailCollectRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsRpaResumeMailCollectResponse>
    {
        /// <summary>
        /// 业务唯一标识，接入前请提前沟通
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 简历文件参数
        /// </summary>
        public string Param { get; set; }

        public CollResumeMailParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.rpa.resume.mail.collect";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("param", this.Param);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("param", this.Param);
        }

	/// <summary>
/// MailContentDomain Data Structure.
/// </summary>
[Serializable]

public class MailContentDomain : TopObject
{
	        /// <summary>
	        /// 邮件正文，可选
	        /// </summary>
	        [XmlElement("body_html")]
	        public string BodyHtml { get; set; }
	
	        /// <summary>
	        /// 发件人邮件地址，可选
	        /// </summary>
	        [XmlElement("from_mail_address")]
	        public string FromMailAddress { get; set; }
	
	        /// <summary>
	        /// 发件人姓名
	        /// </summary>
	        [XmlElement("from_mail_alias")]
	        public string FromMailAlias { get; set; }
	
	        /// <summary>
	        /// 邮件地址，可选
	        /// </summary>
	        [XmlElement("mail_address")]
	        public string MailAddress { get; set; }
	
	        /// <summary>
	        /// 邮件id
	        /// </summary>
	        [XmlElement("mail_id")]
	        public string MailId { get; set; }
	
	        /// <summary>
	        /// 收件时间，时间戳毫秒
	        /// </summary>
	        [XmlElement("received_time")]
	        public Nullable<long> ReceivedTime { get; set; }
	
	        /// <summary>
	        /// 邮件标题，可选
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// ResumeFileStoreVoDomain Data Structure.
/// </summary>
[Serializable]

public class ResumeFileStoreVoDomain : TopObject
{
	        /// <summary>
	        /// 下载地址
	        /// </summary>
	        [XmlElement("download_url")]
	        public string DownloadUrl { get; set; }
	
	        /// <summary>
	        /// 文件名，需要带后缀
	        /// </summary>
	        [XmlElement("file_name")]
	        public string FileName { get; set; }
	
	        /// <summary>
	        /// 文件类型
	        /// </summary>
	        [XmlElement("file_type")]
	        public string FileType { get; set; }
}

	/// <summary>
/// EducationInfoDomain Data Structure.
/// </summary>
[Serializable]

public class EducationInfoDomain : TopObject
{
	        /// <summary>
	        /// 学历
	        /// </summary>
	        [XmlElement("education")]
	        public string Education { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_date")]
	        public string EndDate { get; set; }
	
	        /// <summary>
	        /// 学校名称
	        /// </summary>
	        [XmlElement("school")]
	        public string School { get; set; }
	
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
	        /// 详细介绍
	        /// </summary>
	        [XmlElement("summary")]
	        public string Summary { get; set; }
}

	/// <summary>
/// ExperienceInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ExperienceInfoDomain : TopObject
{
	        /// <summary>
	        /// 公司名称
	        /// </summary>
	        [XmlElement("company")]
	        public string Company { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_date")]
	        public string EndDate { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public string StartDate { get; set; }
	
	        /// <summary>
	        /// 工作内容
	        /// </summary>
	        [XmlElement("summary")]
	        public string Summary { get; set; }
	
	        /// <summary>
	        /// 职位名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// TrainingInfoDomain Data Structure.
/// </summary>
[Serializable]

public class TrainingInfoDomain : TopObject
{
	        /// <summary>
	        /// 所获证书
	        /// </summary>
	        [XmlElement("certificate")]
	        public string Certificate { get; set; }
	
	        /// <summary>
	        /// 培训详情
	        /// </summary>
	        [XmlElement("description_in_details")]
	        public string DescriptionInDetails { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_date")]
	        public string EndDate { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public string StartDate { get; set; }
	
	        /// <summary>
	        /// 培训机构名称
	        /// </summary>
	        [XmlElement("training_institution")]
	        public string TrainingInstitution { get; set; }
}

	/// <summary>
/// ProjectInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ProjectInfoDomain : TopObject
{
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
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public string StartDate { get; set; }
}

	/// <summary>
/// ResumeDetailInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ResumeDetailInfoDomain : TopObject
{
	        /// <summary>
	        /// 学位
	        /// </summary>
	        [XmlElement("advanced_degree")]
	        public string AdvancedDegree { get; set; }
	
	        /// <summary>
	        /// 期望薪资
	        /// </summary>
	        [XmlElement("aim_salary")]
	        public string AimSalary { get; set; }
	
	        /// <summary>
	        /// 开始工作时间
	        /// </summary>
	        [XmlElement("begin_work_time")]
	        public string BeginWorkTime { get; set; }
	
	        /// <summary>
	        /// 出生日期
	        /// </summary>
	        [XmlElement("birth")]
	        public string Birth { get; set; }
	
	        /// <summary>
	        /// 小学，初中，高中，中专，大专，本科，硕士，博士，其他
	        /// </summary>
	        [XmlElement("education")]
	        public string Education { get; set; }
	
	        /// <summary>
	        /// 教育经历
	        /// </summary>
	        [XmlArray("education_info_list")]
	        [XmlArrayItem("education_info")]
	        public List<EducationInfoDomain> EducationInfoList { get; set; }
	
	        /// <summary>
	        /// 邮箱地址
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
	        /// 期望工作地
	        /// </summary>
	        [XmlElement("forward_location")]
	        public string ForwardLocation { get; set; }
	
	        /// <summary>
	        /// 英语等级
	        /// </summary>
	        [XmlElement("grade_of_english")]
	        public string GradeOfEnglish { get; set; }
	
	        /// <summary>
	        /// 毕业时间
	        /// </summary>
	        [XmlElement("graduate_time")]
	        public string GraduateTime { get; set; }
	
	        /// <summary>
	        /// 求职状态
	        /// </summary>
	        [XmlElement("job_status")]
	        public string JobStatus { get; set; }
	
	        /// <summary>
	        /// 已婚，未婚，离婚
	        /// </summary>
	        [XmlElement("married")]
	        public string Married { get; set; }
	
	        /// <summary>
	        /// 姓名，必传
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 国籍
	        /// </summary>
	        [XmlElement("nationality")]
	        public string Nationality { get; set; }
	
	        /// <summary>
	        /// 籍贯
	        /// </summary>
	        [XmlElement("native_place")]
	        public string NativePlace { get; set; }
	
	        /// <summary>
	        /// 先居住地
	        /// </summary>
	        [XmlElement("now_location")]
	        public string NowLocation { get; set; }
	
	        /// <summary>
	        /// 电话，必传
	        /// </summary>
	        [XmlElement("phone_num")]
	        public string PhoneNum { get; set; }
	
	        /// <summary>
	        /// 政治面貌
	        /// </summary>
	        [XmlElement("political")]
	        public string Political { get; set; }
	
	        /// <summary>
	        /// 项目经历
	        /// </summary>
	        [XmlArray("project_info_list")]
	        [XmlArrayItem("project_info")]
	        public List<ProjectInfoDomain> ProjectInfoList { get; set; }
	
	        /// <summary>
	        /// 当前薪资
	        /// </summary>
	        [XmlElement("salary")]
	        public string Salary { get; set; }
	
	        /// <summary>
	        /// 毕业院校
	        /// </summary>
	        [XmlElement("school")]
	        public string School { get; set; }
	
	        /// <summary>
	        /// 学校类别
	        /// </summary>
	        [XmlElement("school_type")]
	        public string SchoolType { get; set; }
	
	        /// <summary>
	        /// 男性，女性
	        /// </summary>
	        [XmlElement("sex")]
	        public string Sex { get; set; }
	
	        /// <summary>
	        /// 专业
	        /// </summary>
	        [XmlElement("speciality")]
	        public string Speciality { get; set; }
	
	        /// <summary>
	        /// 学历情况
	        /// </summary>
	        [XmlElement("student_type")]
	        public string StudentType { get; set; }
	
	        /// <summary>
	        /// 职位名称
	        /// </summary>
	        [XmlElement("title_standard")]
	        public string TitleStandard { get; set; }
	
	        /// <summary>
	        /// 培训经历
	        /// </summary>
	        [XmlArray("training_info_list")]
	        [XmlArrayItem("training_info")]
	        public List<TrainingInfoDomain> TrainingInfoList { get; set; }
	
	        /// <summary>
	        /// 行业名称
	        /// </summary>
	        [XmlElement("vocation_standard")]
	        public string VocationStandard { get; set; }
}

	/// <summary>
/// CollResumeMailParamDomain Data Structure.
/// </summary>
[Serializable]

public class CollResumeMailParamDomain : TopObject
{
	        /// <summary>
	        /// 渠道来源，接入前请提前沟通
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 匹配到的职位列表
	        /// </summary>
	        [XmlArray("matched_jobs")]
	        [XmlArrayItem("string")]
	        public List<string> MatchedJobs { get; set; }
	
	        /// <summary>
	        /// userId123
	        /// </summary>
	        [XmlElement("opt_user_id")]
	        public string OptUserId { get; set; }
	
	        /// <summary>
	        /// 原始邮件信息，可选
	        /// </summary>
	        [XmlElement("origin_mail")]
	        public MailContentDomain OriginMail { get; set; }
	
	        /// <summary>
	        /// 结构化的简历详情
	        /// </summary>
	        [XmlElement("resume_detail_info")]
	        public ResumeDetailInfoDomain ResumeDetailInfo { get; set; }
	
	        /// <summary>
	        /// 简历文件信息
	        /// </summary>
	        [XmlElement("resume_file")]
	        public ResumeFileStoreVoDomain ResumeFile { get; set; }
}

        #endregion
    }
}
