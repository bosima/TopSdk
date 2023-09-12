using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.planetom.feeds.interactivedata.get
    /// </summary>
    public class OapiPlanetomFeedsInteractivedataGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPlanetomFeedsInteractivedataGetResponse>
    {
        /// <summary>
        /// 主播在组织内id（staffId）
        /// </summary>
        public string AnchorId { get; set; }

        /// <summary>
        /// 课程id
        /// </summary>
        public string FeedId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.planetom.feeds.interactivedata.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("anchor_id", this.AnchorId);
            parameters.Add("feed_id", this.FeedId);
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
