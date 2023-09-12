using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosExecClothesUnperformedGetResponse.
    /// </summary>
    public class OapiRhinoMosExecClothesUnperformedGetResponse : DingTalkResponse
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
        /// 衣服ID列表
        /// </summary>
        [XmlElement("model")]
        public PageResultDomain Model { get; set; }

        /// <summary>
        /// 是否成功
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
	        /// 起始位置
	        /// </summary>
	        [XmlElement("current_start")]
	        public long CurrentStart { get; set; }
	
	        /// <summary>
	        /// 页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 结果
	        /// </summary>
	        [XmlArray("result")]
	        [XmlArrayItem("number")]
	        public List<long> Result { get; set; }
	
	        /// <summary>
	        /// 总数
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
}

    }
}
