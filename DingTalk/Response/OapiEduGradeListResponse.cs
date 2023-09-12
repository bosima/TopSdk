using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduGradeListResponse.
    /// </summary>
    public class OapiEduGradeListResponse : DingTalkResponse
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
        [XmlArray("result")]
        [XmlArrayItem("grade_response")]
        public List<GradeResponseDomain> Result { get; set; }

        /// <summary>
        /// 成功状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// GradeResponseDomain Data Structure.
/// </summary>
[Serializable]

public class GradeResponseDomain : TopObject
{
	        /// <summary>
	        /// 校区ID
	        /// </summary>
	        [XmlElement("campus_id")]
	        public long CampusId { get; set; }
	
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
	        /// 年级名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 入学年份
	        /// </summary>
	        [XmlElement("start_year")]
	        public string StartYear { get; set; }
}

    }
}
