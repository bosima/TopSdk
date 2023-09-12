using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.batchevent.post
    /// </summary>
    public class OapiSmartdeviceBatcheventPostRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceBatcheventPostResponse>
    {
        /// <summary>
        /// 自动创建
        /// </summary>
        public string DeviceEventVos { get; set; }

        public List<DeviceEventVoDomain> DeviceEventVos_ { set { this.DeviceEventVos = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.batchevent.post";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_event_vos", this.DeviceEventVos);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("device_event_vos", this.DeviceEventVos, 999);
        }

	/// <summary>
/// DeviceEventVoDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceEventVoDomain : TopObject
{
	        /// <summary>
	        /// json格式的数据体
	        /// </summary>
	        [XmlElement("data")]
	        public string Data { get; set; }
	
	        /// <summary>
	        /// 设备名称
	        /// </summary>
	        [XmlElement("dn")]
	        public string Dn { get; set; }
	
	        /// <summary>
	        /// 产品key
	        /// </summary>
	        [XmlElement("pk")]
	        public string Pk { get; set; }
	
	        /// <summary>
	        /// 事件对应的topic
	        /// </summary>
	        [XmlElement("topic")]
	        public string Topic { get; set; }
}

        #endregion
    }
}
