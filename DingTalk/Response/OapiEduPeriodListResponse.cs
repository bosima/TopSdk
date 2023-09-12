using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduPeriodListResponse.
    /// </summary>
    public class OapiEduPeriodListResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("period_response")]
        public List<PeriodResponseDomain> Result { get; set; }

        /// <summary>
        /// 成功状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// PeriodResponseDomain Data Structure.
/// </summary>
[Serializable]

public class PeriodResponseDomain : TopObject
{
	        /// <summary>
	        /// 学段名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 学段名称类型，text表示文本型，如中学为七年级，八年级，九年级，number表示数字型，如初中一年级1班，二年级1班等
	        /// </summary>
	        [XmlElement("name_mode")]
	        public string NameMode { get; set; }
	
	        /// <summary>
	        /// 学段别名
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 学段ID
	        /// </summary>
	        [XmlElement("period_id")]
	        public long PeriodId { get; set; }
	
	        /// <summary>
	        /// 学段类型：（幼儿园：kindergarten、小学：primary_school，初中：middle_school，高中：high_school）
	        /// </summary>
	        [XmlElement("period_type")]
	        public string PeriodType { get; set; }
}

    }
}
