using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiLiveGroupliveStatisticsResponse.
    /// </summary>
    public class OapiLiveGroupliveStatisticsResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public GroupLiveStatisticsDomain Result { get; set; }

	/// <summary>
/// GroupliveviewersDomain Data Structure.
/// </summary>
[Serializable]

public class GroupliveviewersDomain : TopObject
{
	        /// <summary>
	        /// openid
	        /// </summary>
	        [XmlElement("open_id")]
	        public long OpenId { get; set; }
	
	        /// <summary>
	        /// 直播时长
	        /// </summary>
	        [XmlElement("play_duration")]
	        public long PlayDuration { get; set; }
	
	        /// <summary>
	        /// 回放时长
	        /// </summary>
	        [XmlElement("play_record_duration")]
	        public long PlayRecordDuration { get; set; }
}

	/// <summary>
/// GroupLiveStatisticsDomain Data Structure.
/// </summary>
[Serializable]

public class GroupLiveStatisticsDomain : TopObject
{
	        /// <summary>
	        /// 观看列表
	        /// </summary>
	        [XmlArray("group_live_viewers")]
	        [XmlArrayItem("groupliveviewers")]
	        public List<GroupliveviewersDomain> GroupLiveViewers { get; set; }
	
	        /// <summary>
	        /// 直播总时长
	        /// </summary>
	        [XmlElement("live_duration")]
	        public long LiveDuration { get; set; }
	
	        /// <summary>
	        /// 消息
	        /// </summary>
	        [XmlElement("message_count")]
	        public long MessageCount { get; set; }
	
	        /// <summary>
	        /// 点赞
	        /// </summary>
	        [XmlElement("praise_count")]
	        public long PraiseCount { get; set; }
	
	        /// <summary>
	        /// pv
	        /// </summary>
	        [XmlElement("pv")]
	        public long Pv { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_sime")]
	        public long StartSime { get; set; }
	
	        /// <summary>
	        /// 直播标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 未看数
	        /// </summary>
	        [XmlElement("unviewed_count")]
	        public long UnviewedCount { get; set; }
	
	        /// <summary>
	        /// 已看
	        /// </summary>
	        [XmlElement("viewer_count")]
	        public long ViewerCount { get; set; }
}

    }
}
