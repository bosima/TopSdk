using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.customerservice.ticket.query
    /// </summary>
    public class OapiCustomerserviceTicketQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCustomerserviceTicketQueryResponse>
    {
        /// <summary>
        /// 查询对象
        /// </summary>
        public string TicketPageQueryDto { get; set; }

        public TicketPageQueryDtoDomain TicketPageQueryDto_ { set { this.TicketPageQueryDto = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.customerservice.ticket.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ticket_page_query_dto", this.TicketPageQueryDto);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ticket_page_query_dto", this.TicketPageQueryDto);
        }

	/// <summary>
/// TicketPageQueryDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TicketPageQueryDtoDomain : TopObject
{
	        /// <summary>
	        /// 游标
	        /// </summary>
	        [XmlElement("cursor")]
	        public Nullable<long> Cursor { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_date")]
	        public Nullable<DateTime> EndDate { get; set; }
	
	        /// <summary>
	        /// 三方账号id
	        /// </summary>
	        [XmlElement("foreign_id")]
	        public string ForeignId { get; set; }
	
	        /// <summary>
	        /// 三方账号姓名
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
	        /// 分页大小
	        /// </summary>
	        [XmlElement("size")]
	        public Nullable<long> Size { get; set; }
	
	        /// <summary>
	        /// 三方账号标识
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public Nullable<DateTime> StartDate { get; set; }
	
	        /// <summary>
	        /// 工单id
	        /// </summary>
	        [XmlElement("ticket_id")]
	        public string TicketId { get; set; }
	
	        /// <summary>
	        /// 待受理
	        /// </summary>
	        [XmlElement("ticket_status")]
	        public string TicketStatus { get; set; }
	
	        /// <summary>
	        /// 工单类型id
	        /// </summary>
	        [XmlElement("ticket_template_id")]
	        public string TicketTemplateId { get; set; }
}

        #endregion
    }
}
