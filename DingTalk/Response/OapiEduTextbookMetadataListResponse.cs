using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduTextbookMetadataListResponse.
    /// </summary>
    public class OapiEduTextbookMetadataListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误编码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误msg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 数据对象
        /// </summary>
        [XmlElement("result")]
        public PageQueryResponseDomain Result { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TextbookMetadataDTODomain Data Structure.
/// </summary>
[Serializable]

public class TextbookMetadataDTODomain : TopObject
{
	        /// <summary>
	        /// 教材id
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
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 系统自动生成
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 学科编码
	        /// </summary>
	        [XmlElement("subject_code")]
	        public string SubjectCode { get; set; }
	
	        /// <summary>
	        /// 教材编码
	        /// </summary>
	        [XmlElement("textbook_code")]
	        public string TextbookCode { get; set; }
	
	        /// <summary>
	        /// 教材版本名称
	        /// </summary>
	        [XmlElement("textbook_name")]
	        public string TextbookName { get; set; }
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
	        /// 教育列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("textbook_metadata_d_t_o")]
	        public List<TextbookMetadataDTODomain> List { get; set; }
	
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
