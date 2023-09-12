using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.conference.unpublish
    /// </summary>
    public class OapiConferenceUnpublishRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiConferenceUnpublishResponse>
    {
        /// <summary>
        /// 会务id
        /// </summary>
        public string ConferenceId { get; set; }

        /// <summary>
        /// 操作用户id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.conference.unpublish";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("conference_id", this.ConferenceId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("conference_id", this.ConferenceId);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
