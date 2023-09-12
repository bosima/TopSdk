using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessTemplateUpgradeResponse.
    /// </summary>
    public class OapiProcessTemplateUpgradeResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误code
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回是否升级成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 服务调用时候成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
