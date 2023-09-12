using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.visitor.sendnotify
    /// </summary>
    public class OapiSmartdeviceVisitorSendnotifyRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceVisitorSendnotifyResponse>
    {
        /// <summary>
        /// 预约ID
        /// </summary>
        public string ReservationId { get; set; }

        /// <summary>
        /// 访客通知模型
        /// </summary>
        public string VisitorNotifyVo { get; set; }

        public VisitorNotifyVoDomain VisitorNotifyVo_ { set { this.VisitorNotifyVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.visitor.sendnotify";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("reservation_id", this.ReservationId);
            parameters.Add("visitor_notify_vo", this.VisitorNotifyVo);
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
/// VisitorNotifyVoDomain Data Structure.
/// </summary>
[Serializable]

public class VisitorNotifyVoDomain : TopObject
{
	        /// <summary>
	        /// 消息内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 设备ID
	        /// </summary>
	        [XmlElement("device_id")]
	        public Nullable<long> DeviceId { get; set; }
	
	        /// <summary>
	        /// 接待意见反馈
	        /// </summary>
	        [XmlElement("feedback")]
	        public string Feedback { get; set; }
	
	        /// <summary>
	        /// 通知类型
	        /// </summary>
	        [XmlElement("notify_type")]
	        public Nullable<long> NotifyType { get; set; }
	
	        /// <summary>
	        /// 访客姓名
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 外部联系ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
