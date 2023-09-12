using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.customerservice.status.update
    /// </summary>
    public class OapiCustomerserviceStatusUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCustomerserviceStatusUpdateResponse>
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string StatusChange { get; set; }

        public ServiceStatusChangeDtoDomain StatusChange_ { set { this.StatusChange = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.customerservice.status.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("status_change", this.StatusChange);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("status_change", this.StatusChange);
        }

	/// <summary>
/// ServiceStatusChangeDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ServiceStatusChangeDtoDomain : TopObject
{
	        /// <summary>
	        /// 客服所在bu
	        /// </summary>
	        [XmlElement("bu_id")]
	        public string BuId { get; set; }
	
	        /// <summary>
	        /// 钉钉的企业id
	        /// </summary>
	        [XmlElement("ding_corp_id")]
	        public string DingCorpId { get; set; }
	
	        /// <summary>
	        /// 实例id
	        /// </summary>
	        [XmlElement("open_instance_id")]
	        public string OpenInstanceId { get; set; }
	
	        /// <summary>
	        /// 原始状态
	        /// </summary>
	        [XmlElement("origin_status")]
	        public Nullable<long> OriginStatus { get; set; }
	
	        /// <summary>
	        /// 1，智能客服；1001，经济体版本
	        /// </summary>
	        [XmlElement("production_type")]
	        public Nullable<long> ProductionType { get; set; }
	
	        /// <summary>
	        /// 客服id
	        /// </summary>
	        [XmlElement("service_id")]
	        public string ServiceId { get; set; }
	
	        /// <summary>
	        /// 客服所在系统
	        /// </summary>
	        [XmlElement("source")]
	        public string Source { get; set; }
	
	        /// <summary>
	        /// 目标状态
	        /// </summary>
	        [XmlElement("target_status")]
	        public Nullable<long> TargetStatus { get; set; }
}

        #endregion
    }
}
