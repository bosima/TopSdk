using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiLiveGroupliveListResponse.
    /// </summary>
    public class OapiLiveGroupliveListResponse : DingTalkResponse
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
        /// 返回列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("result")]
        public List<ResultDomain> Result { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 群id
	        /// </summary>
	        [XmlElement("cid")]
	        public long Cid { get; set; }
	
	        /// <summary>
	        /// 时长
	        /// </summary>
	        [XmlElement("duration")]
	        public long Duration { get; set; }
	
	        /// <summary>
	        /// 是否横屏
	        /// </summary>
	        [XmlElement("is_landscape")]
	        public bool IsLandscape { get; set; }
	
	        /// <summary>
	        /// 直播id
	        /// </summary>
	        [XmlElement("live_uuid")]
	        public string LiveUuid { get; set; }
	
	        /// <summary>
	        /// openid
	        /// </summary>
	        [XmlElement("open_id")]
	        public long OpenId { get; set; }
	
	        /// <summary>
	        /// 开始时间ms
	        /// </summary>
	        [XmlElement("start_time")]
	        public long StartTime { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
