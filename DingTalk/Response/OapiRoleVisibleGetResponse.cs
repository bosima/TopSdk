using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRoleVisibleGetResponse.
    /// </summary>
    public class OapiRoleVisibleGetResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public PageVoDomain Result { get; set; }

	/// <summary>
/// PageVoDomain Data Structure.
/// </summary>
[Serializable]

public class PageVoDomain : TopObject
{
	        /// <summary>
	        /// 是否还有数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// roleIdList
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("number")]
	        public List<long> List { get; set; }
	
	        /// <summary>
	        /// 下次请求的游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
}

    }
}
