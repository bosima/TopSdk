using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.corpinfo.list
    /// </summary>
    public class OapiUserCorpinfoListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserCorpinfoListResponse>
    {
        /// <summary>
        /// 企业全称
        /// </summary>
        public string CorpName { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        public string Mobile { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.corpinfo.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("corp_name", this.CorpName);
            parameters.Add("mobile", this.Mobile);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("corp_name", this.CorpName);
            RequestValidator.ValidateRequired("mobile", this.Mobile);
        }

        #endregion
    }
}
