using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosLayoutOperationdefSaveflowResponse.
    /// </summary>
    public class OapiRhinoMosLayoutOperationdefSaveflowResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }

    }
}
