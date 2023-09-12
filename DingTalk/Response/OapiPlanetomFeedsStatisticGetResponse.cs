using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiPlanetomFeedsStatisticGetResponse.
    /// </summary>
    public class OapiPlanetomFeedsStatisticGetResponse : DingTalkResponse
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
        /// 返回值model
        /// </summary>
        [XmlElement("result")]
        public OpenFeedInfoModelDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenFeedInfoModelDomain Data Structure.
/// </summary>
[Serializable]

public class OpenFeedInfoModelDomain : TopObject
{
	        /// <summary>
	        /// 主播uid
	        /// </summary>
	        [XmlElement("anchor_id")]
	        public string AnchorId { get; set; }
	
	        /// <summary>
	        /// 绑定群的cid列表
	        /// </summary>
	        [XmlArray("chat_ids")]
	        [XmlArrayItem("string")]
	        public List<string> ChatIds { get; set; }
	
	        /// <summary>
	        /// 封面链接
	        /// </summary>
	        [XmlElement("cover_url")]
	        public string CoverUrl { get; set; }
	
	        /// <summary>
	        /// 直播时长（毫秒）
	        /// </summary>
	        [XmlElement("duration")]
	        public long Duration { get; set; }
	
	        /// <summary>
	        /// 剪辑过后的视频回放地址(含authkey,若空则代表没有经过剪辑)
	        /// </summary>
	        [XmlElement("edit_replay_url")]
	        public string EditReplayUrl { get; set; }
	
	        /// <summary>
	        /// 直播结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 课程id
	        /// </summary>
	        [XmlElement("feed_id")]
	        public string FeedId { get; set; }
	
	        /// <summary>
	        /// 课程类型
	        /// </summary>
	        [XmlElement("feed_type")]
	        public long FeedType { get; set; }
	
	        /// <summary>
	        /// 是否有回放保存
	        /// </summary>
	        [XmlElement("has_play_back")]
	        public bool HasPlayBack { get; set; }
	
	        /// <summary>
	        /// 简介
	        /// </summary>
	        [XmlElement("introduction")]
	        public string Introduction { get; set; }
	
	        /// <summary>
	        /// 跳转链接
	        /// </summary>
	        [XmlElement("jump_url")]
	        public string JumpUrl { get; set; }
	
	        /// <summary>
	        /// 回放拉流地址（含authkey）
	        /// </summary>
	        [XmlElement("replay_url")]
	        public string ReplayUrl { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public string StartTime { get; set; }
	
	        /// <summary>
	        /// 课程状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 直播状态
	        /// </summary>
	        [XmlElement("sub_status")]
	        public long SubStatus { get; set; }
	
	        /// <summary>
	        /// 课程标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
