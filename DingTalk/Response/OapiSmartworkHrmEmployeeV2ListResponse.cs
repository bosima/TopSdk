using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmEmployeeV2ListResponse.
    /// </summary>
    public class OapiSmartworkHrmEmployeeV2ListResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("emp_roster_field_vo")]
        public List<EmpRosterFieldVoDomain> Result { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// FieldValueVoDomain Data Structure.
/// </summary>
[Serializable]

public class FieldValueVoDomain : TopObject
{
	        /// <summary>
	        /// 标识第几条明细（下标从0开始）
	        /// </summary>
	        [XmlElement("item_index")]
	        public long ItemIndex { get; set; }
	
	        /// <summary>
	        /// 字段展示值（选项类型字段对应选项的value）
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// 字段取值（选项类型字段对应选项的key）
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// EmpFieldDataVoDomain Data Structure.
/// </summary>
[Serializable]

public class EmpFieldDataVoDomain : TopObject
{
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
	        /// 字段值列表（明细分组字段包含多条、非明细分组仅一条记录）
	        /// </summary>
	        [XmlArray("field_value_list")]
	        [XmlArrayItem("field_value_vo")]
	        public List<FieldValueVoDomain> FieldValueList { get; set; }
	
	        /// <summary>
	        /// 分组标识
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
}

	/// <summary>
/// EmpRosterFieldVoDomain Data Structure.
/// </summary>
[Serializable]

public class EmpRosterFieldVoDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 字段信息列表
	        /// </summary>
	        [XmlArray("field_data_list")]
	        [XmlArrayItem("emp_field_data_vo")]
	        public List<EmpFieldDataVoDomain> FieldDataList { get; set; }
	
	        /// <summary>
	        /// 根据企业ID和钉钉用户ID生成的唯一ID
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
