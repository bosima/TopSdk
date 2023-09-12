using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAtsResumeCheckexistenceResponse.
    /// </summary>
    public class OapiAtsResumeCheckexistenceResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public ResumeCheckResultVoDomain Result { get; set; }

	/// <summary>
/// ResumeCheckResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class ResumeCheckResultVoDomain : TopObject
{
	        /// <summary>
	        /// 是否存在
	        /// </summary>
	        [XmlElement("existed")]
	        public bool Existed { get; set; }
	
	        /// <summary>
	        /// 简历标识列表
	        /// </summary>
	        [XmlArray("resume_id_list")]
	        [XmlArrayItem("string")]
	        public List<string> ResumeIdList { get; set; }
}

    }
}
