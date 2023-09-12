using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiPlanetomFeedsWatchdataGetResponse.
    /// </summary>
    public class OapiPlanetomFeedsWatchdataGetResponse : DingTalkResponse
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
        public OpenFeedWatchDetailRspModelDomain Result { get; set; }

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenFeedWatchDetailModelDomain Data Structure.
/// </summary>
[Serializable]

public class OpenFeedWatchDetailModelDomain : TopObject
{
	        /// <summary>
	        /// 观看直播时长（秒）
	        /// </summary>
	        [XmlElement("play_live_duration")]
	        public long PlayLiveDuration { get; set; }
	
	        /// <summary>
	        /// 观看回放时长（秒）
	        /// </summary>
	        [XmlElement("play_record_duration")]
	        public long PlayRecordDuration { get; set; }
	
	        /// <summary>
	        /// 观看者在组织内id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenFeedWatchDetailRspModelDomain Data Structure.
/// </summary>
[Serializable]

public class OpenFeedWatchDetailRspModelDomain : TopObject
{
	        /// <summary>
	        /// 是否还有数据没返回(0还有/1没有)
	        /// </summary>
	        [XmlElement("has_finish")]
	        public long HasFinish { get; set; }
	
	        /// <summary>
	        /// 观看数据列表
	        /// </summary>
	        [XmlArray("viewer_watch_details")]
	        [XmlArrayItem("open_feed_watch_detail_model")]
	        public List<OpenFeedWatchDetailModelDomain> ViewerWatchDetails { get; set; }
}

    }
}
