using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiLiveCreateResponse.
    /// </summary>
    public class OapiLiveCreateResponse : DingTalkResponse
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
        /// 直播创建响应model
        /// </summary>
        [XmlElement("result")]
        public CreateLiveRespModelDomain Result { get; set; }

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
/// CreateLiveRespModelDomain Data Structure.
/// </summary>
[Serializable]

public class CreateLiveRespModelDomain : TopObject
{
	        /// <summary>
	        /// 预约直播时间
	        /// </summary>
	        [XmlElement("appointment_time")]
	        public string AppointmentTime { get; set; }
	
	        /// <summary>
	        /// 推流地址
	        /// </summary>
	        [XmlElement("input_stream_url")]
	        public string InputStreamUrl { get; set; }
	
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
	        /// 直播UUID
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

    }
}
