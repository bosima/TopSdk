using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpHrmEmployeeGetResponse.
    /// </summary>
    public class CorpHrmEmployeeGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// SysCustomFieldVpoDomain Data Structure.
/// </summary>
[Serializable]

public class SysCustomFieldVpoDomain : TopObject
{
	        /// <summary>
	        /// 确认入职是否必填
	        /// </summary>
	        [XmlElement("confirm_entry_required")]
	        public bool ConfirmEntryRequired { get; set; }
	
	        /// <summary>
	        /// 是否通讯录client字段
	        /// </summary>
	        [XmlElement("contact_client_flag")]
	        public bool ContactClientFlag { get; set; }
	
	        /// <summary>
	        /// 是否通讯录字段
	        /// </summary>
	        [XmlElement("contact_flag")]
	        public bool ContactFlag { get; set; }
	
	        /// <summary>
	        /// 通讯录来源
	        /// </summary>
	        [XmlElement("contact_source")]
	        public long ContactSource { get; set; }
	
	        /// <summary>
	        /// 是否通讯录系统字段
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
	        /// editableByEmp
	        /// </summary>
	        [XmlElement("editable_by_emp")]
	        public bool EditableByEmp { get; set; }
	
	        /// <summary>
	        /// editableByHr
	        /// </summary>
	        [XmlElement("editable_by_hr")]
	        public bool EditableByHr { get; set; }
	
	        /// <summary>
	        /// 在个人信息展示
	        /// </summary>
	        [XmlElement("emp_profile_required")]
	        public bool EmpProfileRequired { get; set; }
	
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
	        /// 字段类型
	        /// </summary>
	        [XmlElement("field_type")]
	        public string FieldType { get; set; }
	
	        /// <summary>
	        /// groupId
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 对员工不可见
	        /// </summary>
	        [XmlElement("hidden_from_employee_flag")]
	        public bool HiddenFromEmployeeFlag { get; set; }
	
	        /// <summary>
	        /// 提醒
	        /// </summary>
	        [XmlElement("hint")]
	        public string Hint { get; set; }
	
	        /// <summary>
	        /// 字段key
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 是否需要水印
	        /// </summary>
	        [XmlElement("no_watermark")]
	        public bool NoWatermark { get; set; }
	
	        /// <summary>
	        /// 选项值
	        /// </summary>
	        [XmlElement("option_text")]
	        public string OptionText { get; set; }
	
	        /// <summary>
	        /// required
	        /// </summary>
	        [XmlElement("required")]
	        public bool Required { get; set; }
	
	        /// <summary>
	        /// 是否系统字段
	        /// </summary>
	        [XmlElement("system_flag")]
	        public bool SystemFlag { get; set; }
	
	        /// <summary>
	        /// 类型名
	        /// </summary>
	        [XmlElement("type_name")]
	        public string TypeName { get; set; }
	
	        /// <summary>
	        /// 字段的值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
	
	        /// <summary>
	        /// visibleByEmp
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

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 花名册分组列表
	        /// </summary>
	        [XmlArray("group_list")]
	        [XmlArrayItem("field_group_vpo")]
	        public List<FieldGroupVpoDomain> GroupList { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
