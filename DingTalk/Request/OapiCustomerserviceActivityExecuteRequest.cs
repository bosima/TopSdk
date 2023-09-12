using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.customerservice.activity.execute
    /// </summary>
    public class OapiCustomerserviceActivityExecuteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCustomerserviceActivityExecuteResponse>
    {
        /// <summary>
        /// 活动
        /// </summary>
        public string TicketActivity { get; set; }

        public TicketActivityDtoDomain TicketActivity_ { set { this.TicketActivity = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.customerservice.activity.execute";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ticket_activity", this.TicketActivity);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ticket_activity", this.TicketActivity);
        }

	/// <summary>
/// TicketFieldDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TicketFieldDtoDomain : TopObject
{
	        /// <summary>
	        /// key
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// value
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// TicketActivityDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TicketActivityDtoDomain : TopObject
{
	        /// <summary>
	        /// 活动code
	        /// </summary>
	        [XmlElement("activity_code")]
	        public string ActivityCode { get; set; }
	
	        /// <summary>
	        /// 第三方会员id
	        /// </summary>
	        [XmlElement("foreign_id")]
	        public string ForeignId { get; set; }
	
	        /// <summary>
	        /// 第三方会员名字
	        /// </summary>
	        [XmlElement("foreign_name")]
	        public string ForeignName { get; set; }
	
	        /// <summary>
	        /// 实例id
	        /// </summary>
	        [XmlElement("open_instance_id")]
	        public string OpenInstanceId { get; set; }
	
	        /// <summary>
	        /// 1智能客服
	        /// </summary>
	        [XmlElement("production_type")]
	        public string ProductionType { get; set; }
	
	        /// <summary>
	        /// 表单的数据
	        /// </summary>
	        [XmlArray("properties")]
	        [XmlArrayItem("ticket_field_dto")]
	        public List<TicketFieldDtoDomain> Properties { get; set; }
	
	        /// <summary>
	        /// 第三方会员来源
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 工单id
	        /// </summary>
	        [XmlElement("ticket_id")]
	        public string TicketId { get; set; }
}

        #endregion
    }
}
