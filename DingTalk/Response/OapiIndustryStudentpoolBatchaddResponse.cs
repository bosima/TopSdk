using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiIndustryStudentpoolBatchaddResponse.
    /// </summary>
    public class OapiIndustryStudentpoolBatchaddResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 校验重名,返回重名人列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("string")]
        public List<string> Result { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
