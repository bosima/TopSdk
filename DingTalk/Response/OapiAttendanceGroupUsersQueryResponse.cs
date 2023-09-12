using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupUsersQueryResponse.
    /// </summary>
    public class OapiAttendanceGroupUsersQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

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
	        public string HasMore { get; set; }
	
	        /// <summary>
	        /// 用户列表
	        /// </summary>
	        [XmlArray("user_list")]
	        [XmlArrayItem("string")]
	        public List<string> UserList { get; set; }
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
