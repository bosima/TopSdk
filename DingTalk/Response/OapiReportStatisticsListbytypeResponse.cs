using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiReportStatisticsListbytypeResponse.
    /// </summary>
    public class OapiReportStatisticsListbytypeResponse : DingTalkResponse
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
        /// 统计结果
        /// </summary>
        [XmlElement("result")]
        public ReportPageVoDomain Result { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ReportPageVoDomain Data Structure.
/// </summary>
[Serializable]

public class ReportPageVoDomain : TopObject
{
	        /// <summary>
	        /// 是否还有下一页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一次分页调用的offset值，当返回结果里没有next_cursor时，表示分页结束
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
	
	        /// <summary>
	        /// userid列表
	        /// </summary>
	        [XmlArray("userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> UseridList { get; set; }
}

    }
}
