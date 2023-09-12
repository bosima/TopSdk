using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.customerservice.ticket.create
    /// </summary>
    public class OapiCustomerserviceTicketCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCustomerserviceTicketCreateResponse>
    {
        /// <summary>
        /// 工单对象
        /// </summary>
        public string TicketCreate { get; set; }

        public TicketCreateDtoDomain TicketCreate_ { set { this.TicketCreate = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.customerservice.ticket.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ticket_create", this.TicketCreate);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ticket_create", this.TicketCreate);
        }

	/// <summary>
/// TicketFieldDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TicketFieldDtoDomain : TopObject
{
	        /// <summary>
	        /// 字段值
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 字段key
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
	
	        /// <summary>
	        /// 字段值类型，attachments，附件，数组类型；text，文本类型
	        /// </summary>
	        [XmlElement("value_type")]
	        public string ValueType { get; set; }
}

	/// <summary>
/// TicketCreateDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TicketCreateDtoDomain : TopObject
{
	        /// <summary>
	        /// 第三方会员id
	        /// </summary>
	        [XmlElement("foreign_id")]
	        public string ForeignId { get; set; }
	
	        /// <summary>
	        /// 第三方会员名
	        /// </summary>
	        [XmlElement("foreign_name")]
	        public string ForeignName { get; set; }
	
	        /// <summary>
	        /// 实例id
	        /// </summary>
	        [XmlElement("open_instance_id")]
	        public string OpenInstanceId { get; set; }
	
	        /// <summary>
	        /// 1智能客服产品
	        /// </summary>
	        [XmlElement("production_type")]
	        public string ProductionType { get; set; }
	
	        /// <summary>
	        /// 工单表单
	        /// </summary>
	        [XmlArray("properties")]
	        [XmlArrayItem("ticket_field_dto")]
	        public List<TicketFieldDtoDomain> Properties { get; set; }
	
	        /// <summary>
	        /// 会员标识
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 工单模板id
	        /// </summary>
	        [XmlElement("template_id")]
	        public string TemplateId { get; set; }
	
	        /// <summary>
	        /// 工单标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

        #endregion
    }
}
