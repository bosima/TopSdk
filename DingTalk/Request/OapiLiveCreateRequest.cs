using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.live.create
    /// </summary>
    public class OapiLiveCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiLiveCreateResponse>
    {
        /// <summary>
        /// 直播创建请求model
        /// </summary>
        public string Request { get; set; }

        public CreateLiveReqModelDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.live.create";
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
/// CreateLiveReqModelDomain Data Structure.
/// </summary>
[Serializable]

public class CreateLiveReqModelDomain : TopObject
{
	        /// <summary>
	        /// 直播计划开始时间,选填: 如果不填写, 则取当前时间
	        /// </summary>
	        [XmlElement("appt_begin_time")]
	        public Nullable<DateTime> ApptBeginTime { get; set; }
	
	        /// <summary>
	        /// 直播计划结束时间,选填
	        /// </summary>
	        [XmlElement("appt_end_time")]
	        public Nullable<DateTime> ApptEndTime { get; set; }
	
	        /// <summary>
	        /// 封面图,选填: 如果不填写, 则采用默认
	        /// </summary>
	        [XmlElement("cover_url")]
	        public string CoverUrl { get; set; }
	
	        /// <summary>
	        /// 简介,选填
	        /// </summary>
	        [XmlElement("intro")]
	        public string Intro { get; set; }
	
	        /// <summary>
	        /// 横竖屏,选填: false 竖屏, true 横屏(默认)
	        /// </summary>
	        [XmlElement("land_scape")]
	        public Nullable<bool> LandScape { get; set; }
	
	        /// <summary>
	        /// 预告视频Url,选填
	        /// </summary>
	        [XmlElement("pre_video_play_url")]
	        public string PreVideoPlayUrl { get; set; }
	
	        /// <summary>
	        /// 直播可观看类型类型,必填: false 受限制的直播, true 公开的直播(默认)
	        /// </summary>
	        [XmlElement("shared")]
	        public Nullable<bool> Shared { get; set; }
	
	        /// <summary>
	        /// 标题,必填
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 别名,选填
	        /// </summary>
	        [XmlElement("user_nick")]
	        public string UserNick { get; set; }
	
	        /// <summary>
	        /// 主播ID,必填
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
