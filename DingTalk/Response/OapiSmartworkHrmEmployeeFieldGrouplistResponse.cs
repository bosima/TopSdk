using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmEmployeeFieldGrouplistResponse.
    /// </summary>
    public class OapiSmartworkHrmEmployeeFieldGrouplistResponse : DingTalkResponse
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
        [XmlArrayItem("group_meta_info")]
        public List<GroupMetaInfoDomain> Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// FieldMetaInfoDomain Data Structure.
/// </summary>
[Serializable]

public class FieldMetaInfoDomain : TopObject
{
	        /// <summary>
	        /// 字段code
	        /// </summary>
	        [XmlElement("field_code")]
	        public string FieldCode { get; set; }
	
	        /// <summary>
	        /// 字段描述
	        /// </summary>
	        [XmlElement("field_name")]
	        public string FieldName { get; set; }
	
	        /// <summary>
	        /// 字段类型
	        /// </summary>
	        [XmlElement("field_type")]
	        public string FieldType { get; set; }
	
	        /// <summary>
	        /// 选择字段值
	        /// </summary>
	        [XmlElement("option_text")]
	        public string OptionText { get; set; }
}

	/// <summary>
/// GroupMetaInfoDomain Data Structure.
/// </summary>
[Serializable]

public class GroupMetaInfoDomain : TopObject
{
	        /// <summary>
	        /// 组里面的字段集合
	        /// </summary>
	        [XmlArray("field_list")]
	        [XmlArrayItem("field_meta_info")]
	        public List<FieldMetaInfoDomain> FieldList { get; set; }
	
	        /// <summary>
	        /// 字段组ID
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 是否支持明细
	        /// </summary>
	        [XmlElement("has_detail")]
	        public bool HasDetail { get; set; }
}

    }
}
