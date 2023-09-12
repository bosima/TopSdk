using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceProjectNoticeSendResponse.
    /// </summary>
    public class OapiWorkspaceProjectNoticeSendResponse : DingTalkResponse
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
        /// 发送结果
        /// </summary>
        [XmlElement("result")]
        public OpenSendNoticeResponseDtoDomain Result { get; set; }

        /// <summary>
        /// 请求成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenSendNoticeResponseDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenSendNoticeResponseDtoDomain : TopObject
{
	        /// <summary>
	        /// 被发送额度控制的userids
	        /// </summary>
	        [XmlArray("limit_userids")]
	        [XmlArrayItem("string")]
	        public List<string> LimitUserids { get; set; }
}

    }
}
