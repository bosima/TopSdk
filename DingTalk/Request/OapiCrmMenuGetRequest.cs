using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.crm.menu.get
    /// </summary>
    public class OapiCrmMenuGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCrmMenuGetResponse>
    {
        /// <summary>
        /// 0:PC端导航 1：手机端导航
        /// </summary>
        public string ClientType { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.crm.menu.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("client_type", this.ClientType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("client_type", this.ClientType);
        }

        #endregion
    }
}
