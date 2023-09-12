using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.device.query
    /// </summary>
    public class OapiSmartdeviceDeviceQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceDeviceQueryResponse>
    {
        /// <summary>
        /// 设备查询对象
        /// </summary>
        public string DeviceQueryVo { get; set; }

        public DeviceQueryVoDomain DeviceQueryVo_ { set { this.DeviceQueryVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.device.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_query_vo", this.DeviceQueryVo);
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
/// DeviceQueryVoDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceQueryVoDomain : TopObject
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
	        /// 产品唯一编码
	        /// </summary>
	        [XmlElement("pk")]
	        public string Pk { get; set; }
}

        #endregion
    }
}
