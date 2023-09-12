using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.live.grouplive.statistics
    /// </summary>
    public class OapiLiveGroupliveStatisticsRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiLiveGroupliveStatisticsResponse>
    {
        /// <summary>
        /// 群id
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 直播uuid
        /// </summary>
        public string LiveUuid { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public Nullable<long> OpenId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.live.grouplive.statistics";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("live_uuid", this.LiveUuid);
            parameters.Add("open_id", this.OpenId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("live_uuid", this.LiveUuid);
        }

        #endregion
    }
}
