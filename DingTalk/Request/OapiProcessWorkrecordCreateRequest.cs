using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.workrecord.create
    /// </summary>
    public class OapiProcessWorkrecordCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessWorkrecordCreateResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public SaveFakeProcessInstanceRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.workrecord.create";
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
        }

	/// <summary>
/// FormComponentValueVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormComponentValueVoDomain : TopObject
{
	        /// <summary>
	        /// 扩展字段
	        /// </summary>
	        [XmlElement("extValue")]
	        public string ExtValue { get; set; }
	
	        /// <summary>
	        /// 表单名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 表单值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// NotifierVODomain Data Structure.
/// </summary>
[Serializable]

public class NotifierVODomain : TopObject
{
	        /// <summary>
	        /// 抄送时机，可选值有 start, start_finish, finish
	        /// </summary>
	        [XmlElement("notify_position")]
	        public string NotifyPosition { get; set; }
	
	        /// <summary>
	        /// 抄送人的用户ID
	        /// </summary>
	        [XmlElement("user_id")]
	        public string UserId { get; set; }
}

	/// <summary>
/// SaveFakeProcessInstanceRequestDomain Data Structure.
/// </summary>
[Serializable]

public class SaveFakeProcessInstanceRequestDomain : TopObject
{
	        /// <summary>
	        /// 应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 流程实例业务动作
	        /// </summary>
	        [XmlElement("biz_action")]
	        public string BizAction { get; set; }
	
	        /// <summary>
	        /// 审批自定义数据
	        /// </summary>
	        [XmlElement("custom_data")]
	        public string CustomData { get; set; }
	
	        /// <summary>
	        /// 表单参数列表
	        /// </summary>
	        [XmlArray("form_component_values")]
	        [XmlArrayItem("form_component_value_vo")]
	        public List<FormComponentValueVoDomain> FormComponentValues { get; set; }
	
	        /// <summary>
	        /// 流程实例主单instId
	        /// </summary>
	        [XmlElement("main_instance_id")]
	        public string MainInstanceId { get; set; }
	
	        /// <summary>
	        /// 抄送人列表
	        /// </summary>
	        [XmlArray("notifiers")]
	        [XmlArrayItem("notifier_v_o")]
	        public List<NotifierVODomain> Notifiers { get; set; }
	
	        /// <summary>
	        /// 审批发起人
	        /// </summary>
	        [XmlElement("originator_user_id")]
	        public string OriginatorUserId { get; set; }
	
	        /// <summary>
	        /// 审批模板唯一码
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
	
	        /// <summary>
	        /// 审批单评论
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 实例标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 实例跳转链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

        #endregion
    }
}
