using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceBindCreateResponse.
    /// </summary>
    public class OapiSmartdeviceBindCreateResponse : DingTalkResponse
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
        public DeviceBindRespVoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// DeviceBindRespVoDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceBindRespVoDomain : TopObject
{
	        /// <summary>
	        /// 设备ID
	        /// </summary>
	        [XmlElement("device_id")]
	        public string DeviceId { get; set; }
}

    }
}
