using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiPlanetomFeedsInteractivedataGetResponse.
    /// </summary>
    public class OapiPlanetomFeedsInteractivedataGetResponse : DingTalkResponse
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
        public OpenFeedInteractiveDataModelDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// BaseFeedInfoModelDomain Data Structure.
/// </summary>
[Serializable]

public class BaseFeedInfoModelDomain : TopObject
{
	        /// <summary>
	        /// 直播时长
	        /// </summary>
	        [XmlElement("live_duration")]
	        public long LiveDuration { get; set; }
	
	        /// <summary>
	        /// 分享绑定的群列表
	        /// </summary>
	        [XmlArray("share_live_cid_list")]
	        [XmlArrayItem("string")]
	        public List<string> ShareLiveCidList { get; set; }
	
	        /// <summary>
	        /// 开始时间戳
	        /// </summary>
	        [XmlElement("start_time")]
	        public long StartTime { get; set; }
	
	        /// <summary>
	        /// 课程标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// InteractiveInfoModelDomain Data Structure.
/// </summary>
[Serializable]

public class InteractiveInfoModelDomain : TopObject
{
	        /// <summary>
	        /// 消息数
	        /// </summary>
	        [XmlElement("message_count")]
	        public long MessageCount { get; set; }
	
	        /// <summary>
	        /// 点赞数
	        /// </summary>
	        [XmlElement("praise_count")]
	        public long PraiseCount { get; set; }
	
	        /// <summary>
	        /// 观看总次数
	        /// </summary>
	        [XmlElement("pv")]
	        public long Pv { get; set; }
	
	        /// <summary>
	        /// 观看总人数（去重）
	        /// </summary>
	        [XmlElement("uv")]
	        public long Uv { get; set; }
}

	/// <summary>
/// OpenFeedInteractiveDataModelDomain Data Structure.
/// </summary>
[Serializable]

public class OpenFeedInteractiveDataModelDomain : TopObject
{
	        /// <summary>
	        /// 基础信息model
	        /// </summary>
	        [XmlElement("base_feed_info")]
	        public BaseFeedInfoModelDomain BaseFeedInfo { get; set; }
	
	        /// <summary>
	        /// 互动信息model
	        /// </summary>
	        [XmlElement("interactive_info")]
	        public InteractiveInfoModelDomain InteractiveInfo { get; set; }
}

    }
}
