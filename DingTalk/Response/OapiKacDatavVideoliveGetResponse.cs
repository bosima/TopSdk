using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavVideoliveGetResponse.
    /// </summary>
    public class OapiKacDatavVideoliveGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 统计数据对象
        /// </summary>
        [XmlElement("result")]
        public VideoLiveSummaryResponseDomain Result { get; set; }

	/// <summary>
/// VideoLiveSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class VideoLiveSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// 成功发起5分钟直播次数
	        /// </summary>
	        [XmlElement("live_launch_succ5min_cnt")]
	        public long LiveLaunchSucc5minCnt { get; set; }
	
	        /// <summary>
	        /// 成功发起直播次数
	        /// </summary>
	        [XmlElement("live_launch_succ_cnt")]
	        public long LiveLaunchSuccCnt { get; set; }
	
	        /// <summary>
	        /// 观看直播次数
	        /// </summary>
	        [XmlElement("live_play_cnt")]
	        public long LivePlayCnt { get; set; }
	
	        /// <summary>
	        /// 观看直播人数
	        /// </summary>
	        [XmlElement("live_play_user_cnt")]
	        public long LivePlayUserCnt { get; set; }
	
	        /// <summary>
	        /// 成功发起直播时长
	        /// </summary>
	        [XmlElement("live_succ_time_len")]
	        public string LiveSuccTimeLen { get; set; }
	
	        /// <summary>
	        /// 观看人数最多直播的观看人数
	        /// </summary>
	        [XmlElement("max_user_cnt")]
	        public long MaxUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天看直播的人数（包含观看和回放
	        /// </summary>
	        [XmlElement("watch_group_live_user_cnt")]
	        public long WatchGroupLiveUserCnt { get; set; }
}

    }
}
