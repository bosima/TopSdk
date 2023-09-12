using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.live.grouplive.sharelist
    /// </summary>
    public class OapiLiveGroupliveSharelistRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiLiveGroupliveSharelistResponse>
    {
        /// <summary>
        /// 群id
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 直播uuid
        /// </summary>
        public string LiveUuid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.live.grouplive.sharelist";
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
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
            RequestValidator.ValidateRequired("live_uuid", this.LiveUuid);
        }

        #endregion
    }
}
