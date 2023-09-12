using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.v2.user.getbymobile
    /// </summary>
    public class OapiV2UserGetbymobileRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiV2UserGetbymobileResponse>
    {
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 支持通过手机号搜索专属帐号(不含其他组织创建的专属帐号)
        /// </summary>
        public Nullable<bool> SupportExclusiveAccountSearch { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.v2.user.getbymobile";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("mobile", this.Mobile);
            parameters.Add("support_exclusive_account_search", this.SupportExclusiveAccountSearch);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("mobile", this.Mobile);
            RequestValidator.ValidateMaxLength("mobile", this.Mobile, 15);
        }

        #endregion
    }
}
