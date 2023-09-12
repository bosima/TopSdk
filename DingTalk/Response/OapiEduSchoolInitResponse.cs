using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduSchoolInitResponse.
    /// </summary>
    public class OapiEduSchoolInitResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public OpenEduSchoolInitResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenEduSchoolInitResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduSchoolInitResponseDomain : TopObject
{
	        /// <summary>
	        /// 校区列表
	        /// </summary>
	        [XmlArray("campus_list")]
	        [XmlArrayItem("number")]
	        public List<long> CampusList { get; set; }
	
	        /// <summary>
	        /// 生效
	        /// </summary>
	        [XmlElement("effected")]
	        public string Effected { get; set; }
}

    }
}
