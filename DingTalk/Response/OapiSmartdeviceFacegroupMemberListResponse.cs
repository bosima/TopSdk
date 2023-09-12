using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceFacegroupMemberListResponse.
    /// </summary>
    public class OapiSmartdeviceFacegroupMemberListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代号
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 符合条件的当前页数据
        /// </summary>
        [XmlElement("result")]
        public PagedListDomain Result { get; set; }

        /// <summary>
        /// API调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// PagedListDomain Data Structure.
/// </summary>
[Serializable]

public class PagedListDomain : TopObject
{
	        /// <summary>
	        /// 游标，下一次请求需要传入的下一次请求时需传入的游标值
	        /// </summary>
	        [XmlElement("cursor")]
	        public long Cursor { get; set; }
	
	        /// <summary>
	        /// 是否还有下一页数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 已在识别组的用户ids
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("string")]
	        public List<string> Items { get; set; }
}

    }
}
