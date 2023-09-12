using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAuthorizationRbacRoleMemberRemoveResponse.
    /// </summary>
    public class OapiAuthorizationRbacRoleMemberRemoveResponse : DingTalkResponse
    {
        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
