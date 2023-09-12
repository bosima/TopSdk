using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduGuardianGetResponse.
    /// </summary>
    public class OapiEduGuardianGetResponse : DingTalkResponse
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
        public GuardianResponeDomain Result { get; set; }

        /// <summary>
        /// 成功状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// RelationsDomain Data Structure.
/// </summary>
[Serializable]

public class RelationsDomain : TopObject
{
	        /// <summary>
	        /// fafa\\
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// fafa\\
	        /// </summary>
	        [XmlElement("relation")]
	        public string Relation { get; set; }
	
	        /// <summary>
	        /// fafa\\
	        /// </summary>
	        [XmlElement("student_userid")]
	        public string StudentUserid { get; set; }
}

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
	        /// 关系类型（M妈妈，D爸爸，O其他）
	        /// </summary>
	        [XmlElement("relation")]
	        public string Relation { get; set; }
	
	        /// <summary>
	        /// fdaf
	        /// </summary>
	        [XmlArray("relations")]
	        [XmlArrayItem("relations")]
	        public List<RelationsDomain> Relations { get; set; }
	
	        /// <summary>
	        /// 学生ID
	        /// </summary>
	        [XmlElement("student_userid")]
	        public string StudentUserid { get; set; }
}

    }
}
