using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmObjectmetaDescribeResponse.
    /// </summary>
    public class OapiCrmObjectmetaDescribeResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("result")]
        public DObjectDomain Result { get; set; }

	/// <summary>
/// SelectOptionsDomain Data Structure.
/// </summary>
[Serializable]

public class SelectOptionsDomain : TopObject
{
	        /// <summary>
	        /// 选项key
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 选项名
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// ReferenceFieldsDomain Data Structure.
/// </summary>
[Serializable]

public class ReferenceFieldsDomain : TopObject
{
	        /// <summary>
	        /// 引用的关联对象字段格式
	        /// </summary>
	        [XmlElement("format")]
	        public string Format { get; set; }
	
	        /// <summary>
	        /// 引用的关联对象字段显示名
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// 引用的关联对象的字段名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 引用的关联对象字段是否可空
	        /// </summary>
	        [XmlElement("nillable")]
	        public bool Nillable { get; set; }
	
	        /// <summary>
	        /// 引用的关联对象的字段选项列表
	        /// </summary>
	        [XmlArray("select_options")]
	        [XmlArrayItem("select_options")]
	        public List<SelectOptionsDomain> SelectOptions { get; set; }
	
	        /// <summary>
	        /// 引用的关联对象字段类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 引用的关联对象字段单位
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
}

	/// <summary>
/// RollUpSummaryFieldsDomain Data Structure.
/// </summary>
[Serializable]

public class RollUpSummaryFieldsDomain : TopObject
{
	        /// <summary>
	        /// 汇总方法
	        /// </summary>
	        [XmlElement("aggregator")]
	        public string Aggregator { get; set; }
	
	        /// <summary>
	        /// 需要汇总的明细内字段名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// FieldsDomain Data Structure.
/// </summary>
[Serializable]

public class FieldsDomain : TopObject
{
	        /// <summary>
	        /// 是否自定义字段
	        /// </summary>
	        [XmlElement("customized")]
	        public bool Customized { get; set; }
	
	        /// <summary>
	        /// 日期格式
	        /// </summary>
	        [XmlElement("format")]
	        public string Format { get; set; }
	
	        /// <summary>
	        /// 字段展示名
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// 字段名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 是否可空
	        /// </summary>
	        [XmlElement("nillable")]
	        public bool Nillable { get; set; }
	
	        /// <summary>
	        /// 是否引用关联
	        /// </summary>
	        [XmlElement("quote")]
	        public bool Quote { get; set; }
	
	        /// <summary>
	        /// 引用的关联对象的字段列表
	        /// </summary>
	        [XmlArray("reference_fields")]
	        [XmlArrayItem("reference_fields")]
	        public List<ReferenceFieldsDomain> ReferenceFields { get; set; }
	
	        /// <summary>
	        /// 关联对象名称
	        /// </summary>
	        [XmlElement("reference_to")]
	        public string ReferenceTo { get; set; }
	
	        /// <summary>
	        /// 对MasterDetail类型有效：roll-up summary字段列表
	        /// </summary>
	        [XmlArray("roll_up_summary_fields")]
	        [XmlArrayItem("roll_up_summary_fields")]
	        public List<RollUpSummaryFieldsDomain> RollUpSummaryFields { get; set; }
	
	        /// <summary>
	        /// 选项列表
	        /// </summary>
	        [XmlArray("select_options")]
	        [XmlArrayItem("select_options")]
	        public List<SelectOptionsDomain> SelectOptions { get; set; }
	
	        /// <summary>
	        /// 字段类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 日期单位/金额单位
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
}

	/// <summary>
/// DObjectDomain Data Structure.
/// </summary>
[Serializable]

public class DObjectDomain : TopObject
{
	        /// <summary>
	        /// 是否自定义对象
	        /// </summary>
	        [XmlElement("customized")]
	        public bool Customized { get; set; }
	
	        /// <summary>
	        /// 字段列表
	        /// </summary>
	        [XmlArray("fields")]
	        [XmlArrayItem("fields")]
	        public List<FieldsDomain> Fields { get; set; }
	
	        /// <summary>
	        /// 对象名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

    }
}
