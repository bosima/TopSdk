using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.device.querybyid
    /// </summary>
    public class OapiSmartdeviceDeviceQuerybyidRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceDeviceQuerybyidResponse>
    {
        /// <summary>
        /// 设备查询对象
        /// </summary>
        public string DeviceQueryVo { get; set; }

        public DeviceQueryVoDomain DeviceQueryVo_ { set { this.DeviceQueryVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.device.querybyid";
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
            RequestValidator.ValidateRequired("device_query_vo", this.DeviceQueryVo);
        }

	/// <summary>
/// DeviceQueryVoDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceQueryVoDomain : TopObject
{
	        /// <summary>
	        /// 设备id
	        /// </summary>
	        [XmlElement("device_id")]
	        public string DeviceId { get; set; }
}

        #endregion
    }
}
