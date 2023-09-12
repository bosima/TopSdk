using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavDeptVideoliveListResponse.
    /// </summary>
    public class OapiKacDatavDeptVideoliveListResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlElement("result")]
        public VideoLiveDeptSummaryResponseDomain Result { get; set; }

	/// <summary>
/// VideoLiveDeptSummaryVoDomain Data Structure.
/// </summary>
[Serializable]

public class VideoLiveDeptSummaryVoDomain : TopObject
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
	        /// 直播发起次数（成功）
	        /// </summary>
	        [XmlElement("live_launch_count")]
	        public long LiveLaunchCount { get; set; }
	
	        /// <summary>
	        /// 观看直播人数
	        /// </summary>
	        [XmlElement("live_play_user_count")]
	        public long LivePlayUserCount { get; set; }
	
	        /// <summary>
	        /// 直播时长（分钟）
	        /// </summary>
	        [XmlElement("live_time_length")]
	        public string LiveTimeLength { get; set; }
}

	/// <summary>
/// VideoLiveDeptSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class VideoLiveDeptSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// data
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("video_live_dept_summary_vo")]
	        public List<VideoLiveDeptSummaryVoDomain> Data { get; set; }
	
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
