using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAtsStatisticsResumeListResponse.
    /// </summary>
    public class OapiAtsStatisticsResumeListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 分页结果
        /// </summary>
        [XmlElement("result")]
        public AtsPageResultDomain Result { get; set; }

	/// <summary>
/// TopResumeStatisticsVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopResumeStatisticsVoDomain : TopObject
{
	        /// <summary>
	        /// 招聘业务标识
	        /// </summary>
	        [XmlElement("biz_code")]
	        public string BizCode { get; set; }
	
	        /// <summary>
	        /// 候选人id
	        /// </summary>
	        [XmlElement("candidate_id")]
	        public string CandidateId { get; set; }
	
	        /// <summary>
	        /// lagou,51job,58tongcheng,zhilian,liepin,boss,other
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 创建时间，unix时间戳，单位毫秒
	        /// </summary>
	        [XmlElement("gmt_create_mils")]
	        public long GmtCreateMils { get; set; }
	
	        /// <summary>
	        /// 更新时间，unix时间戳，单位毫秒
	        /// </summary>
	        [XmlElement("gmt_modified_mils")]
	        public long GmtModifiedMils { get; set; }
	
	        /// <summary>
	        /// 简历id
	        /// </summary>
	        [XmlElement("resume_id")]
	        public string ResumeId { get; set; }
}

	/// <summary>
/// AtsPageResultDomain Data Structure.
/// </summary>
[Serializable]

public class AtsPageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否还有数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 简历信息列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("top_resume_statistics_vo")]
	        public List<TopResumeStatisticsVoDomain> List { get; set; }
	
	        /// <summary>
	        /// 游标，下次分页请求使用
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
}

    }
}
