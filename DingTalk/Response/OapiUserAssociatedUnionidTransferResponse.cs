using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserAssociatedUnionidTransferResponse.
    /// </summary>
    public class OapiUserAssociatedUnionidTransferResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码，0为成功
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 用户userid结果
        /// </summary>
        [XmlElement("result")]
        public UseridVoDomain Result { get; set; }

	/// <summary>
/// UseridVoDomain Data Structure.
/// </summary>
[Serializable]

public class UseridVoDomain : TopObject
{
	        /// <summary>
	        /// 用户通讯录类型，0为内部，1为外部
	        /// </summary>
	        [XmlElement("contact_type")]
	        public long ContactType { get; set; }
	
	        /// <summary>
	        /// 用户在企业中userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
