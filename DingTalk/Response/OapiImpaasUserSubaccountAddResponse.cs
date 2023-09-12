using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasUserSubaccountAddResponse.
    /// </summary>
    public class OapiImpaasUserSubaccountAddResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码  -1 系统异常 40035 参数错误
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 添加账号出参
        /// </summary>
        [XmlElement("result")]
        public AddSubAccountRespDomain Result { get; set; }

        /// <summary>
        /// 接口是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// AddSubAccountRespDomain Data Structure.
/// </summary>
[Serializable]

public class AddSubAccountRespDomain : TopObject
{
	        /// <summary>
	        /// im的唯一id
	        /// </summary>
	        [XmlElement("im_openid")]
	        public string ImOpenid { get; set; }
}

    }
}
