using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduRolesGetResponse.
    /// </summary>
    public class OapiEduRolesGetResponse : DingTalkResponse
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
        /// 请求数据块
        /// </summary>
        [XmlElement("result")]
        public QueryUserRolesResponseDomain Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// QueryUserRolesResponseDomain Data Structure.
/// </summary>
[Serializable]

public class QueryUserRolesResponseDomain : TopObject
{
	        /// <summary>
	        /// 非NULL列表;此员工在当前家校通讯录中的是班主任角色的班级列表
	        /// </summary>
	        [XmlArray("advisor")]
	        [XmlArrayItem("number")]
	        public List<long> Advisor { get; set; }
	
	        /// <summary>
	        /// 非NULL列表;此员工在当前家校通讯录中的是监护人角色的班级列表
	        /// </summary>
	        [XmlArray("guardian")]
	        [XmlArrayItem("number")]
	        public List<long> Guardian { get; set; }
	
	        /// <summary>
	        /// 非NULL列表;此员工在当前家校通讯录中的是学生角色的班级列表
	        /// </summary>
	        [XmlArray("student")]
	        [XmlArrayItem("number")]
	        public List<long> Student { get; set; }
	
	        /// <summary>
	        /// 非NULL列表;此员工在当前家校通讯录中的是老师角色的班级列表
	        /// </summary>
	        [XmlArray("teacher")]
	        [XmlArrayItem("number")]
	        public List<long> Teacher { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
