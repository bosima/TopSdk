using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmEmployeeOnjoblistQueryResponse.
    /// </summary>
    public class OapiSmartworkHrmEmployeeOnjoblistQueryResponse : DingTalkResponse
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
        public PageResultDomain Result { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 数据结果列表
	        /// </summary>
	        [XmlArray("data_list")]
	        [XmlArrayItem("string")]
	        public List<string> DataList { get; set; }
	
	        /// <summary>
	        /// 表示是否还有更多的数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 表示下一次分页的游标，如果next_corsor为null或者has_more为false，表示没有更多的分页数据
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
