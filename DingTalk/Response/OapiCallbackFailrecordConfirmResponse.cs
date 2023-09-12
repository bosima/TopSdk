using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCallbackFailrecordConfirmResponse.
    /// </summary>
    public class OapiCallbackFailrecordConfirmResponse : DingTalkResponse
    {
        /// <summary>
        /// 确认成功的id列表
        /// </summary>
        [XmlArray("confirm_list")]
        [XmlArrayItem("number")]
        public List<long> ConfirmList { get; set; }

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

    }
}
