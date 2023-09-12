using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiReportSimplelistResponse.
    /// </summary>
    public class OapiReportSimplelistResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public PageVoDomain Result { get; set; }

	/// <summary>
/// ReportOapiVoDomain Data Structure.
/// </summary>
[Serializable]

public class ReportOapiVoDomain : TopObject
{
	        /// <summary>
	        /// 日志创建时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public long CreateTime { get; set; }
	
	        /// <summary>
	        /// 日志创建人userid
	        /// </summary>
	        [XmlElement("creator_id")]
	        public string CreatorId { get; set; }
	
	        /// <summary>
	        /// 日志创建人
	        /// </summary>
	        [XmlElement("creator_name")]
	        public string CreatorName { get; set; }
	
	        /// <summary>
	        /// 部门
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 日志唯一id
	        /// </summary>
	        [XmlElement("report_id")]
	        public string ReportId { get; set; }
	
	        /// <summary>
	        /// 日志模板名
	        /// </summary>
	        [XmlElement("template_name")]
	        public string TemplateName { get; set; }
}

	/// <summary>
/// PageVoDomain Data Structure.
/// </summary>
[Serializable]

public class PageVoDomain : TopObject
{
	        /// <summary>
	        /// 日志列表
	        /// </summary>
	        [XmlArray("data_list")]
	        [XmlArrayItem("report_oapi_vo")]
	        public List<ReportOapiVoDomain> DataList { get; set; }
	
	        /// <summary>
	        /// 是否还有下一页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// nextCursor
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
	
	        /// <summary>
	        /// 分页大小
	        /// </summary>
	        [XmlElement("size")]
	        public long Size { get; set; }
}

    }
}
