using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.device.updatenick
    /// </summary>
    public class OapiSmartdeviceDeviceUpdatenickRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceDeviceUpdatenickResponse>
    {
        /// <summary>
        /// 昵称修改参数
        /// </summary>
        public string DeviceNickModifyVo { get; set; }

        public DeviceNickModifyVoDomain DeviceNickModifyVo_ { set { this.DeviceNickModifyVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.device.updatenick";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_nick_modify_vo", this.DeviceNickModifyVo);
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
/// DeviceNickModifyVoDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceNickModifyVoDomain : TopObject
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
	        /// 新的昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 产品标识
	        /// </summary>
	        [XmlElement("pk")]
	        public string Pk { get; set; }
}

        #endregion
    }
}
