using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.get_org_user_count
    /// </summary>
    public class OapiUserGetOrgUserCountRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserGetOrgUserCountResponse>
    {
        /// <summary>
        /// 0：包含未激活钉钉的人员数量 1：不包含未激活钉钉的人员数量
        /// </summary>
        public Nullable<long> OnlyActive { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.get_org_user_count";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("onlyActive", this.OnlyActive);
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
