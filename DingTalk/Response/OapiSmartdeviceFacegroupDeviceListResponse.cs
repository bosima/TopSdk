using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceFacegroupDeviceListResponse.
    /// </summary>
    public class OapiSmartdeviceFacegroupDeviceListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代号
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 符合条件的当前页数据
        /// </summary>
        [XmlElement("result")]
        public PagedListDomain Result { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// DeviceDtoDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceDtoDomain : TopObject
{
	        /// <summary>
	        /// 设备id
	        /// </summary>
	        [XmlElement("device_id")]
	        public long DeviceId { get; set; }
	
	        /// <summary>
	        /// 设备名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 在线是否在线
	        /// </summary>
	        [XmlElement("online")]
	        public bool Online { get; set; }
	
	        /// <summary>
	        /// 是否启用识别（查询已绑定记录时有效）
	        /// </summary>
	        [XmlElement("status")]
	        public bool Status { get; set; }
	
	        /// <summary>
	        /// 设备类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 是否已被使用（含被本组关联）
	        /// </summary>
	        [XmlElement("used")]
	        public bool Used { get; set; }
}

	/// <summary>
/// PagedListDomain Data Structure.
/// </summary>
[Serializable]

public class PagedListDomain : TopObject
{
	        /// <summary>
	        /// 游标，下一次请求需要传入的下一次请求时需传入的游标值
	        /// </summary>
	        [XmlElement("cursor")]
	        public long Cursor { get; set; }
	
	        /// <summary>
	        /// 是否还有下一页数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 符合条件的设备
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("device_dto")]
	        public List<DeviceDtoDomain> Items { get; set; }
}

    }
}
