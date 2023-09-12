using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.asr.voice.translate
    /// </summary>
    public class OapiAsrVoiceTranslateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAsrVoiceTranslateResponse>
    {
        /// <summary>
        /// media_id，获取方式见https://ding-doc.dingtalk.com/doc#/serverapi2/bcmg0i
        /// </summary>
        public string MediaId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.asr.voice.translate";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("media_id", this.MediaId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("media_id", this.MediaId);
        }

        #endregion
    }
}
