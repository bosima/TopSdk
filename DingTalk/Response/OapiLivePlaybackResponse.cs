using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiLivePlaybackResponse.
    /// </summary>
    public class OapiLivePlaybackResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 回放查询响应model
        /// </summary>
        [XmlElement("result")]
        public PlayBackRespModelDomain Result { get; set; }

	/// <summary>
/// PlayBackModelDomain Data Structure.
/// </summary>
[Serializable]

public class PlayBackModelDomain : TopObject
{
	        /// <summary>
	        /// 封面图
	        /// </summary>
	        [XmlElement("cover_url")]
	        public string CoverUrl { get; set; }
	
	        /// <summary>
	        /// 直播结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 简介
	        /// </summary>
	        [XmlElement("intro")]
	        public string Intro { get; set; }
	
	        /// <summary>
	        /// 横竖屏: false 竖屏, true 横屏(默认)
	        /// </summary>
	        [XmlElement("land_scape")]
	        public bool LandScape { get; set; }
	
	        /// <summary>
	        /// 回放地址
	        /// </summary>
	        [XmlElement("playback_url")]
	        public string PlaybackUrl { get; set; }
	
	        /// <summary>
	        /// 直播可观看类型: false 受限制的直播, true 公开的直播(默认)
	        /// </summary>
	        [XmlElement("shared")]
	        public bool Shared { get; set; }
	
	        /// <summary>
	        /// 直播开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public string StartTime { get; set; }
	
	        /// <summary>
	        /// 直播时长
	        /// </summary>
	        [XmlElement("time_length")]
	        public long TimeLength { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 总共参加人数,UV
	        /// </summary>
	        [XmlElement("total_join_count")]
	        public long TotalJoinCount { get; set; }
	
	        /// <summary>
	        /// 总共访问次数,PV
	        /// </summary>
	        [XmlElement("total_view_count")]
	        public long TotalViewCount { get; set; }
	
	        /// <summary>
	        /// 别名
	        /// </summary>
	        [XmlElement("user_nick")]
	        public string UserNick { get; set; }
	
	        /// <summary>
	        /// 主播ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 直播UUID
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

	/// <summary>
/// PlayBackRespModelDomain Data Structure.
/// </summary>
[Serializable]

public class PlayBackRespModelDomain : TopObject
{
	        /// <summary>
	        /// 结果总数
	        /// </summary>
	        [XmlElement("all_count")]
	        public long AllCount { get; set; }
	
	        /// <summary>
	        /// 是否还有
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 偏移量
	        /// </summary>
	        [XmlElement("offset")]
	        public long Offset { get; set; }
	
	        /// <summary>
	        /// 页面大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 分页查询结果
	        /// </summary>
	        [XmlArray("play_back_list")]
	        [XmlArrayItem("play_back_model")]
	        public List<PlayBackModelDomain> PlayBackList { get; set; }
}

    }
}
