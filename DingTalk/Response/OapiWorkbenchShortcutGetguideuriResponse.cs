using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkbenchShortcutGetguideuriResponse.
    /// </summary>
    public class OapiWorkbenchShortcutGetguideuriResponse : DingTalkResponse
    {
        /// <summary>
        /// 服务返回码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 服务返回信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 快捷方式添加到工作台引导页地址
        /// </summary>
        [XmlElement("guide_uri")]
        public string GuideUri { get; set; }

    }
}
