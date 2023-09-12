using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkrecordGetbyuseridResponse.
    /// </summary>
    public class OapiWorkrecordGetbyuseridResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("records")]
        public PageResultDomain Records { get; set; }

	/// <summary>
/// FormItemVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormItemVoDomain : TopObject
{
	        /// <summary>
	        /// content
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// title
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// WorkRecordVoDomain Data Structure.
/// </summary>
[Serializable]

public class WorkRecordVoDomain : TopObject
{
	        /// <summary>
	        /// createAt
	        /// </summary>
	        [XmlElement("create_time")]
	        public long CreateTime { get; set; }
	
	        /// <summary>
	        /// forms
	        /// </summary>
	        [XmlArray("forms")]
	        [XmlArrayItem("form_item_vo")]
	        public List<FormItemVoDomain> Forms { get; set; }
	
	        /// <summary>
	        /// recordId
	        /// </summary>
	        [XmlElement("record_id")]
	        public string RecordId { get; set; }
	
	        /// <summary>
	        /// title
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// url
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// hasMore
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("work_record_vo")]
	        public List<WorkRecordVoDomain> List { get; set; }
}

    }
}
