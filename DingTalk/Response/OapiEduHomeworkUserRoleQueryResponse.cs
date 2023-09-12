using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduHomeworkUserRoleQueryResponse.
    /// </summary>
    public class OapiEduHomeworkUserRoleQueryResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 是否家长
	        /// </summary>
	        [XmlElement("guardian")]
	        public bool Guardian { get; set; }
	
	        /// <summary>
	        /// 是否班主任
	        /// </summary>
	        [XmlElement("headmaster")]
	        public bool Headmaster { get; set; }
	
	        /// <summary>
	        /// 是否学生
	        /// </summary>
	        [XmlElement("student")]
	        public bool Student { get; set; }
	
	        /// <summary>
	        /// 学生列表
	        /// </summary>
	        [XmlArray("students")]
	        [XmlArrayItem("string")]
	        public List<string> Students { get; set; }
	
	        /// <summary>
	        /// 是否老师
	        /// </summary>
	        [XmlElement("teacher")]
	        public bool Teacher { get; set; }
	
	        /// <summary>
	        /// 用户角色
	        /// </summary>
	        [XmlElement("user_role")]
	        public string UserRole { get; set; }
}

    }
}
