using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.organization.dept.meta.get
    /// </summary>
    public class OapiSmartworkHrmOrganizationDeptMetaGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmOrganizationDeptMetaGetResponse>
    {
        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.organization.dept.meta.get";
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
