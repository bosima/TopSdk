using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.medal.corpmedal.wear
    /// </summary>
    public class OapiMedalCorpmedalWearRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMedalCorpmedalWearResponse>
    {
        /// <summary>
        /// 1 佩戴，2 摘除
        /// </summary>
        public Nullable<long> Operation { get; set; }

        /// <summary>
        /// 勋章模板ID
        /// </summary>
        public Nullable<long> TemplateId { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.medal.corpmedal.wear";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("operation", this.Operation);
            parameters.Add("template_id", this.TemplateId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("operation", this.Operation);
            RequestValidator.ValidateRequired("template_id", this.TemplateId);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
