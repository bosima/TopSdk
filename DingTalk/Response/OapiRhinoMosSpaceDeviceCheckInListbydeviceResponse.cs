using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosSpaceDeviceCheckInListbydeviceResponse.
    /// </summary>
    public class OapiRhinoMosSpaceDeviceCheckInListbydeviceResponse : DingTalkResponse
    {
        /// <summary>
        /// error_code
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("prod_workstation_device_check_dto")]
        public List<ProdWorkstationDeviceCheckDtoDomain> Model { get; set; }

	/// <summary>
/// ProdWorkstationDeviceCheckDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ProdWorkstationDeviceCheckDtoDomain : TopObject
{
	        /// <summary>
	        /// 登入时间
	        /// </summary>
	        [XmlElement("check_in_time")]
	        public string CheckInTime { get; set; }
	
	        /// <summary>
	        /// 登出时间
	        /// </summary>
	        [XmlElement("check_out_time")]
	        public string CheckOutTime { get; set; }
	
	        /// <summary>
	        /// 登入登出状态
	        /// </summary>
	        [XmlElement("check_status")]
	        public string CheckStatus { get; set; }
	
	        /// <summary>
	        /// device_id
	        /// </summary>
	        [XmlElement("device_id")]
	        public long DeviceId { get; set; }
	
	        /// <summary>
	        /// 站位code
	        /// </summary>
	        [XmlElement("prod_workstation_code")]
	        public string ProdWorkstationCode { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
}

    }
}
