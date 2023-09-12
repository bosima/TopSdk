using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduAlumniGetResponse.
    /// </summary>
    public class OapiEduAlumniGetResponse : DingTalkResponse
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
        public QueryAlumniResponseDomain Result { get; set; }

        /// <summary>
        /// 成功or失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// QueryAlumniResponseDomain Data Structure.
/// </summary>
[Serializable]

public class QueryAlumniResponseDomain : TopObject
{
	        /// <summary>
	        /// 校友会id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
}

    }
}
