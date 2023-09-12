using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpReportListResponse.
    /// </summary>
    public class CorpReportListResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// JsonObjectDomain Data Structure.
/// </summary>
[Serializable]

public class JsonObjectDomain : TopObject
{
	        /// <summary>
	        /// 模板内容
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 排序
	        /// </summary>
	        [XmlElement("sort")]
	        public string Sort { get; set; }
	
	        /// <summary>
	        /// 类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 用户填写的内容
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// ReportOapiVoDomain Data Structure.
/// </summary>
[Serializable]

public class ReportOapiVoDomain : TopObject
{
	        /// <summary>
	        /// 日志内容
	        /// </summary>
	        [XmlArray("contents")]
	        [XmlArrayItem("json_object")]
	        public List<JsonObjectDomain> Contents { get; set; }
	
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

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlElement("result")]
	        public PageVoDomain Result { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
