using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ddpaas.objectmeta.describe
    /// </summary>
    public class OapiDdpaasObjectmetaDescribeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDdpaasObjectmetaDescribeResponse>
    {
        /// <summary>
        /// PaaS应用ID
        /// </summary>
        public string AppUuid { get; set; }

        /// <summary>
        /// 表单编号
        /// </summary>
        public string FormCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ddpaas.objectmeta.describe";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_uuid", this.AppUuid);
            parameters.Add("form_code", this.FormCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("app_uuid", this.AppUuid);
            RequestValidator.ValidateRequired("form_code", this.FormCode);
        }

        #endregion
    }
}
