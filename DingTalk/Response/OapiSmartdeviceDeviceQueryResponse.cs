using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceDeviceQueryResponse.
    /// </summary>
    public class OapiSmartdeviceDeviceQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public DeviceDetailVODomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// DeviceDetailVODomain Data Structure.
/// </summary>
[Serializable]

public class DeviceDetailVODomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 设备id
	        /// </summary>
	        [XmlElement("device_id")]
	        public string DeviceId { get; set; }
	
	        /// <summary>
	        /// 设备mac
	        /// </summary>
	        [XmlElement("device_mac")]
	        public string DeviceMac { get; set; }
	
	        /// <summary>
	        /// 设备名称
	        /// </summary>
	        [XmlElement("device_name")]
	        public string DeviceName { get; set; }
	
	        /// <summary>
	        /// 备注信息
	        /// </summary>
	        [XmlElement("ext")]
	        public string Ext { get; set; }
	
	        /// <summary>
	        /// 设备nick
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 产品标识
	        /// </summary>
	        [XmlElement("pk")]
	        public string Pk { get; set; }
	
	        /// <summary>
	        /// 设备序列号
	        /// </summary>
	        [XmlElement("sn")]
	        public string Sn { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
