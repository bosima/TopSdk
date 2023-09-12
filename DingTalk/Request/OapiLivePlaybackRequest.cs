using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.live.playback
    /// </summary>
    public class OapiLivePlaybackRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiLivePlaybackResponse>
    {
        /// <summary>
        /// 回放查询请求model
        /// </summary>
        public string Request { get; set; }

        public PlayBackReqModelDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.live.playback";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// PlayBackReqModelDomain Data Structure.
/// </summary>
[Serializable]

public class PlayBackReqModelDomain : TopObject
{
	        /// <summary>
	        /// 偏移量
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<DateTime> EndTime { get; set; }
	
	        /// <summary>
	        /// 页面大小
	        /// </summary>
	        [XmlElement("offset")]
	        public Nullable<long> Offset { get; set; }
	
	        /// <summary>
	        /// 直播结束时间
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 直播开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public Nullable<DateTime> StartTime { get; set; }
}

        #endregion
    }
}
