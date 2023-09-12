using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduClassStudentidGetResponse.
    /// </summary>
    public class OapiEduClassStudentidGetResponse : DingTalkResponse
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
        /// 数据
        /// </summary>
        [XmlElement("result")]
        public OpenEduSelectStudentIdResponseDomain Result { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenEduSelectStudentIdResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduSelectStudentIdResponseDomain : TopObject
{
	        /// <summary>
	        /// 班级id
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 学生id列表
	        /// </summary>
	        [XmlArray("student_ids")]
	        [XmlArrayItem("string")]
	        public List<string> StudentIds { get; set; }
}

    }
}
