using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiLiveGroupliveListbytimeResponse.
    /// </summary>
    public class OapiLiveGroupliveListbytimeResponse : DingTalkResponse
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
        /// 直播列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("group_live_list_result")]
        public List<GroupLiveListResultDomain> Result { get; set; }

	/// <summary>
/// GroupLiveListResultDomain Data Structure.
/// </summary>
[Serializable]

public class GroupLiveListResultDomain : TopObject
{
	        /// <summary>
	        /// 直播时长
	        /// </summary>
	        [XmlElement("duration")]
	        public long Duration { get; set; }
	
	        /// <summary>
	        /// 直播id
	        /// </summary>
	        [XmlElement("live_uuid")]
	        public string LiveUuid { get; set; }
	
	        /// <summary>
	        /// true为被联播群，false为主群
	        /// </summary>
	        [XmlElement("share_from")]
	        public bool ShareFrom { get; set; }
	
	        /// <summary>
	        /// 直播开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public long StartTime { get; set; }
	
	        /// <summary>
	        /// 直播标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 主播userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
