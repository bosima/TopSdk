using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGroupMemberListResponse.
    /// </summary>
    public class OapiAttendanceGroupMemberListResponse : DingTalkResponse
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
        /// 人员列表
        /// </summary>
        [XmlElement("result")]
        public PageResultDomain Result { get; set; }

        /// <summary>
        /// 成功标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TopGroupMemberVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopGroupMemberVoDomain : TopObject
{
	        /// <summary>
	        /// 0表示需要考勤，1表示无需考勤人员
	        /// </summary>
	        [XmlElement("atc_flag")]
	        public string AtcFlag { get; set; }
	
	        /// <summary>
	        /// 成员id，可以是userId或deptId
	        /// </summary>
	        [XmlElement("member_id")]
	        public string MemberId { get; set; }
	
	        /// <summary>
	        /// 0表示员工，1表示部门
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 游标
	        /// </summary>
	        [XmlElement("cursor")]
	        public long Cursor { get; set; }
	
	        /// <summary>
	        /// 是否还有
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 人员userId列表
	        /// </summary>
	        [XmlArray("result")]
	        [XmlArrayItem("top_group_member_vo")]
	        public List<TopGroupMemberVoDomain> Result { get; set; }
}

    }
}
