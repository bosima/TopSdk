using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCourseParticipantListResponse.
    /// </summary>
    public class OapiEduCourseParticipantListResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ListCourseParticipantResponseDomain Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CourseParticipantVODomain Data Structure.
/// </summary>
[Serializable]

public class CourseParticipantVODomain : TopObject
{
	        /// <summary>
	        /// 参与方的组织CorpId
	        /// </summary>
	        [XmlElement("participant_corpid")]
	        public string ParticipantCorpid { get; set; }
	
	        /// <summary>
	        /// 参与方ID。participant_type=1时，participant_id表示用户ID；participant_type=2时，participant_id表示部门ID；participant_type=3时，participant_id表示组织ID；
	        /// </summary>
	        [XmlElement("participant_id")]
	        public string ParticipantId { get; set; }
	
	        /// <summary>
	        /// 参与方名称
	        /// </summary>
	        [XmlElement("participant_name")]
	        public string ParticipantName { get; set; }
	
	        /// <summary>
	        /// 参与方类型。1：用户、2：部门（对应家校通讯录中的班级、年级。详情请参考https://ding-doc.dingtalk.com/doc#/serverapi3/gga05a/z3y0h）、3：组织
	        /// </summary>
	        [XmlElement("participant_type")]
	        public string ParticipantType { get; set; }
	
	        /// <summary>
	        /// 参与方角色。student：学生、teacher：老师、guardian: 监护人
	        /// </summary>
	        [XmlElement("role")]
	        public string Role { get; set; }
}

	/// <summary>
/// ListCourseParticipantResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ListCourseParticipantResponseDomain : TopObject
{
	        /// <summary>
	        /// 表示是否还有更多的数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("course_participant_v_o")]
	        public List<CourseParticipantVODomain> List { get; set; }
	
	        /// <summary>
	        /// 表示下一次分页的游标，如果next_corsor为null或者has_more为false，表示没有更多的分页数据
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
