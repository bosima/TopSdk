using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiReportTemplateListbyuseridResponse.
    /// </summary>
    public class OapiReportTemplateListbyuseridResponse : DingTalkResponse
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
        public HomePageReportTemplateVoDomain Result { get; set; }

	/// <summary>
/// ReportTemplateTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ReportTemplateTopVoDomain : TopObject
{
	        /// <summary>
	        /// 模板图标url
	        /// </summary>
	        [XmlElement("icon_url")]
	        public string IconUrl { get; set; }
	
	        /// <summary>
	        /// 日志模板名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 模板唯一标识
	        /// </summary>
	        [XmlElement("report_code")]
	        public string ReportCode { get; set; }
	
	        /// <summary>
	        /// 模板的url
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// HomePageReportTemplateVoDomain Data Structure.
/// </summary>
[Serializable]

public class HomePageReportTemplateVoDomain : TopObject
{
	        /// <summary>
	        /// 下一次分页调用的offset值，当返回结果里没有nextCursor时，表示分页结束
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("template_list")]
	        [XmlArrayItem("report_template_top_vo")]
	        public List<ReportTemplateTopVoDomain> TemplateList { get; set; }
}

    }
}
