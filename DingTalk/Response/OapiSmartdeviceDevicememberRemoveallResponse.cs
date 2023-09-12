using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceDevicememberRemoveallResponse.
    /// </summary>
    public class OapiSmartdeviceDevicememberRemoveallResponse : DingTalkResponse
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
        /// 本次操作结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
