using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessinstanceListidsResponse.
    /// </summary>
    public class OapiProcessinstanceListidsResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public PageResultDomain Result { get; set; }

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// id列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("string")]
	        public List<string> List { get; set; }
	
	        /// <summary>
	        /// 表示下次查询的游标，当返回结果没有该字段时表示没有更多数据了
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
