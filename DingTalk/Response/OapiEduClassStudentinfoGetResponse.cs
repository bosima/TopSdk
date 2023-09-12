using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduClassStudentinfoGetResponse.
    /// </summary>
    public class OapiEduClassStudentinfoGetResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public OpenStudentSelectDtoDomain Result { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenPatriarchSelectDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPatriarchSelectDtoDomain : TopObject
{
	        /// <summary>
	        /// 头像
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// 是否激活钉钉
	        /// </summary>
	        [XmlElement("is_active")]
	        public bool IsActive { get; set; }
	
	        /// <summary>
	        /// 家长姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 关系key
	        /// </summary>
	        [XmlElement("relation")]
	        public string Relation { get; set; }
	
	        /// <summary>
	        /// 关系名称
	        /// </summary>
	        [XmlElement("relation_name")]
	        public string RelationName { get; set; }
	
	        /// <summary>
	        /// 家长id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenStudentSelectDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenStudentSelectDtoDomain : TopObject
{
	        /// <summary>
	        /// 头像
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// 班级id
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 家长列表
	        /// </summary>
	        [XmlArray("guardians")]
	        [XmlArrayItem("open_patriarch_select_dto")]
	        public List<OpenPatriarchSelectDtoDomain> Guardians { get; set; }
	
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 学号
	        /// </summary>
	        [XmlElement("student_num")]
	        public string StudentNum { get; set; }
	
	        /// <summary>
	        /// 学生id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
