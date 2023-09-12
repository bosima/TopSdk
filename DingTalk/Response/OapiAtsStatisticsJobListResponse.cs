using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAtsStatisticsJobListResponse.
    /// </summary>
    public class OapiAtsStatisticsJobListResponse : DingTalkResponse
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
/// TopJobStatisticsVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopJobStatisticsVoDomain : TopObject
{
	        /// <summary>
	        /// 招聘业务标识
	        /// </summary>
	        [XmlElement("biz_code")]
	        public string BizCode { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 职位创建人id
	        /// </summary>
	        [XmlElement("creator_userid")]
	        public string CreatorUserid { get; set; }
	
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
	        /// 招聘人数
	        /// </summary>
	        [XmlElement("head_count")]
	        public long HeadCount { get; set; }
	
	        /// <summary>
	        /// 职位id
	        /// </summary>
	        [XmlElement("job_id")]
	        public string JobId { get; set; }
	
	        /// <summary>
	        /// 职位归属部门id
	        /// </summary>
	        [XmlElement("main_dept_id")]
	        public long MainDeptId { get; set; }
	
	        /// <summary>
	        /// 职位名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 职位负责人id
	        /// </summary>
	        [XmlElement("owner_userid")]
	        public string OwnerUserid { get; set; }
	
	        /// <summary>
	        /// 0：新创建  1：已发布  2：废弃  3：招满
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
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
	        /// 职位信息列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("top_job_statistics_vo")]
	        public List<TopJobStatisticsVoDomain> List { get; set; }
	
	        /// <summary>
	        /// 游标，下次分页请求使用
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
}

    }
}
