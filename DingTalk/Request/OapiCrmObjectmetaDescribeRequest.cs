using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.crm.objectmeta.describe
    /// </summary>
    public class OapiCrmObjectmetaDescribeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCrmObjectmetaDescribeResponse>
    {
        /// <summary>
        /// 目标名称
        /// </summary>
        public string Name { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.crm.objectmeta.describe";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("name", this.Name);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("name", this.Name);
        }

        #endregion
    }
}
