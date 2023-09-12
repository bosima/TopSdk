using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.event.post
    /// </summary>
    public class OapiSmartdeviceEventPostRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceEventPostResponse>
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string DeviceEventVo { get; set; }

        public DeviceEventVoDomain DeviceEventVo_ { set { this.DeviceEventVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.event.post";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_event_vo", this.DeviceEventVo);
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
