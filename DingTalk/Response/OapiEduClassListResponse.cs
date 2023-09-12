using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduClassListResponse.
    /// </summary>
    public class OapiEduClassListResponse : DingTalkResponse
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
/// ClassResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ClassResponseDomain : TopObject
{
	        /// <summary>
	        /// 校区ID
	        /// </summary>
	        [XmlElement("campus_id")]
	        public long CampusId { get; set; }
	
	        /// <summary>
	        /// 班级ID
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 每个年级下班级级数（1班为1,2班为2）
	        /// </summary>
	        [XmlElement("class_level")]
	        public long ClassLevel { get; set; }
	
	        /// <summary>
	        /// 年级ID
	        /// </summary>
	        [XmlElement("grade_id")]
	        public long GradeId { get; set; }
	
	        /// <summary>
	        /// 年级级数（一年级为1，二年级为2）
	        /// </summary>
	        [XmlElement("grade_level")]
	        public long GradeLevel { get; set; }
	
	        /// <summary>
	        /// 班级名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 别名
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 学段ID
	        /// </summary>
	        [XmlElement("period_id")]
	        public long PeriodId { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否有分页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("class_response")]
	        public List<ClassResponseDomain> List { get; set; }
	
	        /// <summary>
	        /// 分页游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
