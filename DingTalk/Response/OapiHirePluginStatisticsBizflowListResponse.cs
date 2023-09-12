using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiHirePluginStatisticsBizflowListResponse.
    /// </summary>
    public class OapiHirePluginStatisticsBizflowListResponse : DingTalkResponse
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
        public DdAtsPageResultDomain Result { get; set; }

	/// <summary>
/// TopBizFlowStatisticsVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopBizFlowStatisticsVoDomain : TopObject
{
	        /// <summary>
	        /// 候选人id
	        /// </summary>
	        [XmlElement("candidate_id")]
	        public string CandidateId { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 创建人userid
	        /// </summary>
	        [XmlElement("creator_userid")]
	        public string CreatorUserid { get; set; }
	
	        /// <summary>
	        /// 应聘流程id
	        /// </summary>
	        [XmlElement("flow_id")]
	        public string FlowId { get; set; }
	
	        /// <summary>
	        /// 应聘状态  11：待初筛  12：初筛通过 13：初筛不通过  21： 应聘流程中  22：应聘通过  23：应聘不通过(不录用)  31： offer流程中  32： offer通过(录用)  33：offer失败  34： offer取消(取消录用)  41：待入职  42：已入职
	        /// </summary>
	        [XmlElement("flow_status")]
	        public long FlowStatus { get; set; }
	
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
	        /// 职位id
	        /// </summary>
	        [XmlElement("job_id")]
	        public string JobId { get; set; }
	
	        /// <summary>
	        /// 负责人userid
	        /// </summary>
	        [XmlElement("owner_userid")]
	        public string OwnerUserid { get; set; }
	
	        /// <summary>
	        /// 应聘id
	        /// </summary>
	        [XmlElement("recruit_id")]
	        public string RecruitId { get; set; }
	
	        /// <summary>
	        /// 简历id
	        /// </summary>
	        [XmlElement("resume_id")]
	        public string ResumeId { get; set; }
}

	/// <summary>
/// DdAtsPageResultDomain Data Structure.
/// </summary>
[Serializable]

public class DdAtsPageResultDomain : TopObject
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
	        [XmlArrayItem("top_biz_flow_statistics_vo")]
	        public List<TopBizFlowStatisticsVoDomain> List { get; set; }
	
	        /// <summary>
	        /// 游标，下次分页请求使用
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
}

    }
}
