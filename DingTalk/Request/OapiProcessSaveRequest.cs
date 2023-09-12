using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.save
    /// </summary>
    public class OapiProcessSaveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessSaveResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string SaveProcessRequest { get; set; }

        public SaveProcessRequestDomain SaveProcessRequest_ { set { this.SaveProcessRequest = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.save";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("saveProcessRequest", this.SaveProcessRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// FormComponentStatVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormComponentStatVoDomain : TopObject
{
	        /// <summary>
	        /// 组件id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 组件名称
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// 单元
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
	
	        /// <summary>
	        /// 统计总和是否大写
	        /// </summary>
	        [XmlElement("upper")]
	        public Nullable<bool> Upper { get; set; }
}

	/// <summary>
/// FormComponentPropVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormComponentPropVoDomain : TopObject
{
	        /// <summary>
	        /// 增加明细动作名称
	        /// </summary>
	        [XmlElement("action_name")]
	        public string ActionName { get; set; }
	
	        /// <summary>
	        /// 套件是否开启异步获取分条件规则
	        /// </summary>
	        [XmlElement("async_condition")]
	        public Nullable<bool> AsyncCondition { get; set; }
	
	        /// <summary>
	        /// 套件别名
	        /// </summary>
	        [XmlElement("biz_alias")]
	        public string BizAlias { get; set; }
	
	        /// <summary>
	        /// 套件类型
	        /// </summary>
	        [XmlElement("biz_type")]
	        public string BizType { get; set; }
	
	        /// <summary>
	        /// 内部联系人choice，1表示多选，0表示单选
	        /// </summary>
	        [XmlElement("choice")]
	        public Nullable<long> Choice { get; set; }
	
	        /// <summary>
	        /// 说明文字
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 是否自动计算时长
	        /// </summary>
	        [XmlElement("duration")]
	        public Nullable<bool> Duration { get; set; }
	
	        /// <summary>
	        /// 时间格式
	        /// </summary>
	        [XmlElement("format")]
	        public string Format { get; set; }
	
	        /// <summary>
	        /// 暂不需要
	        /// </summary>
	        [XmlElement("formula")]
	        public string Formula { get; set; }
	
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
	
	        /// <summary>
	        /// 说明文案的链接地址
	        /// </summary>
	        [XmlElement("link")]
	        public string Link { get; set; }
	
	        /// <summary>
	        /// 是否参与打印(1表示不打印, 0表示打印)
	        /// </summary>
	        [XmlElement("not_print")]
	        public string NotPrint { get; set; }
	
	        /// <summary>
	        /// 是否需要大写 默认是需要; 1:不需要大写, 空或者0:需要大写
	        /// </summary>
	        [XmlElement("not_upper")]
	        public string NotUpper { get; set; }
	
	        /// <summary>
	        /// 单选框或者多选框的选项
	        /// </summary>
	        [XmlArray("options")]
	        [XmlArrayItem("string")]
	        public List<string> Options { get; set; }
	
	        /// <summary>
	        /// 占位提示（仅输入类组件）
	        /// </summary>
	        [XmlElement("placeholder")]
	        public string Placeholder { get; set; }
	
	        /// <summary>
	        /// 是否必填
	        /// </summary>
	        [XmlElement("required")]
	        public Nullable<bool> Required { get; set; }
	
	        /// <summary>
	        /// 需要计算总和的明细组件
	        /// </summary>
	        [XmlArray("stat_field")]
	        [XmlArrayItem("form_component_stat_vo")]
	        public List<FormComponentStatVoDomain> StatField { get; set; }
	
	        /// <summary>
	        /// 数字组件/日期区间组件单位属性
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
}

	/// <summary>
/// FormComponentPropVo2Domain Data Structure.
/// </summary>
[Serializable]

public class FormComponentPropVo2Domain : TopObject
{
	        /// <summary>
	        /// 套件是否开启异步获取分条件规则
	        /// </summary>
	        [XmlElement("async_condition")]
	        public Nullable<bool> AsyncCondition { get; set; }
	
	        /// <summary>
	        /// 控件别名
	        /// </summary>
	        [XmlElement("biz_alias")]
	        public string BizAlias { get; set; }
	
	        /// <summary>
	        /// 控件类型
	        /// </summary>
	        [XmlElement("biz_type")]
	        public string BizType { get; set; }
	
	        /// <summary>
	        /// 内部联系人choice，1表示多选，0表示单选
	        /// </summary>
	        [XmlElement("choice")]
	        public Nullable<long> Choice { get; set; }
	
	        /// <summary>
	        /// 自定义控件渲染类型
	        /// </summary>
	        [XmlElement("common_biz_type")]
	        public string CommonBizType { get; set; }
	
	        /// <summary>
	        /// 说明文字
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 是否自动计算时长
	        /// </summary>
	        [XmlElement("duration")]
	        public Nullable<bool> Duration { get; set; }
	
	        /// <summary>
	        /// 时间格式
	        /// </summary>
	        [XmlElement("format")]
	        public string Format { get; set; }
	
	        /// <summary>
	        /// 暂不需要
	        /// </summary>
	        [XmlElement("formula")]
	        public string Formula { get; set; }
	
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
	
	        /// <summary>
	        /// 说明文案的链接地址
	        /// </summary>
	        [XmlElement("link")]
	        public string Link { get; set; }
	
	        /// <summary>
	        /// 是否参与打印(1表示不打印, 0表示打印)
	        /// </summary>
	        [XmlElement("not_print")]
	        public string NotPrint { get; set; }
	
	        /// <summary>
	        /// 是否需要大写 默认是需要; 1:不需要大写, 空或者0:需要大写
	        /// </summary>
	        [XmlElement("not_upper")]
	        public string NotUpper { get; set; }
	
	        /// <summary>
	        /// 单选框或者多选框的选项
	        /// </summary>
	        [XmlArray("options")]
	        [XmlArrayItem("string")]
	        public List<string> Options { get; set; }
	
	        /// <summary>
	        /// 占位提示（仅输入类组件）
	        /// </summary>
	        [XmlElement("placeholder")]
	        public string Placeholder { get; set; }
	
	        /// <summary>
	        /// 是否必填
	        /// </summary>
	        [XmlElement("required")]
	        public Nullable<bool> Required { get; set; }
	
	        /// <summary>
	        /// 明细展示方式：表格 table、列表list
	        /// </summary>
	        [XmlElement("table_view_mode")]
	        public string TableViewMode { get; set; }
	
	        /// <summary>
	        /// 数字组件/日期区间组件单位属性
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
}

	/// <summary>
/// FormComponentPropVo3Domain Data Structure.
/// </summary>
[Serializable]

public class FormComponentPropVo3Domain : TopObject
{
	        /// <summary>
	        /// 套件是否开启异步获取分条件规则
	        /// </summary>
	        [XmlElement("async_condition")]
	        public Nullable<bool> AsyncCondition { get; set; }
	
	        /// <summary>
	        /// 控件别名
	        /// </summary>
	        [XmlElement("biz_alias")]
	        public string BizAlias { get; set; }
	
	        /// <summary>
	        /// 内部联系人choice，1表示多选，0表示单选
	        /// </summary>
	        [XmlElement("choice")]
	        public Nullable<long> Choice { get; set; }
	
	        /// <summary>
	        /// 是否自动计算时长
	        /// </summary>
	        [XmlElement("duration")]
	        public Nullable<bool> Duration { get; set; }
	
	        /// <summary>
	        /// 时间格式
	        /// </summary>
	        [XmlElement("format")]
	        public string Format { get; set; }
	
	        /// <summary>
	        /// 计算公式
	        /// </summary>
	        [XmlElement("formula")]
	        public string Formula { get; set; }
	
	        /// <summary>
	        /// 控件id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 控件名称
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// 是否参与打印(1表示不打印, 0表示打印)
	        /// </summary>
	        [XmlElement("not_print")]
	        public string NotPrint { get; set; }
	
	        /// <summary>
	        /// 是否需要大写 默认是需要; 1:不需要大写, 空或者0:需要大写
	        /// </summary>
	        [XmlElement("not_upper")]
	        public string NotUpper { get; set; }
	
	        /// <summary>
	        /// 选项
	        /// </summary>
	        [XmlArray("options")]
	        [XmlArrayItem("string")]
	        public List<string> Options { get; set; }
	
	        /// <summary>
	        /// 占位提示（仅输入类组件）
	        /// </summary>
	        [XmlElement("placeholder")]
	        public string Placeholder { get; set; }
	
	        /// <summary>
	        /// 是否必填
	        /// </summary>
	        [XmlElement("required")]
	        public Nullable<bool> Required { get; set; }
	
	        /// <summary>
	        /// 数字组件/日期区间组件单位属性
	        /// </summary>
	        [XmlElement("unit")]
	        public string Unit { get; set; }
}

	/// <summary>
/// FormComponentVo3Domain Data Structure.
/// </summary>
[Serializable]

public class FormComponentVo3Domain : TopObject
{
	        /// <summary>
	        /// 控件类型
	        /// </summary>
	        [XmlElement("component_name")]
	        public string ComponentName { get; set; }
	
	        /// <summary>
	        /// 控件属性
	        /// </summary>
	        [XmlElement("props")]
	        public FormComponentPropVo3Domain Props { get; set; }
}

	/// <summary>
/// FormComponentVo2Domain Data Structure.
/// </summary>
[Serializable]

public class FormComponentVo2Domain : TopObject
{
	        /// <summary>
	        /// 子控件
	        /// </summary>
	        [XmlArray("children")]
	        [XmlArrayItem("form_component_vo3")]
	        public List<FormComponentVo3Domain> Children { get; set; }
	
	        /// <summary>
	        /// 控件类型
	        /// </summary>
	        [XmlElement("component_name")]
	        public string ComponentName { get; set; }
	
	        /// <summary>
	        /// 子表单属性
	        /// </summary>
	        [XmlElement("props")]
	        public FormComponentPropVo2Domain Props { get; set; }
}

	/// <summary>
/// FormComponentVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormComponentVoDomain : TopObject
{
	        /// <summary>
	        /// 子表单列表
	        /// </summary>
	        [XmlArray("children")]
	        [XmlArrayItem("form_component_vo2")]
	        public List<FormComponentVo2Domain> Children { get; set; }
	
	        /// <summary>
	        /// 控件类型
	        /// </summary>
	        [XmlElement("component_name")]
	        public string ComponentName { get; set; }
	
	        /// <summary>
	        /// 表单属性
	        /// </summary>
	        [XmlElement("props")]
	        public FormComponentPropVoDomain Props { get; set; }
}

	/// <summary>
/// ProcessConfigDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessConfigDomain : TopObject
{
	        /// <summary>
	        /// 是否在审批后台禁用删除操作
	        /// </summary>
	        [XmlElement("disable_delete_process")]
	        public Nullable<bool> DisableDeleteProcess { get; set; }
	
	        /// <summary>
	        /// 是否允许表单在审批管理后台可编辑。true表示不可以
	        /// </summary>
	        [XmlElement("disable_form_edit")]
	        public Nullable<bool> DisableFormEdit { get; set; }
	
	        /// <summary>
	        /// 是否在审批首页/工作台屏蔽模板
	        /// </summary>
	        [XmlElement("disable_homepage")]
	        public Nullable<bool> DisableHomepage { get; set; }
	
	        /// <summary>
	        /// 是否在审批详情页禁用再次提交操作
	        /// </summary>
	        [XmlElement("disable_resubmit")]
	        public Nullable<bool> DisableResubmit { get; set; }
	
	        /// <summary>
	        /// 是否在审批后台禁用停用操作
	        /// </summary>
	        [XmlElement("disable_stop_process_button")]
	        public Nullable<bool> DisableStopProcessButton { get; set; }
	
	        /// <summary>
	        /// 假流程模板编辑url
	        /// </summary>
	        [XmlElement("fake_template_edit_url")]
	        public string FakeTemplateEditUrl { get; set; }
	
	        /// <summary>
	        /// 设置模板是否隐藏，true表示隐藏
	        /// </summary>
	        [XmlElement("hidden")]
	        public Nullable<bool> Hidden { get; set; }
	
	        /// <summary>
	        /// 审批模板编辑跳转页。当fake_mode为true时，此参数失效。
	        /// </summary>
	        [XmlElement("template_edit_url")]
	        public string TemplateEditUrl { get; set; }
}

	/// <summary>
/// SaveProcessRequestDomain Data Structure.
/// </summary>
[Serializable]

public class SaveProcessRequestDomain : TopObject
{
	        /// <summary>
	        /// 企业应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 发起审批移动端链接
	        /// </summary>
	        [XmlElement("create_instance_mobile_url")]
	        public string CreateInstanceMobileUrl { get; set; }
	
	        /// <summary>
	        /// 发起审批pc链接
	        /// </summary>
	        [XmlElement("create_instance_pc_url")]
	        public string CreateInstancePcUrl { get; set; }
	
	        /// <summary>
	        /// 审批模板描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 分组id
	        /// </summary>
	        [XmlElement("dir_id")]
	        public string DirId { get; set; }
	
	        /// <summary>
	        /// 废弃，请使用process_config.disable_form_edit字段
	        /// </summary>
	        [XmlElement("disable_form_edit")]
	        public Nullable<bool> DisableFormEdit { get; set; }
	
	        /// <summary>
	        /// true
	        /// </summary>
	        [XmlElement("disable_stop_process_button")]
	        public Nullable<bool> DisableStopProcessButton { get; set; }
	
	        /// <summary>
	        /// true表示不带流程的模板
	        /// </summary>
	        [XmlElement("fake_mode")]
	        public Nullable<bool> FakeMode { get; set; }
	
	        /// <summary>
	        /// 表单列表
	        /// </summary>
	        [XmlArray("form_component_list")]
	        [XmlArrayItem("form_component_vo")]
	        public List<FormComponentVoDomain> FormComponentList { get; set; }
	
	        /// <summary>
	        /// 废弃，请使用process_config.hidden字段
	        /// </summary>
	        [XmlElement("hidden")]
	        public Nullable<bool> Hidden { get; set; }
	
	        /// <summary>
	        /// icon
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 审批模板名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 原分组id
	        /// </summary>
	        [XmlElement("origin_dir_id")]
	        public string OriginDirId { get; set; }
	
	        /// <summary>
	        /// 审批模板唯一码
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
	
	        /// <summary>
	        /// 模板配置属性
	        /// </summary>
	        [XmlElement("process_config")]
	        public ProcessConfigDomain ProcessConfig { get; set; }
	
	        /// <summary>
	        /// 废弃，请使用process_config.template_edit_url字段
	        /// </summary>
	        [XmlElement("template_edit_url")]
	        public string TemplateEditUrl { get; set; }
}

        #endregion
    }
}
