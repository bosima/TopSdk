using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupWifisAddResponse.
    /// </summary>
    public class OapiAttendanceGroupWifisAddResponse : DingTalkResponse
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
	        /// 业务方wifiId
	        /// </summary>
	        [XmlElement("foreign_id")]
	        public string ForeignId { get; set; }
	
	        /// <summary>
	        /// mac地址
	        /// </summary>
	        [XmlElement("mac_addr")]
	        public string MacAddr { get; set; }
	
	        /// <summary>
	        /// mac名称
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
/// ErrorInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ErrorInfoDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 失败列表
	        /// </summary>
	        [XmlArray("failure_list")]
	        [XmlArrayItem("wifi")]
	        public List<WifiDomain> FailureList { get; set; }
	
	        /// <summary>
	        /// 错误描述
	        /// </summary>
	        [XmlElement("msg")]
	        public string Msg { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 错误列表
	        /// </summary>
	        [XmlArray("error_info_list")]
	        [XmlArrayItem("error_info")]
	        public List<ErrorInfoDomain> ErrorInfoList { get; set; }
	
	        /// <summary>
	        /// 成功列表
	        /// </summary>
	        [XmlArray("success_list")]
	        [XmlArrayItem("wifi")]
	        public List<WifiDomain> SuccessList { get; set; }
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
	        /// 添加wifi结果
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
