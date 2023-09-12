using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.medal.corpmedal.query
    /// </summary>
    public class OapiMedalCorpmedalQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMedalCorpmedalQueryResponse>
    {
        /// <summary>
        /// 勋章模板ID列表
        /// </summary>
        public string TemplateIds { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.medal.corpmedal.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("template_ids", this.TemplateIds);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("template_ids", this.TemplateIds, 10);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
