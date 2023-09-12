using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.org.union.trunk.get
    /// </summary>
    public class OapiOrgUnionTrunkGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiOrgUnionTrunkGetResponse>
    {
        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.org.union.trunk.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
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
