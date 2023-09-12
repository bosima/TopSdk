using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMicroappRuleGetRuleListResponse.
    /// </summary>
    public class OapiMicroappRuleGetRuleListResponse : DingTalkResponse
    {
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
        /// 用户绑定的规则id列表
        /// </summary>
        [XmlArray("ruleIdList")]
        [XmlArrayItem("number")]
        public List<long> RuleIdList { get; set; }

    }
}
