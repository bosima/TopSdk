using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiHrmEmployeeGetResponse.
    /// </summary>
    public class OapiHrmEmployeeGetResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 花名册分组列表
        /// </summary>
        [XmlArray("group_list")]
        [XmlArrayItem("field_group_vpo")]
        public List<FieldGroupVpoDomain> GroupList { get; set; }

	/// <summary>
/// SysCustomFieldVpoDomain Data Structure.
/// </summary>
[Serializable]

public class SysCustomFieldVpoDomain : TopObject
{
	        /// <summary>
	        /// 人事管理员确认员工入职的时候，是否必填该字段
	        /// </summary>
	        [XmlElement("confirm_entry_required")]
	        public bool ConfirmEntryRequired { get; set; }
	
	        /// <summary>
	        /// 手机端通讯录个人信息页，是否显示该字段
	        /// </summary>
	        [XmlElement("contact_client_flag")]
	        public bool ContactClientFlag { get; set; }
	
	        /// <summary>
	        /// 是否是通讯录字段，包括系统字段和扩展字段
	        /// </summary>
	        [XmlElement("contact_flag")]
	        public bool ContactFlag { get; set; }
	
	        /// <summary>
	        /// 是否是通讯录系统字段
	        /// </summary>
	        [XmlElement("contact_system_flag")]
	        public bool ContactSystemFlag { get; set; }
	
	        /// <summary>
	        /// corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 是否已删除
	        /// </summary>
	        [XmlElement("deleted")]
	        public bool Deleted { get; set; }
	
	        /// <summary>
	        /// 员工是否可编辑
	        /// </summary>
	        [XmlElement("editable_by_emp")]
	        public bool EditableByEmp { get; set; }
	
	        /// <summary>
	        /// HR是否可编辑该字段
	        /// </summary>
	        [XmlElement("editable_by_hr")]
	        public bool EditableByHr { get; set; }
	
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
	
	        /// <summary>
	        /// 字段类型，有TEXT,IMAGE,SELECT,TIME四种类型，与type_name一一对应
	        /// </summary>
	        [XmlElement("field_type")]
	        public string FieldType { get; set; }
	
	        /// <summary>
	        /// 员工查看个人档案时，该字段是否隐藏
	        /// </summary>
	        [XmlElement("hidden_from_employee_flag")]
	        public bool HiddenFromEmployeeFlag { get; set; }
	
	        /// <summary>
	        /// 花名册字段说明
	        /// </summary>
	        [XmlElement("hint")]
	        public string Hint { get; set; }
	
	        /// <summary>
	        /// 是否无水印，仅针对图片类型的字段
	        /// </summary>
	        [XmlElement("no_watermark")]
	        public bool NoWatermark { get; set; }
	
	        /// <summary>
	        /// 选项类花名册字段的选择内容，是一个json数组
	        /// </summary>
	        [XmlElement("option_text")]
	        public string OptionText { get; set; }
	
	        /// <summary>
	        /// 是否必须
	        /// </summary>
	        [XmlElement("required")]
	        public bool Required { get; set; }
	
	        /// <summary>
	        /// 智能人事花名册默认的系统字段，包含通讯录的系统字段和花名册新增的字段
	        /// </summary>
	        [XmlElement("system_flag")]
	        public bool SystemFlag { get; set; }
	
	        /// <summary>
	        /// 类型名，有文本，图片，选项，时间四种类型
	        /// </summary>
	        [XmlElement("type_name")]
	        public string TypeName { get; set; }
	
	        /// <summary>
	        /// 字段的值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
	
	        /// <summary>
	        /// 员工填写入职登记表的时候，该字段是否可见
	        /// </summary>
	        [XmlElement("visible_by_emp")]
	        public bool VisibleByEmp { get; set; }
}

	/// <summary>
/// FieldGroupVpoDomain Data Structure.
/// </summary>
[Serializable]

public class FieldGroupVpoDomain : TopObject
{
	        /// <summary>
	        /// 字段列表
	        /// </summary>
	        [XmlArray("field_list")]
	        [XmlArrayItem("sys_custom_field_vpo")]
	        public List<SysCustomFieldVpoDomain> FieldList { get; set; }
	
	        /// <summary>
	        /// 花名册分组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 花名册分组名
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
}

    }
}
