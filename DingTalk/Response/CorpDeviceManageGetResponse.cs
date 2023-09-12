using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpDeviceManageGetResponse.
    /// </summary>
    public class CorpDeviceManageGetResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// OpenDeviceDetailVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenDeviceDetailVoDomain : TopObject
{
	        /// <summary>
	        /// 设备ID
	        /// </summary>
	        [XmlElement("device_id")]
	        public string DeviceId { get; set; }
	
	        /// <summary>
	        /// 设备Mac地址
	        /// </summary>
	        [XmlElement("device_mac")]
	        public string DeviceMac { get; set; }
	
	        /// <summary>
	        /// 设备类型名称
	        /// </summary>
	        [XmlElement("device_type_name")]
	        public string DeviceTypeName { get; set; }
	
	        /// <summary>
	        /// 设备昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 设备硬件版本号
	        /// </summary>
	        [XmlElement("version")]
	        public string Version { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlElement("result")]
	        public OpenDeviceDetailVoDomain Result { get; set; }
	
	        /// <summary>
	        /// 请求是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
