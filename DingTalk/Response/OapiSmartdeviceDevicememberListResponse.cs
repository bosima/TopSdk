using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceDevicememberListResponse.
    /// </summary>
    public class OapiSmartdeviceDevicememberListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 查询结果
        /// </summary>
        [XmlElement("result")]
        public PagedListDomain Result { get; set; }

	/// <summary>
/// PagedListDomain Data Structure.
/// </summary>
[Serializable]

public class PagedListDomain : TopObject
{
	        /// <summary>
	        /// 当 has_more 为true时，下次查询需要传入的游标
	        /// </summary>
	        [XmlElement("cursor")]
	        public long Cursor { get; set; }
	
	        /// <summary>
	        /// 是否还有数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 当前页所对应的userIds
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("string")]
	        public List<string> Items { get; set; }
}

    }
}
