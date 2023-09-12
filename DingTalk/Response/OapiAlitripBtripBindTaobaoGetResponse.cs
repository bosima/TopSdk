using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripBindTaobaoGetResponse.
    /// </summary>
    public class OapiAlitripBtripBindTaobaoGetResponse : DingTalkResponse
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
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public UserTaoBaoInfoDomain Result { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// UserTaoBaoInfoDomain Data Structure.
/// </summary>
[Serializable]

public class UserTaoBaoInfoDomain : TopObject
{
	        /// <summary>
	        /// 关联的支付宝帐号
	        /// </summary>
	        [XmlElement("alipay_info")]
	        public string AlipayInfo { get; set; }
	
	        /// <summary>
	        /// 淘宝帐号
	        /// </summary>
	        [XmlElement("taobao_info")]
	        public string TaobaoInfo { get; set; }
}

    }
}
