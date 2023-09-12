using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupPositionsQueryResponse.
    /// </summary>
    public class OapiAttendanceGroupPositionsQueryResponse : DingTalkResponse
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
	        /// 纬度(支持6位小数)
	        /// </summary>
	        [XmlElement("latitude")]
	        public string Latitude { get; set; }
	
	        /// <summary>
	        /// 经度(支持6位小数)
	        /// </summary>
	        [XmlElement("longitude")]
	        public string Longitude { get; set; }
	
	        /// <summary>
	        /// 打卡位置允许的偏移量
	        /// </summary>
	        [XmlElement("offset")]
	        public long Offset { get; set; }
	
	        /// <summary>
	        /// positionKey
	        /// </summary>
	        [XmlElement("position_key")]
	        public string PositionKey { get; set; }
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
	        /// position列表
	        /// </summary>
	        [XmlArray("position_list")]
	        [XmlArrayItem("position")]
	        public List<PositionDomain> PositionList { get; set; }
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
	        /// 查询结果
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
