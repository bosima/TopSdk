using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMedalCorpmedalQueryResponse.
    /// </summary>
    public class OapiMedalCorpmedalQueryResponse : DingTalkResponse
    {
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

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public CorpMedalQueryResponseDomain Result { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CorpMedalDTODomain Data Structure.
/// </summary>
[Serializable]

public class CorpMedalDTODomain : TopObject
{
	        /// <summary>
	        /// 勋章授予时间
	        /// </summary>
	        [XmlElement("grant_time")]
	        public string GrantTime { get; set; }
	
	        /// <summary>
	        /// 勋章模板ID
	        /// </summary>
	        [XmlElement("template_id")]
	        public long TemplateId { get; set; }
	
	        /// <summary>
	        /// 是否佩戴勋章
	        /// </summary>
	        [XmlElement("wear")]
	        public bool Wear { get; set; }
}

	/// <summary>
/// CorpMedalQueryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class CorpMedalQueryResponseDomain : TopObject
{
	        /// <summary>
	        /// 勋章列表
	        /// </summary>
	        [XmlArray("corp_medal_list")]
	        [XmlArrayItem("corp_medal_d_t_o")]
	        public List<CorpMedalDTODomain> CorpMedalList { get; set; }
}

    }
}
