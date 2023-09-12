using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduHomeworkUserCourseQueryResponse.
    /// </summary>
    public class OapiEduHomeworkUserCourseQueryResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TemplateContentDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TemplateContentDtoDomain : TopObject
{
	        /// <summary>
	        /// 图片
	        /// </summary>
	        [XmlElement("photo")]
	        public string Photo { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 科目内容详情
	        /// </summary>
	        [XmlArray("contents")]
	        [XmlArrayItem("template_content_dto")]
	        public List<TemplateContentDtoDomain> Contents { get; set; }
}

    }
}
