using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavDeptTelconfListResponse.
    /// </summary>
    public class OapiKacDatavDeptTelconfListResponse : DingTalkResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// resut
        /// </summary>
        [XmlElement("result")]
        public TelConferenceDeptSummaryResponseDomain Result { get; set; }

	/// <summary>
/// TelConferenceDeptSummaryVoDomain Data Structure.
/// </summary>
[Serializable]

public class TelConferenceDeptSummaryVoDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 参与人次
	        /// </summary>
	        [XmlElement("join_count")]
	        public long JoinCount { get; set; }
	
	        /// <summary>
	        /// 平均时长（分钟）
	        /// </summary>
	        [XmlElement("start_avg_len_min")]
	        public string StartAvgLenMin { get; set; }
	
	        /// <summary>
	        /// 发起次数
	        /// </summary>
	        [XmlElement("start_count")]
	        public long StartCount { get; set; }
	
	        /// <summary>
	        /// 发起总时长（分钟）
	        /// </summary>
	        [XmlElement("start_len_min")]
	        public string StartLenMin { get; set; }
}

	/// <summary>
/// TelConferenceDeptSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class TelConferenceDeptSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// data
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("tel_conference_dept_summary_vo")]
	        public List<TelConferenceDeptSummaryVoDomain> Data { get; set; }
	
	        /// <summary>
	        /// 是否有下一页；true则存在更多分页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一次请求的分页游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
