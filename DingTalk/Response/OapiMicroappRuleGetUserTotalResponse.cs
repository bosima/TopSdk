using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMicroappRuleGetUserTotalResponse.
    /// </summary>
    public class OapiMicroappRuleGetUserTotalResponse : DingTalkResponse
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
        /// 返回入参中各个规则id对应的用户数
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("result")]
        public List<ResultDomain> Result { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// ruleId
	        /// </summary>
	        [XmlElement("ruleId")]
	        public long RuleId { get; set; }
	
	        /// <summary>
	        /// userTotal
	        /// </summary>
	        [XmlElement("userTotal")]
	        public long UserTotal { get; set; }
}

    }
}
