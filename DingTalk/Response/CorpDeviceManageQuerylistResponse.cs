using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpDeviceManageQuerylistResponse.
    /// </summary>
    public class CorpDeviceManageQuerylistResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// OpenDeviceVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenDeviceVoDomain : TopObject
{
	        /// <summary>
	        /// 设备头像
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// 设备ID
	        /// </summary>
	        [XmlElement("device_id")]
	        public string DeviceId { get; set; }
	
	        /// <summary>
	        /// 设备MAC地址
	        /// </summary>
	        [XmlElement("device_mac")]
	        public string DeviceMac { get; set; }
	
	        /// <summary>
	        /// 设备SN
	        /// </summary>
	        [XmlElement("device_sn")]
	        public string DeviceSn { get; set; }
	
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
	        /// 设备在线状态{1:在线，0:不在线}
	        /// </summary>
	        [XmlElement("on_line_status")]
	        public long OnLineStatus { get; set; }
}

	/// <summary>
/// PageVoDomain Data Structure.
/// </summary>
[Serializable]

public class PageVoDomain : TopObject
{
	        /// <summary>
	        /// 设备列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("open_device_vo")]
	        public List<OpenDeviceVoDomain> List { get; set; }
	
	        /// <summary>
	        /// 下次拉取列表的游标，如果为Null，代表没有数据了
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
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
	        /// 返回的Page对象
	        /// </summary>
	        [XmlElement("result")]
	        public PageVoDomain Result { get; set; }
	
	        /// <summary>
	        /// request是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
