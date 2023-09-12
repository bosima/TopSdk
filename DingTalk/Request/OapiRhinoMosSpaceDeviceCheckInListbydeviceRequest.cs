using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.space.device.check.in.listbydevice
    /// </summary>
    public class OapiRhinoMosSpaceDeviceCheckInListbydeviceRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosSpaceDeviceCheckInListbydeviceResponse>
    {
        /// <summary>
        /// request
        /// </summary>
        public string Request { get; set; }

        public WorkstationDeviceListReqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.space.device.check.in.listbydevice";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// WorkstationDeviceListReqDomain Data Structure.
/// </summary>
[Serializable]

public class WorkstationDeviceListReqDomain : TopObject
{
	        /// <summary>
	        /// 设备id列表
	        /// </summary>
	        [XmlArray("device_ids")]
	        [XmlArrayItem("number")]
	        public List<string> DeviceIds { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
