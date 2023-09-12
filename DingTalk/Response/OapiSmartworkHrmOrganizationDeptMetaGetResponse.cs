using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmOrganizationDeptMetaGetResponse.
    /// </summary>
    public class OapiSmartworkHrmOrganizationDeptMetaGetResponse : DingTalkResponse
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
        /// 结果集
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("org_ext_meta")]
        public List<OrgExtMetaDomain> Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OrgExtOptionDomain Data Structure.
/// </summary>
[Serializable]

public class OrgExtOptionDomain : TopObject
{
	        /// <summary>
	        /// 选项的key
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 选项文本
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
}

	/// <summary>
/// OrgExtMetaDomain Data Structure.
/// </summary>
[Serializable]

public class OrgExtMetaDomain : TopObject
{
	        /// <summary>
	        /// 结果集
	        /// </summary>
	        [XmlArray("ext_options")]
	        [XmlArrayItem("org_ext_option")]
	        public List<OrgExtOptionDomain> ExtOptions { get; set; }
	
	        /// <summary>
	        /// 字段code
	        /// </summary>
	        [XmlElement("field_code")]
	        public string FieldCode { get; set; }
	
	        /// <summary>
	        /// 字段名称
	        /// </summary>
	        [XmlElement("field_name")]
	        public string FieldName { get; set; }
}

    }
}
