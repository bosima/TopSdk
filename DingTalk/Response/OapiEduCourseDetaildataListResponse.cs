using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCourseDetaildataListResponse.
    /// </summary>
    public class OapiEduCourseDetaildataListResponse : DingTalkResponse
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
/// CourseDetailDataDTODomain Data Structure.
/// </summary>
[Serializable]

public class CourseDetailDataDTODomain : TopObject
{
	        /// <summary>
	        /// 数据业务唯一键（比如标识具体哪一次进入教室）
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
	        /// 数据因子编码
	        /// </summary>
	        [XmlElement("factor_code")]
	        public string FactorCode { get; set; }
	
	        /// <summary>
	        /// 用户组织ID
	        /// </summary>
	        [XmlElement("user_cropid")]
	        public string UserCropid { get; set; }
	
	        /// <summary>
	        /// 用户ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 数据值（比如进入教室的时间戳）
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
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
	        [XmlArrayItem("course_detail_data_d_t_o")]
	        public List<CourseDetailDataDTODomain> List { get; set; }
	
	        /// <summary>
	        /// 表示下一次分页的游标，如果next_corsor为null或者has_more为false，表示没有更多的分页数据
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
