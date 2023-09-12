using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.service.set_corp_ipwhitelist
    /// </summary>
    public class OapiServiceSetCorpIpwhitelistRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServiceSetCorpIpwhitelistResponse>
    {
        /// <summary>
        /// 授权方corpid
        /// </summary>
        public string AuthCorpid { get; set; }

        /// <summary>
        /// 要为其设置的IP白名单,格式支持IP段,用星号表示,如【5.6.*.*】,代表从【5.6.0.*】到【5.6.255.*】的任意IP,在第三段设为星号时,将忽略第四段的值,注意:仅支持后两段设置为星号
        /// </summary>
        public List<string> IpWhitelist { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.service.set_corp_ipwhitelist";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auth_corpid", this.AuthCorpid);
            parameters.Add("ip_whitelist", TopUtils.ObjectToJson(this.IpWhitelist));
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("ip_whitelist", this.IpWhitelist, 20);
        }

        #endregion
    }
}
