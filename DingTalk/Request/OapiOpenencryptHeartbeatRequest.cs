using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.openencrypt.heartbeat
    /// </summary>
    public class OapiOpenencryptHeartbeatRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiOpenencryptHeartbeatResponse>
    {
        /// <summary>
        /// 微应用id
        /// </summary>
        public Nullable<long> Appid { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        public string Extension { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.openencrypt.heartbeat";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("appid", this.Appid);
            parameters.Add("extension", this.Extension);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("appid", this.Appid);
        }

        #endregion
    }
}
