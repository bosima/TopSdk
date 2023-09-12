using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.customerservice.action.query
    /// </summary>
    public class OapiCustomerserviceActionQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCustomerserviceActionQueryResponse>
    {
        /// <summary>
        /// 分页查询条件
        /// </summary>
        public string TicketActionPageQuery { get; set; }

        public TicketActionPageQueryDtoDomain TicketActionPageQuery_ { set { this.TicketActionPageQuery = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.customerservice.action.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ticket_action_page_query", this.TicketActionPageQuery);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ticket_action_page_query", this.TicketActionPageQuery);
        }

	/// <summary>
/// TicketActionPageQueryDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TicketActionPageQueryDtoDomain : TopObject
{
	        /// <summary>
	        /// 查询游标
	        /// </summary>
	        [XmlElement("cursor")]
	        public Nullable<long> Cursor { get; set; }
	
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
	        /// 分页大小
	        /// </summary>
	        [XmlElement("size")]
	        public Nullable<long> Size { get; set; }
	
	        /// <summary>
	        /// 工单id
	        /// </summary>
	        [XmlElement("ticket_id")]
	        public string TicketId { get; set; }
}

        #endregion
    }
}
