using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceShiftListResponse.
    /// </summary>
    public class OapiAttendanceShiftListResponse : DingTalkResponse
    {
        /// <summary>
        /// 请求错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 请求错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 业务值结果
        /// </summary>
        [XmlElement("result")]
        public PageResultDomain Result { get; set; }

        /// <summary>
        /// 请求成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TopMinimalismShiftVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopMinimalismShiftVoDomain : TopObject
{
	        /// <summary>
	        /// 班次id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 班次名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 下一次访问游标
	        /// </summary>
	        [XmlElement("cursor")]
	        public long Cursor { get; set; }
	
	        /// <summary>
	        /// 是否还有
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 业务具体值
	        /// </summary>
	        [XmlArray("result")]
	        [XmlArrayItem("top_minimalism_shift_vo")]
	        public List<TopMinimalismShiftVoDomain> Result { get; set; }
}

    }
}
