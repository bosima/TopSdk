using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.collection.schema.create
    /// </summary>
    public class OapiCollectionSchemaCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCollectionSchemaCreateResponse>
    {
        /// <summary>
        /// 根请求
        /// </summary>
        public string Request { get; set; }

        public SaveFormSchemaRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.collection.schema.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// ProcessVisibleValueVoDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessVisibleValueVoDomain : TopObject
{
	        /// <summary>
	        /// 类型
	        /// </summary>
	        [XmlElement("visible_type")]
	        public Nullable<long> VisibleType { get; set; }
	
	        /// <summary>
	        /// 值
	        /// </summary>
	        [XmlElement("visible_value")]
	        public string VisibleValue { get; set; }
}

	/// <summary>
/// FormSchemaSettingVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormSchemaSettingVoDomain : TopObject
{
	        /// <summary>
	        /// 业务类型
	        /// </summary>
	        [XmlElement("biz_type")]
	        public Nullable<long> BizType { get; set; }
	
	        /// <summary>
	        /// 填写结束时间/循环表单的循环结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<DateTime> EndTime { get; set; }
	
	        /// <summary>
	        /// 表单类型
	        /// </summary>
	        [XmlElement("form_type")]
	        public Nullable<long> FormType { get; set; }
	
	        /// <summary>
	        /// 循环周期
	        /// </summary>
	        [XmlArray("loop_day_of_weeks")]
	        [XmlArrayItem("number")]
	        public List<string> LoopDayOfWeeks { get; set; }
	
	        /// <summary>
	        /// 提醒时间
	        /// </summary>
	        [XmlElement("loop_time")]
	        public string LoopTime { get; set; }
	
	        /// <summary>
	        /// 回复时间开关/循环周期启用
	        /// </summary>
	        [XmlElement("reply_time")]
	        public Nullable<bool> ReplyTime { get; set; }
}

	/// <summary>
/// BehaviorTargetDomain Data Structure.
/// </summary>
[Serializable]

public class BehaviorTargetDomain : TopObject
{
	        /// <summary>
	        /// 行为
	        /// </summary>
	        [XmlElement("behavior")]
	        public string Behavior { get; set; }
	
	        /// <summary>
	        /// 控件ID
	        /// </summary>
	        [XmlElement("field_id")]
	        public string FieldId { get; set; }
}

	/// <summary>
/// BehaviorLinkageVoDomain Data Structure.
/// </summary>
[Serializable]

public class BehaviorLinkageVoDomain : TopObject
{
	        /// <summary>
	        /// 选项级联目标
	        /// </summary>
	        [XmlArray("targets")]
	        [XmlArrayItem("behavior_target")]
	        public List<BehaviorTargetDomain> Targets { get; set; }
	
	        /// <summary>
	        /// 值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// ComponentPropOptionVoDomain Data Structure.
/// </summary>
[Serializable]

public class ComponentPropOptionVoDomain : TopObject
{
	        /// <summary>
	        /// 名称
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 选项值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// ComponentMatrixDefVoDomain Data Structure.
/// </summary>
[Serializable]

public class ComponentMatrixDefVoDomain : TopObject
{
	        /// <summary>
	        /// 别名
	        /// </summary>
	        [XmlElement("alias")]
	        public string Alias { get; set; }
	
	        /// <summary>
	        /// 主键
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// ComponentPropVoDomain Data Structure.
/// </summary>
[Serializable]

public class ComponentPropVoDomain : TopObject
{
	        /// <summary>
	        /// 选项级联属性
	        /// </summary>
	        [XmlArray("behavior_linkage")]
	        [XmlArrayItem("behavior_linkage_vo")]
	        public List<BehaviorLinkageVoDomain> BehaviorLinkage { get; set; }
	
	        /// <summary>
	        /// 系统别名
	        /// </summary>
	        [XmlElement("biz_alias")]
	        public string BizAlias { get; set; }
	
	        /// <summary>
	        /// 矩阵表单组件列定义
	        /// </summary>
	        [XmlArray("cols")]
	        [XmlArrayItem("component_matrix_def_vo")]
	        public List<ComponentMatrixDefVoDomain> Cols { get; set; }
	
	        /// <summary>
	        /// 控件id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 标签
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// 带选项的组件的option
	        /// </summary>
	        [XmlArray("options")]
	        [XmlArrayItem("component_prop_option_vo")]
	        public List<ComponentPropOptionVoDomain> Options { get; set; }
	
	        /// <summary>
	        /// 占位符
	        /// </summary>
	        [XmlElement("placeholder")]
	        public string Placeholder { get; set; }
	
	        /// <summary>
	        /// 是否必填
	        /// </summary>
	        [XmlElement("required")]
	        public Nullable<bool> Required { get; set; }
	
	        /// <summary>
	        /// 矩阵表单组件行定义
	        /// </summary>
	        [XmlArray("rows")]
	        [XmlArrayItem("component_matrix_def_vo")]
	        public List<ComponentMatrixDefVoDomain> Rows { get; set; }
}

	/// <summary>
/// FormComponentVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormComponentVoDomain : TopObject
{
	        /// <summary>
	        /// 控件名称
	        /// </summary>
	        [XmlElement("component_name")]
	        public string ComponentName { get; set; }
	
	        /// <summary>
	        /// 控件属性
	        /// </summary>
	        [XmlElement("props")]
	        public ComponentPropVoDomain Props { get; set; }
}

	/// <summary>
/// FormContentVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormContentVoDomain : TopObject
{
	        /// <summary>
	        /// 控件数组
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("form_component_vo")]
	        public List<FormComponentVoDomain> Items { get; set; }
}

	/// <summary>
/// SaveFormSchemaRequestDomain Data Structure.
/// </summary>
[Serializable]

public class SaveFormSchemaRequestDomain : TopObject
{
	        /// <summary>
	        /// 控件字符串
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 表单设置
	        /// </summary>
	        [XmlElement("custom_setting")]
	        public FormSchemaSettingVoDomain CustomSetting { get; set; }
	
	        /// <summary>
	        /// 控件对象
	        /// </summary>
	        [XmlElement("form_content")]
	        public FormContentVoDomain FormContent { get; set; }
	
	        /// <summary>
	        /// 图标
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 提示
	        /// </summary>
	        [XmlElement("memo")]
	        public string Memo { get; set; }
	
	        /// <summary>
	        /// 表单名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 可见范围
	        /// </summary>
	        [XmlArray("process_visible_list")]
	        [XmlArrayItem("process_visible_value_vo")]
	        public List<ProcessVisibleValueVoDomain> ProcessVisibleList { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
