using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.liveness.get
    /// </summary>
    public class CorpLivenessGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpLivenessGetResponse>
    {
        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.liveness.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
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
