using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduSubjectGetResponse.
    /// </summary>
    public class OapiEduSubjectGetResponse : DingTalkResponse
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
        /// 学科实例对象
        /// </summary>
        [XmlElement("result")]
        public SubjectInstanceDTODomain Result { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// SubjectInstanceDTODomain Data Structure.
/// </summary>
[Serializable]

public class SubjectInstanceDTODomain : TopObject
{
	        /// <summary>
	        /// 学段编码
	        /// </summary>
	        [XmlElement("period_code")]
	        public string PeriodCode { get; set; }
	
	        /// <summary>
	        /// 学科编码
	        /// </summary>
	        [XmlElement("subject_code")]
	        public string SubjectCode { get; set; }
	
	        /// <summary>
	        /// 学科名称
	        /// </summary>
	        [XmlElement("subject_name")]
	        public string SubjectName { get; set; }
}

    }
}
