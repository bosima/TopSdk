using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMicroappUpdateResponse.
    /// </summary>
    public class OapiMicroappUpdateResponse : DingTalkResponse
    {
        /// <summary>
        /// 微应用实例化id，企业只能删除自建微应用
        /// </summary>
        [XmlElement("agentid")]
        public long Agentid { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 对返回码的文本描述内容
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

    }
}
