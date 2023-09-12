using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpUserPersonainfoGetResponse.
    /// </summary>
    public class CorpUserPersonainfoGetResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// OpenPersonaInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPersonaInfoDomain : TopObject
{
	        /// <summary>
	        /// 生日
	        /// </summary>
	        [XmlElement("dob")]
	        public string Dob { get; set; }
	
	        /// <summary>
	        /// 性别
	        /// </summary>
	        [XmlElement("gender")]
	        public string Gender { get; set; }
	
	        /// <summary>
	        /// 行业
	        /// </summary>
	        [XmlElement("industry")]
	        public string Industry { get; set; }
	
	        /// <summary>
	        /// 头衔
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// umids
	        /// </summary>
	        [XmlArray("umids")]
	        [XmlArrayItem("string")]
	        public List<string> Umids { get; set; }
	
	        /// <summary>
	        /// 工作区域
	        /// </summary>
	        [XmlElement("work_station")]
	        public string WorkStation { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 返回结果
	        /// </summary>
	        [XmlElement("result")]
	        public OpenPersonaInfoDomain Result { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
