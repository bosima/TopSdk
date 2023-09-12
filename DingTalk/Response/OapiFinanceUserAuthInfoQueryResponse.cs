using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiFinanceUserAuthInfoQueryResponse.
    /// </summary>
    public class OapiFinanceUserAuthInfoQueryResponse : DingTalkResponse
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
        /// 认证信息
        /// </summary>
        [XmlElement("result")]
        public OpenCustomerAuthInfoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenCustomerAuthInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCustomerAuthInfoDomain : TopObject
{
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("cert_name")]
	        public string CertName { get; set; }
	
	        /// <summary>
	        /// 身份证号
	        /// </summary>
	        [XmlElement("id_card_no")]
	        public string IdCardNo { get; set; }
	
	        /// <summary>
	        /// 钉钉指数分
	        /// </summary>
	        [XmlElement("scores")]
	        public string Scores { get; set; }
	
	        /// <summary>
	        /// 手机号
	        /// </summary>
	        [XmlElement("user_mobile")]
	        public string UserMobile { get; set; }
}

    }
}
