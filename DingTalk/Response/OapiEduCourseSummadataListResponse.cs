using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCourseSummadataListResponse.
    /// </summary>
    public class OapiEduCourseSummadataListResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("result")]
        public PageQueryResponseDomain Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CourseSummaryDataDTODomain Data Structure.
/// </summary>
[Serializable]

public class CourseSummaryDataDTODomain : TopObject
{
	        /// <summary>
	        /// 数据类别业务唯一键
	        /// </summary>
	        [XmlElement("category_biz_key")]
	        public string CategoryBizKey { get; set; }
	
	        /// <summary>
	        /// 数据类别编码
	        /// </summary>
	        [XmlElement("category_code")]
	        public string CategoryCode { get; set; }
	
	        /// <summary>
	        /// 课程编码
	        /// </summary>
	        [XmlElement("course_code")]
	        public string CourseCode { get; set; }
	
	        /// <summary>
	        /// 数据（key：数据因子编码，value： 对应的数据）
	        /// </summary>
	        [XmlElement("data")]
	        public string Data { get; set; }
}

	/// <summary>
/// PageQueryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class PageQueryResponseDomain : TopObject
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
	        [XmlArrayItem("course_summary_data_d_t_o")]
	        public List<CourseSummaryDataDTODomain> List { get; set; }
	
	        /// <summary>
	        /// 表示下一次分页的游标，如果next_corsor为null或者has_more为false，表示没有更多的分页数据
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
