using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupPositionsAddResponse.
    /// </summary>
    public class OapiAttendanceGroupPositionsAddResponse : DingTalkResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// PositionDomain Data Structure.
/// </summary>
[Serializable]

public class PositionDomain : TopObject
{
	        /// <summary>
	        /// 地址描述
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 业务方positionId
	        /// </summary>
	        [XmlElement("foreign_id")]
	        public string ForeignId { get; set; }
	
	        /// <summary>
	        /// 经度(支持6位小数)
	        /// </summary>
	        [XmlElement("latitude")]
	        public string Latitude { get; set; }
	
	        /// <summary>
	        /// 纬度(支持6位小数)
	        /// </summary>
	        [XmlElement("longitude")]
	        public string Longitude { get; set; }
	
	        /// <summary>
	        /// positionKey，失败时为空
	        /// </summary>
	        [XmlElement("position_key")]
	        public string PositionKey { get; set; }
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
	        [XmlArrayItem("position")]
	        public List<PositionDomain> FailureList { get; set; }
	
	        /// <summary>
	        /// 错误信息
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
	        [XmlArrayItem("position")]
	        public List<PositionDomain> SuccessList { get; set; }
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
	        /// 结果
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
