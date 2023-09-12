using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.connector.trigger.send_v2
    /// </summary>
    public class OapiConnectorTriggerSendV2Request : BaseDingTalkRequest<DingTalk.Api.Response.OapiConnectorTriggerSendV2Response>
    {
        /// <summary>
        /// 触发消息请求结构体
        /// </summary>
        public string TriggerMsgRequest { get; set; }

        public TriggerMsgRequestDomain TriggerMsgRequest_ { set { this.TriggerMsgRequest = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.connector.trigger.send_v2";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("trigger_msg_request", this.TriggerMsgRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("trigger_msg_request", this.TriggerMsgRequest);
        }

	/// <summary>
/// TriggerMsgDataDomain Data Structure.
/// </summary>
[Serializable]

public class TriggerMsgDataDomain : TopObject
{
	        /// <summary>
	        /// 业务触发时间
	        /// </summary>
	        [XmlElement("dd_event_time")]
	        public Nullable<DateTime> DdEventTime { get; set; }
	
	        /// <summary>
	        /// 触发数据
	        /// </summary>
	        [XmlElement("json_data")]
	        public string JsonData { get; set; }
	
	        /// <summary>
	        /// 触发动作ID
	        /// </summary>
	        [XmlElement("trigger_id")]
	        public string TriggerId { get; set; }
}

	/// <summary>
/// TriggerMsgRequestDomain Data Structure.
/// </summary>
[Serializable]

public class TriggerMsgRequestDomain : TopObject
{
	        /// <summary>
	        /// 是否为测试属性
	        /// </summary>
	        [XmlElement("test")]
	        public Nullable<bool> Test { get; set; }
	
	        /// <summary>
	        /// 触发动作数据
	        /// </summary>
	        [XmlArray("trigger_msg_data_list")]
	        [XmlArrayItem("trigger_msg_data")]
	        public List<TriggerMsgDataDomain> TriggerMsgDataList { get; set; }
}

        #endregion
    }
}
