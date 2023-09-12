using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupWifisQueryResponse.
    /// </summary>
    public class OapiAttendanceGroupWifisQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// WifiDomain Data Structure.
/// </summary>
[Serializable]

public class WifiDomain : TopObject
{
	        /// <summary>
	        /// mac地址
	        /// </summary>
	        [XmlElement("mac_addr")]
	        public string MacAddr { get; set; }
	
	        /// <summary>
	        /// wifi名称
	        /// </summary>
	        [XmlElement("ssid")]
	        public string Ssid { get; set; }
	
	        /// <summary>
	        /// wifiKey
	        /// </summary>
	        [XmlElement("wifi_key")]
	        public string WifiKey { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 是否更多
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// wifi列表
	        /// </summary>
	        [XmlArray("wifi_list")]
	        [XmlArrayItem("wifi")]
	        public List<WifiDomain> WifiList { get; set; }
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
	        [XmlElement("errcode")]
	        public long Errcode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("errmsg")]
	        public string Errmsg { get; set; }
	
	        /// <summary>
	        /// 查询wifi列表结果
	        /// </summary>
	        [XmlElement("result")]
	        public ResultDomain Result { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
