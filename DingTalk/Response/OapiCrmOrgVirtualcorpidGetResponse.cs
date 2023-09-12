using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmOrgVirtualcorpidGetResponse.
    /// </summary>
    public class OapiCrmOrgVirtualcorpidGetResponse : DingTalkResponse
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
        /// CRM客户组织ID
        /// </summary>
        [XmlElement("virtual_corpid")]
        public string VirtualCorpid { get; set; }

    }
}
