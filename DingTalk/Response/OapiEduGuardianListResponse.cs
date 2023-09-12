using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduGuardianListResponse.
    /// </summary>
    public class OapiEduGuardianListResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("result")]
        public PageResultDomain Result { get; set; }

        /// <summary>
        /// 成功状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// GuardianResponeDomain Data Structure.
/// </summary>
[Serializable]

public class GuardianResponeDomain : TopObject
{
	        /// <summary>
	        /// 家长ID
	        /// </summary>
	        [XmlElement("guardian_userid")]
	        public string GuardianUserid { get; set; }
	
	        /// <summary>
	        /// 关系名称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 关系（F爸爸、M妈妈、O其他）
	        /// </summary>
	        [XmlElement("relation")]
	        public string Relation { get; set; }
	
	        /// <summary>
	        /// 学生ID
	        /// </summary>
	        [XmlElement("student_userid")]
	        public string StudentUserid { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否存在下一页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("guardian_respone")]
	        public List<GuardianResponeDomain> List { get; set; }
	
	        /// <summary>
	        /// 分页游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
