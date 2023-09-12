using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.miniapp.deploywindow.query
    /// </summary>
    public class OapiMiniappDeploywindowQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMiniappDeploywindowQueryResponse>
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public string ModelKey { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.miniapp.deploywindow.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("model_key", this.ModelKey);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("model_key", this.ModelKey);
        }

        #endregion
    }
}
