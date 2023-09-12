using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.device.unbind
    /// </summary>
    public class OapiSmartdeviceDeviceUnbindRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceDeviceUnbindResponse>
    {
        /// <summary>
        /// 解绑参数
        /// </summary>
        public string DeviceUnbindVo { get; set; }

        public DeviceUnbindVoDomain DeviceUnbindVo_ { set { this.DeviceUnbindVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.device.unbind";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_unbind_vo", this.DeviceUnbindVo);
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
/// DeviceUnbindVoDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceUnbindVoDomain : TopObject
{
	        /// <summary>
	        /// 设备id，和设备名称不能同时为空
	        /// </summary>
	        [XmlElement("device_id")]
	        public string DeviceId { get; set; }
	
	        /// <summary>
	        /// 设备名称，和设备id不能同时为空
	        /// </summary>
	        [XmlElement("device_name")]
	        public string DeviceName { get; set; }
	
	        /// <summary>
	        /// 产品标识
	        /// </summary>
	        [XmlElement("pk")]
	        public string Pk { get; set; }
	
	        /// <summary>
	        /// 操作者id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
