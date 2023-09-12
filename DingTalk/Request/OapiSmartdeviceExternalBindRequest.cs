using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartdevice.external.bind
    /// </summary>
    public class OapiSmartdeviceExternalBindRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartdeviceExternalBindResponse>
    {
        /// <summary>
        /// 设备请求信息
        /// </summary>
        public string DeviceBindReqVo { get; set; }

        public DeviceBindReqVoDomain DeviceBindReqVo_ { set { this.DeviceBindReqVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartdevice.external.bind";
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
	        /// 设备名称
	        /// </summary>
	        [XmlElement("dn")]
	        public string Dn { get; set; }
	
	        /// <summary>
	        /// 扩展信息
	        /// </summary>
	        [XmlElement("ext")]
	        public string Ext { get; set; }
	
	        /// <summary>
	        /// mac地址
	        /// </summary>
	        [XmlElement("mac")]
	        public string Mac { get; set; }
	
	        /// <summary>
	        /// 设备昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 外部设备id
	        /// </summary>
	        [XmlElement("outid")]
	        public string Outid { get; set; }
	
	        /// <summary>
	        /// 产品key
	        /// </summary>
	        [XmlElement("pk")]
	        public string Pk { get; set; }
	
	        /// <summary>
	        /// sn地址
	        /// </summary>
	        [XmlElement("sn")]
	        public string Sn { get; set; }
}

        #endregion
    }
}
