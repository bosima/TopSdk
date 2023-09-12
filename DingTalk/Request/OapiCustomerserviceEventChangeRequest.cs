using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.customerservice.event.change
    /// </summary>
    public class OapiCustomerserviceEventChangeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCustomerserviceEventChangeResponse>
    {
        /// <summary>
        /// 事件对象
        /// </summary>
        public string EventDto { get; set; }

        public EventDtoDomain EventDto_ { set { this.EventDto = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.customerservice.event.change";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("event_dto", this.EventDto);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("event_dto", this.EventDto);
        }

	/// <summary>
/// EventDtoDomain Data Structure.
/// </summary>
[Serializable]

public class EventDtoDomain : TopObject
{
	        /// <summary>
	        /// 事件业务类型，参考com.dingtalk.customerservice.common.EventBizTypeEnum
	        /// </summary>
	        [XmlElement("biz_type")]
	        public string BizType { get; set; }
	
	        /// <summary>
	        /// buId(租户id)
	        /// </summary>
	        [XmlElement("bu_id")]
	        public string BuId { get; set; }
	
	        /// <summary>
	        /// 钉钉corpId
	        /// </summary>
	        [XmlElement("ding_corp_id")]
	        public string DingCorpId { get; set; }
	
	        /// <summary>
	        /// 事件变更内容，json格式
	        /// </summary>
	        [XmlElement("event_body")]
	        public string EventBody { get; set; }
	
	        /// <summary>
	        /// 事件code，参考com.dingtalk.customerservice.common.EventBizTypeEnum
	        /// </summary>
	        [XmlElement("event_code")]
	        public string EventCode { get; set; }
	
	        /// <summary>
	        /// 事件的唯一性id，用于幂等
	        /// </summary>
	        [XmlElement("event_id")]
	        public string EventId { get; set; }
	
	        /// <summary>
	        /// 实例id
	        /// </summary>
	        [XmlElement("open_instance_id")]
	        public string OpenInstanceId { get; set; }
	
	        /// <summary>
	        /// 1，智能客服；1001，经济体版本
	        /// </summary>
	        [XmlElement("production_type")]
	        public Nullable<long> ProductionType { get; set; }
	
	        /// <summary>
	        /// 事件来源，com.dingtalk.customerservice.common.SourceEnum
	        /// </summary>
	        [XmlElement("source")]
	        public string Source { get; set; }
}

        #endregion
    }
}
