using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmRosterMetaGetResponse.
    /// </summary>
    public class OapiSmartworkHrmRosterMetaGetResponse : DingTalkResponse
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
        /// 花名册分组定义
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("group_meta_info")]
        public List<GroupMetaInfoDomain> Result { get; set; }

        /// <summary>
        /// 服务调用成功
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
	        /// 是否衍生字段(比如司龄、年龄等系统计算的字段)
	        /// </summary>
	        [XmlElement("derived")]
	        public bool Derived { get; set; }
	
	        /// <summary>
	        /// 字段标识
	        /// </summary>
	        [XmlElement("field_code")]
	        public string FieldCode { get; set; }
	
	        /// <summary>
	        /// 字段名称
	        /// </summary>
	        [XmlElement("field_name")]
	        public string FieldName { get; set; }
	
	        /// <summary>
	        /// 字段类型："TextField", "文本"； "DDPhotoField", "附件"； "DDSelectField", "选项"； "DDDateField", "时间"
	        /// </summary>
	        [XmlElement("field_type")]
	        public string FieldType { get; set; }
	
	        /// <summary>
	        /// 选型类型字段的kv值
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
	        /// 分组是否支持明细
	        /// </summary>
	        [XmlElement("detail")]
	        public bool Detail { get; set; }
	
	        /// <summary>
	        /// 花名册分组内字段定义
	        /// </summary>
	        [XmlArray("field_meta_info_list")]
	        [XmlArrayItem("field_meta_info")]
	        public List<FieldMetaInfoDomain> FieldMetaInfoList { get; set; }
	
	        /// <summary>
	        /// 分组标识
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 分组名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
}

    }
}
