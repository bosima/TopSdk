using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.crm.objectmeta.contact.describe
    /// </summary>
    public class OapiCrmObjectmetaContactDescribeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCrmObjectmetaContactDescribeResponse>
    {
        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.crm.objectmeta.contact.describe";
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
