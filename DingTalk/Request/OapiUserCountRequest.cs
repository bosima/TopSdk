using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.count
    /// </summary>
    public class OapiUserCountRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserCountResponse>
    {
        /// <summary>
        /// false 包含未激活钉钉的人员数量 true 只包含激活钉钉的人员数量
        /// </summary>
        public Nullable<bool> OnlyActive { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.count";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("only_active", this.OnlyActive);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("only_active", this.OnlyActive);
        }

        #endregion
    }
}
