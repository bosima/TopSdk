using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduClassCreateResponse.
    /// </summary>
    public class OapiEduClassCreateResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public OpenClassCreateResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenClassCreateResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenClassCreateResponseDomain : TopObject
{
	        /// <summary>
	        /// 班级id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
}

    }
}
