using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMicroappVisibleScopesResponse.
    /// </summary>
    public class OapiMicroappVisibleScopesResponse : DingTalkResponse
    {
        /// <summary>
        /// 微应用的可见部门id列表，格式为JSON数组
        /// </summary>
        [XmlArray("deptVisibleScopes")]
        [XmlArrayItem("number")]
        public List<long> DeptVisibleScopes { get; set; }

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

        /// <summary>
        /// 是否仅限管理员可见
        /// </summary>
        [XmlElement("isHidden")]
        public bool IsHidden { get; set; }

        /// <summary>
        /// 微应用的可见用户id列表，格式为JSON数组
        /// </summary>
        [XmlArray("userVisibleScopes")]
        [XmlArrayItem("string")]
        public List<string> UserVisibleScopes { get; set; }

    }
}
