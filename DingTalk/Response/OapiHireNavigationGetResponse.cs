using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiHireNavigationGetResponse.
    /// </summary>
    public class OapiHireNavigationGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码，0表示成功
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 导航栏数据的json字符串
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
