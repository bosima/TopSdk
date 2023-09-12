using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosExecClothesSynccreateResponse.
    /// </summary>
    public class OapiRhinoMosExecClothesSynccreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 钉钉错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 衣服ID列表
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("number")]
        public List<long> Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
