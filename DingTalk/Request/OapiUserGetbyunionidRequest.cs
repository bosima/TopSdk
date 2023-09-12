using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.getbyunionid
    /// </summary>
    public class OapiUserGetbyunionidRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserGetbyunionidResponse>
    {
        /// <summary>
        /// 员工在当前开发者企业账号范围内的唯一标识，系统生成，不会改变。
        /// </summary>
        public string Unionid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.getbyunionid";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("unionid", this.Unionid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("unionid", this.Unionid);
            RequestValidator.ValidateMaxLength("unionid", this.Unionid, 100);
        }

        #endregion
    }
}
