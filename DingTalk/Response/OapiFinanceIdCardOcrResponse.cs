using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiFinanceIdCardOcrResponse.
    /// </summary>
    public class OapiFinanceIdCardOcrResponse : DingTalkResponse
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
        /// 身份证信息
        /// </summary>
        [XmlElement("result")]
        public OpenIdCardInfoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenIdCardInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenIdCardInfoDomain : TopObject
{
	        /// <summary>
	        /// 地址
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 签发机构名称
	        /// </summary>
	        [XmlElement("auth_inst_name")]
	        public string AuthInstName { get; set; }
	
	        /// <summary>
	        /// 生日
	        /// </summary>
	        [XmlElement("birthday")]
	        public string Birthday { get; set; }
	
	        /// <summary>
	        /// 有效期间
	        /// </summary>
	        [XmlElement("effect_period")]
	        public string EffectPeriod { get; set; }
	
	        /// <summary>
	        /// 性别
	        /// </summary>
	        [XmlElement("gender")]
	        public string Gender { get; set; }
	
	        /// <summary>
	        /// 身份证号
	        /// </summary>
	        [XmlElement("id_card_no")]
	        public string IdCardNo { get; set; }
	
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 国家
	        /// </summary>
	        [XmlElement("nation")]
	        public string Nation { get; set; }
	
	        /// <summary>
	        /// 是否有效
	        /// </summary>
	        [XmlElement("valid")]
	        public bool Valid { get; set; }
}

    }
}
