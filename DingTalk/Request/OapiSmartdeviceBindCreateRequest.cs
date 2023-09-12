using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.bind.create
    /// </summary>
    public class OapiSmartdeviceBindCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceBindCreateResponse>
    {
        /// <summary>
        /// 设备请求信息
        /// </summary>
        public string DeviceBindReqVo { get; set; }

        public DeviceBindReqVoDomain DeviceBindReqVo_ { set { this.DeviceBindReqVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.bind.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_bind_req_vo", this.DeviceBindReqVo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_bind_req_vo", this.DeviceBindReqVo);
        }

	/// <summary>
/// DeviceBindReqVoDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceBindReqVoDomain : TopObject
{
	        /// <summary>
	        /// 设备在3方的唯一标识
	        /// </summary>
	        [XmlElement("biz_device_identity")]
	        public string BizDeviceIdentity { get; set; }
	
	        /// <summary>
	        /// 设备MAC
	        /// </summary>
	        [XmlElement("device_mac")]
	        public string DeviceMac { get; set; }
	
	        /// <summary>
	        /// 产品型号ID
	        /// </summary>
	        [XmlElement("device_service_id")]
	        public Nullable<long> DeviceServiceId { get; set; }
	
	        /// <summary>
	        /// 设备SN
	        /// </summary>
	        [XmlElement("device_sn")]
	        public string DeviceSn { get; set; }
	
	        /// <summary>
	        /// 设备昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
}

        #endregion
    }
}
