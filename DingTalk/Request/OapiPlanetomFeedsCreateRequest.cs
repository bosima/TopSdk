using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.planetom.feeds.create
    /// </summary>
    public class OapiPlanetomFeedsCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPlanetomFeedsCreateResponse>
    {
        /// <summary>
        /// 主播在组织内的id（staffId）
        /// </summary>
        public string AnchorId { get; set; }

        /// <summary>
        /// 约定开播时间戳（未来时间）
        /// </summary>
        public Nullable<long> AppointBeginTime { get; set; }

        /// <summary>
        /// 封面url
        /// </summary>
        public string CoverUrl { get; set; }

        /// <summary>
        /// 课程类型
        /// </summary>
        public Nullable<long> FeedType { get; set; }

        /// <summary>
        /// 1 chatId / 2 openConversationId，不传默认为OpenConversationId
        /// </summary>
        public Nullable<long> GroupIdType { get; set; }

        /// <summary>
        /// 绑定群列表,如果不传，默认为公开直播
        /// </summary>
        public string GroupIds { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Introduction { get; set; }

        /// <summary>
        /// 开放平台中应用的appId
        /// </summary>
        public Nullable<long> OpenAppId { get; set; }

        /// <summary>
        /// 图片简介url
        /// </summary>
        public string PicIntroductionUrl { get; set; }

        /// <summary>
        /// 预告片视频
        /// </summary>
        public string PreVideoUrl { get; set; }

        /// <summary>
        /// 课程标题
        /// </summary>
        public string Title { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.planetom.feeds.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("anchor_id", this.AnchorId);
            parameters.Add("appoint_begin_time", this.AppointBeginTime);
            parameters.Add("cover_url", this.CoverUrl);
            parameters.Add("feed_type", this.FeedType);
            parameters.Add("group_id_type", this.GroupIdType);
            parameters.Add("group_ids", this.GroupIds);
            parameters.Add("introduction", this.Introduction);
            parameters.Add("open_app_id", this.OpenAppId);
            parameters.Add("pic_introduction_url", this.PicIntroductionUrl);
            parameters.Add("pre_video_url", this.PreVideoUrl);
            parameters.Add("title", this.Title);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("anchor_id", this.AnchorId);
            RequestValidator.ValidateRequired("appoint_begin_time", this.AppointBeginTime);
            RequestValidator.ValidateRequired("feed_type", this.FeedType);
            RequestValidator.ValidateMaxListSize("group_ids", this.GroupIds, 999);
            RequestValidator.ValidateRequired("open_app_id", this.OpenAppId);
            RequestValidator.ValidateRequired("title", this.Title);
        }

        #endregion
    }
}
