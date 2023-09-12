using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.planetom.feeds.watchdata.get
    /// </summary>
    public class OapiPlanetomFeedsWatchdataGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPlanetomFeedsWatchdataGetResponse>
    {
        /// <summary>
        /// 主播在组织内的id（staffId）
        /// </summary>
        public string AnchorId { get; set; }

        /// <summary>
        /// 群的openconversationId(群对外的id)
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// 课程id
        /// </summary>
        public string FeedId { get; set; }

        /// <summary>
        /// 分页起始位置（不传默认获取前10个）
        /// </summary>
        public Nullable<long> Index { get; set; }

        /// <summary>
        /// 分页大小(默认0开始)
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.planetom.feeds.watchdata.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("anchor_id", this.AnchorId);
            parameters.Add("chat_id", this.ChatId);
            parameters.Add("feed_id", this.FeedId);
            parameters.Add("index", this.Index);
            parameters.Add("page_size", this.PageSize);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("anchor_id", this.AnchorId);
            RequestValidator.ValidateRequired("feed_id", this.FeedId);
        }

        #endregion
    }
}
