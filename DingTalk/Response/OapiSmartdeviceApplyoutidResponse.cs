using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceApplyoutidResponse.
    /// </summary>
    public class OapiSmartdeviceApplyoutidResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误编码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回值对象
        /// </summary>
        [XmlElement("result")]
        public OutDeviceIdVoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OutDeviceIdVoDomain Data Structure.
/// </summary>
[Serializable]

public class OutDeviceIdVoDomain : TopObject
{
	        /// <summary>
	        /// 外部设备id
	        /// </summary>
	        [XmlElement("outdid")]
	        public string Outdid { get; set; }
}

    }
}
