using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduFaceGetResponse.
    /// </summary>
    public class OapiEduFaceGetResponse : DingTalkResponse
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
        [XmlElement("result")]
        public TopQueryFaceIdResponseDomain Result { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TopQueryFaceIdResponseDomain Data Structure.
/// </summary>
[Serializable]

public class TopQueryFaceIdResponseDomain : TopObject
{
	        /// <summary>
	        /// 是否录入过人脸
	        /// </summary>
	        [XmlElement("has_record_face")]
	        public bool HasRecordFace { get; set; }
}

    }
}
