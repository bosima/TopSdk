using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiServiceGetPermanentCodeResponse.
    /// </summary>
    public class OapiServiceGetPermanentCodeResponse : DingTalkResponse
    {
        /// <summary>
        /// 授权方企业信息
        /// </summary>
        [XmlElement("auth_corp_info")]
        public AuthCorpInfoDomain AuthCorpInfo { get; set; }

        /// <summary>
        /// 企业服务窗永久授权码，如果该套件下存在服务窗应用，会返回
        /// </summary>
        [XmlElement("ch_permanent_code")]
        public string ChPermanentCode { get; set; }

        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 永久授权码
        /// </summary>
        [XmlElement("permanent_code")]
        public string PermanentCode { get; set; }

	/// <summary>
/// AuthCorpInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AuthCorpInfoDomain : TopObject
{
	        /// <summary>
	        /// corp_name
	        /// </summary>
	        [XmlElement("corp_name")]
	        public string CorpName { get; set; }
	
	        /// <summary>
	        /// 授权方企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
}

    }
}
