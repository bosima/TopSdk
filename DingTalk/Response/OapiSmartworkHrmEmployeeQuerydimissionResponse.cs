using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmEmployeeQuerydimissionResponse.
    /// </summary>
    public class OapiSmartworkHrmEmployeeQuerydimissionResponse : DingTalkResponse
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
        public PaginatorDomain Result { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// PaginatorDomain Data Structure.
/// </summary>
[Serializable]

public class PaginatorDomain : TopObject
{
	        /// <summary>
	        /// 数据结果列表
	        /// </summary>
	        [XmlArray("data_list")]
	        [XmlArrayItem("string")]
	        public List<string> DataList { get; set; }
	
	        /// <summary>
	        /// 下一次分页调用的offset值，当返回结果里没有nextCursor时，表示分页结束
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
