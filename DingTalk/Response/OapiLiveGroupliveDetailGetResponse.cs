using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiLiveGroupliveDetailGetResponse.
    /// </summary>
    public class OapiLiveGroupliveDetailGetResponse : DingTalkResponse
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
        /// 直播详情
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
	        /// 直播观看时长
	        /// </summary>
	        [XmlElement("play_duration")]
	        public long PlayDuration { get; set; }
	
	        /// <summary>
	        /// 回放观看时长
	        /// </summary>
	        [XmlElement("play_record_duration")]
	        public long PlayRecordDuration { get; set; }
	
	        /// <summary>
	        /// 观看用户userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// GroupLiveStatisticsDomain Data Structure.
/// </summary>
[Serializable]

public class GroupLiveStatisticsDomain : TopObject
{
	        /// <summary>
	        /// 查看人员列表
	        /// </summary>
	        [XmlArray("group_live_viewers")]
	        [XmlArrayItem("groupliveviewers")]
	        public List<GroupliveviewersDomain> GroupLiveViewers { get; set; }
	
	        /// <summary>
	        /// 群直播分享url
	        /// </summary>
	        [XmlElement("live_share_url")]
	        public string LiveShareUrl { get; set; }
	
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
	        /// 直播观看人次
	        /// </summary>
	        [XmlElement("pv")]
	        public long Pv { get; set; }
	
	        /// <summary>
	        /// 未看人数
	        /// </summary>
	        [XmlElement("unviewed_count")]
	        public long UnviewedCount { get; set; }
	
	        /// <summary>
	        /// 已看人数
	        /// </summary>
	        [XmlElement("viewer_count")]
	        public long ViewerCount { get; set; }
}

    }
}
