using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.service.get_unactive_corp
    /// </summary>
    public class OapiServiceGetUnactiveCorpRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServiceGetUnactiveCorpResponse>
    {
        /// <summary>
        /// 套件下的微应用ID
        /// </summary>
        public Nullable<long> AppId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.service.get_unactive_corp";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_id", this.AppId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
