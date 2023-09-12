using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiLiveQueryResponse.
    /// </summary>
    public class OapiLiveQueryResponse : DingTalkResponse
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
        /// 直播查询响应model
        /// </summary>
        [XmlElement("result")]
        public GetDetailRespModelDomain Result { get; set; }

	/// <summary>
/// LiveUrlExtModelDomain Data Structure.
/// </summary>
[Serializable]

public class LiveUrlExtModelDomain : TopObject
{
	        /// <summary>
	        /// 播放地址flv,超清-720p
	        /// </summary>
	        [XmlElement("live_url_high")]
	        public string LiveUrlHigh { get; set; }
	
	        /// <summary>
	        /// 播放地址flv,标清-360p
	        /// </summary>
	        [XmlElement("live_url_low")]
	        public string LiveUrlLow { get; set; }
	
	        /// <summary>
	        /// 播放地址flv,高清-480p
	        /// </summary>
	        [XmlElement("live_url_normal")]
	        public string LiveUrlNormal { get; set; }
	
	        /// <summary>
	        /// 播放地址flv,极速
	        /// </summary>
	        [XmlElement("live_url_ultra_low")]
	        public string LiveUrlUltraLow { get; set; }
	
	        /// <summary>
	        /// 播放地址flv,流畅
	        /// </summary>
	        [XmlElement("live_url_very_low")]
	        public string LiveUrlVeryLow { get; set; }
}

	/// <summary>
/// GetDetailRespModelDomain Data Structure.
/// </summary>
[Serializable]

public class GetDetailRespModelDomain : TopObject
{
	        /// <summary>
	        /// 预约直播时间
	        /// </summary>
	        [XmlElement("appointment_time")]
	        public string AppointmentTime { get; set; }
	
	        /// <summary>
	        /// 直播计划开始时间
	        /// </summary>
	        [XmlElement("appt_begin_time")]
	        public string ApptBeginTime { get; set; }
	
	        /// <summary>
	        /// 直播计划结束时间
	        /// </summary>
	        [XmlElement("appt_end_time")]
	        public string ApptEndTime { get; set; }
	
	        /// <summary>
	        /// 封面图,16:9长宽比
	        /// </summary>
	        [XmlElement("cover_url")]
	        public string CoverUrl { get; set; }
	
	        /// <summary>
	        /// 直播结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 推流地址
	        /// </summary>
	        [XmlElement("input_stream_url")]
	        public string InputStreamUrl { get; set; }
	
	        /// <summary>
	        /// 简介
	        /// </summary>
	        [XmlElement("intro")]
	        public string Intro { get; set; }
	
	        /// <summary>
	        /// 横竖屏:false 竖屏, true 横屏(默认)
	        /// </summary>
	        [XmlElement("land_scape")]
	        public bool LandScape { get; set; }
	
	        /// <summary>
	        /// 原始直播地址
	        /// </summary>
	        [XmlElement("live_url")]
	        public string LiveUrl { get; set; }
	
	        /// <summary>
	        /// 转码直播地址
	        /// </summary>
	        [XmlElement("live_url_ext")]
	        public LiveUrlExtModelDomain LiveUrlExt { get; set; }
	
	        /// <summary>
	        /// 原始HLS直播地址
	        /// </summary>
	        [XmlElement("live_url_hls")]
	        public string LiveUrlHls { get; set; }
	
	        /// <summary>
	        /// 直播回放地址
	        /// </summary>
	        [XmlElement("playback_url")]
	        public string PlaybackUrl { get; set; }
	
	        /// <summary>
	        /// 预告视频Url
	        /// </summary>
	        [XmlElement("pre_video_play_url")]
	        public string PreVideoPlayUrl { get; set; }
	
	        /// <summary>
	        /// 直播可观看类型类型:false 受限制的直播, true 公开的直播(默认)
	        /// </summary>
	        [XmlElement("shared")]
	        public bool Shared { get; set; }
	
	        /// <summary>
	        /// 直播开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public string StartTime { get; set; }
	
	        /// <summary>
	        /// 直播间状态:0 预告, 1 直播中, 2 直播结束
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
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

    }
}
