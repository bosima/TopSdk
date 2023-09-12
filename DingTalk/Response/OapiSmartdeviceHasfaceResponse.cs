using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceHasfaceResponse.
    /// </summary>
    public class OapiSmartdeviceHasfaceResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 已录入用户列表
        /// </summary>
        [XmlArray("userid_list")]
        [XmlArrayItem("string")]
        public List<string> UseridList { get; set; }

    }
}
