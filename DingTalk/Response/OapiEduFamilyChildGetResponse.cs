using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduFamilyChildGetResponse.
    /// </summary>
    public class OapiEduFamilyChildGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果数据
        /// </summary>
        [XmlElement("result")]
        public ChildDtoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// BindStudentDomain Data Structure.
/// </summary>
[Serializable]

public class BindStudentDomain : TopObject
{
	        /// <summary>
	        /// 班级ID
	        /// </summary>
	        [XmlElement("class_id")]
	        public string ClassId { get; set; }
	
	        /// <summary>
	        /// 学校CorpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 孩子学段年级对应学段元数据的年级一级
	        /// </summary>
	        [XmlElement("period_code")]
	        public string PeriodCode { get; set; }
	
	        /// <summary>
	        /// 孩子学校的userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// ChildDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ChildDtoDomain : TopObject
{
	        /// <summary>
	        /// 头像
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// 孩子信息
	        /// </summary>
	        [XmlArray("bind_students")]
	        [XmlArrayItem("bind_student")]
	        public List<BindStudentDomain> BindStudents { get; set; }
	
	        /// <summary>
	        /// 孩子nick
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 孩子对应的openId 已废弃
	        /// </summary>
	        [XmlElement("open_id")]
	        public string OpenId { get; set; }
	
	        /// <summary>
	        /// 孩子对应的unionId
	        /// </summary>
	        [XmlElement("unionId")]
	        public string UnionId { get; set; }
	
	        /// <summary>
	        /// 孩子家庭userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
