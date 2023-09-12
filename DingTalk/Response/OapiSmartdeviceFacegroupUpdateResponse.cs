using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceFacegroupUpdateResponse.
    /// </summary>
    public class OapiSmartdeviceFacegroupUpdateResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代号
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 更新结果：为true时代表更新成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// API调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
