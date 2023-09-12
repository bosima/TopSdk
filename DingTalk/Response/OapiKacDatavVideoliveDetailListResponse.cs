using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavVideoliveDetailListResponse.
    /// </summary>
    public class OapiKacDatavVideoliveDetailListResponse : DingTalkResponse
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
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public VideoLiveDetailResponseDomain Result { get; set; }

	/// <summary>
/// VideoLiveDetailVoDomain Data Structure.
/// </summary>
[Serializable]

public class VideoLiveDetailVoDomain : TopObject
{
	        /// <summary>
	        /// 直播群cid
	        /// </summary>
	        [XmlElement("cid")]
	        public string Cid { get; set; }
	
	        /// <summary>
	        /// 部门ID
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 直播群名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
	
	        /// <summary>
	        /// 群人数
	        /// </summary>
	        [XmlElement("group_user_count")]
	        public long GroupUserCount { get; set; }
	
	        /// <summary>
	        /// 观看直播次数
	        /// </summary>
	        [XmlElement("live_watch_count")]
	        public long LiveWatchCount { get; set; }
	
	        /// <summary>
	        /// 直播时长（秒）
	        /// </summary>
	        [XmlElement("live_watch_duration")]
	        public string LiveWatchDuration { get; set; }
	
	        /// <summary>
	        /// 直播时长（分钟）
	        /// </summary>
	        [XmlElement("live_watch_duration_min")]
	        public string LiveWatchDurationMin { get; set; }
	
	        /// <summary>
	        /// 直播结束时间
	        /// </summary>
	        [XmlElement("live_watch_end_time")]
	        public string LiveWatchEndTime { get; set; }
	
	        /// <summary>
	        /// 直播开始时间
	        /// </summary>
	        [XmlElement("live_watch_start_time")]
	        public string LiveWatchStartTime { get; set; }
	
	        /// <summary>
	        /// 直播标题
	        /// </summary>
	        [XmlElement("live_watch_title")]
	        public string LiveWatchTitle { get; set; }
	
	        /// <summary>
	        /// 观看直播人数
	        /// </summary>
	        [XmlElement("live_watch_user_count")]
	        public long LiveWatchUserCount { get; set; }
	
	        /// <summary>
	        /// 群对外开放的id
	        /// </summary>
	        [XmlElement("openConversationId")]
	        public string OpenConversationId { get; set; }
	
	        /// <summary>
	        /// 直播发起人员工工号
	        /// </summary>
	        [XmlElement("staff_job_num")]
	        public string StaffJobNum { get; set; }
	
	        /// <summary>
	        /// 直播发起人用户名称
	        /// </summary>
	        [XmlElement("staff_name")]
	        public string StaffName { get; set; }
	
	        /// <summary>
	        /// 员工在当前企业内的唯一标识，也称staffId。可由企业在创建时指定，并代表一定含义比如工号，创建后不可修改
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 直播uuid
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

	/// <summary>
/// VideoLiveDetailResponseDomain Data Structure.
/// </summary>
[Serializable]

public class VideoLiveDetailResponseDomain : TopObject
{
	        /// <summary>
	        /// 数据明细列表
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("video_live_detail_vo")]
	        public List<VideoLiveDetailVoDomain> Data { get; set; }
	
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
