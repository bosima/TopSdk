using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCustomerserviceMemberGetResponse.
    /// </summary>
    public class OapiCustomerserviceMemberGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 会员卡片信息
        /// </summary>
        [XmlElement("result")]
        public MemberCardDtoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// MemberCardDtoDomain Data Structure.
/// </summary>
[Serializable]

public class MemberCardDtoDomain : TopObject
{
	        /// <summary>
	        /// 业务自定义参数
	        /// </summary>
	        [XmlElement("customize_fields")]
	        public string CustomizeFields { get; set; }
	
	        /// <summary>
	        /// 邮箱
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// 昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
}

    }
}
