using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.org.setoaurl
    /// </summary>
    public class OapiOrgSetoaurlRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiOrgSetoaurlResponse>
    {
        /// <summary>
        /// 工作台名称，认证企业才能设置
        /// </summary>
        public string OaTitle { get; set; }

        /// <summary>
        /// 工作台首页地址，必须是https开头
        /// </summary>
        public string OaUrl { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.org.setoaurl";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("oa_title", this.OaTitle);
            parameters.Add("oa_url", this.OaUrl);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("oa_url", this.OaUrl);
        }

        #endregion
    }
}
