using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.platform.translate
    /// </summary>
    public class OapiPlatformTranslateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPlatformTranslateResponse>
    {
        /// <summary>
        /// 翻译源文字符串
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 翻译源语言类型
        /// </summary>
        public string SourceLanguage { get; set; }

        /// <summary>
        /// 翻译目标语言类型
        /// </summary>
        public string TargetLanguage { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.platform.translate";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query", this.Query);
            parameters.Add("source_language", this.SourceLanguage);
            parameters.Add("target_language", this.TargetLanguage);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("query", this.Query);
            RequestValidator.ValidateRequired("source_language", this.SourceLanguage);
            RequestValidator.ValidateRequired("target_language", this.TargetLanguage);
        }

        #endregion
    }
}
