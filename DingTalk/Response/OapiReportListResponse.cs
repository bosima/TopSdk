using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiReportListResponse.
    /// </summary>
    public class OapiReportListResponse : DingTalkResponse
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
	        /// 日志图片列表
	        /// </summary>
	        [XmlArray("images")]
	        [XmlArrayItem("string")]
	        public List<string> Images { get; set; }
	
	        /// <summary>
	        /// 提交日志时点击获取位置，定位到的纬度（没有获取位置则为空），此字段的值默认为空，需要单独申请开通
	        /// </summary>
	        [XmlElement("latitude")]
	        public string Latitude { get; set; }
	
	        /// <summary>
	        /// 提交日志时点击获取位置，定位到的经度（没有获取位置则为空），此字段的值默认为空，需要单独申请开通
	        /// </summary>
	        [XmlElement("longitude")]
	        public string Longitude { get; set; }
	
	        /// <summary>
	        /// 日志修改时间
	        /// </summary>
	        [XmlElement("modified_time")]
	        public long ModifiedTime { get; set; }
	
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
