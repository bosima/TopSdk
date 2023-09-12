using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiFaceauthGetResponse.
    /// </summary>
    public class OapiFaceauthGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码 0表示验证成功
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误码描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 实名认证的结果
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 身份证号码,只有在用户输入的情况下才返回
	        /// </summary>
	        [XmlElement("idcard_no")]
	        public string IdcardNo { get; set; }
	
	        /// <summary>
	        /// 用户输入的姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

    }
}
