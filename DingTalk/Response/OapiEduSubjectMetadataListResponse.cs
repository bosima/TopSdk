using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduSubjectMetadataListResponse.
    /// </summary>
    public class OapiEduSubjectMetadataListResponse : DingTalkResponse
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
        /// 数据结果
        /// </summary>
        [XmlElement("result")]
        public PageQueryResponseDomain Result { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// SubjectMetadataDTODomain Data Structure.
/// </summary>
[Serializable]

public class SubjectMetadataDTODomain : TopObject
{
	        /// <summary>
	        /// 区域编码
	        /// </summary>
	        [XmlElement("area_code")]
	        public string AreaCode { get; set; }
	
	        /// <summary>
	        /// 学科元数据id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 层级
	        /// </summary>
	        [XmlElement("level")]
	        public long Level { get; set; }
	
	        /// <summary>
	        /// 父id
	        /// </summary>
	        [XmlElement("parent_id")]
	        public long ParentId { get; set; }
	
	        /// <summary>
	        /// 学段编码
	        /// </summary>
	        [XmlElement("period_code")]
	        public string PeriodCode { get; set; }
	
	        /// <summary>
	        /// 学科编码
	        /// </summary>
	        [XmlElement("subject_code")]
	        public string SubjectCode { get; set; }
	
	        /// <summary>
	        /// 学科名称
	        /// </summary>
	        [XmlElement("subject_name")]
	        public string SubjectName { get; set; }
}

	/// <summary>
/// PageQueryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class PageQueryResponseDomain : TopObject
{
	        /// <summary>
	        /// 是否还有更多数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 学科元数据列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("subject_metadata_d_t_o")]
	        public List<SubjectMetadataDTODomain> List { get; set; }
	
	        /// <summary>
	        /// 下一页游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
	
	        /// <summary>
	        /// 总数据条数
	        /// </summary>
	        [XmlElement("total_count")]
	        public long TotalCount { get; set; }
}

    }
}
