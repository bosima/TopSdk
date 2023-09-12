using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessFormConditionListResponse.
    /// </summary>
    public class OapiProcessFormConditionListResponse : DingTalkResponse
    {
        /// <summary>
        /// 0
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 表单列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("simple_form_component_vo")]
        public List<SimpleFormComponentVoDomain> List { get; set; }

	/// <summary>
/// SimpleFormComponentVoDomain Data Structure.
/// </summary>
[Serializable]

public class SimpleFormComponentVoDomain : TopObject
{
	        /// <summary>
	        /// 表单id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 表单名称
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
}

    }
}
