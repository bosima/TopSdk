using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ccoservice.servicegroup.get
    /// </summary>
    public class OapiCcoserviceServicegroupGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCcoserviceServicegroupGetResponse>
    {
        /// <summary>
        /// 服务群id
        /// </summary>
        public string OpenGroupId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ccoservice.servicegroup.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_group_id", this.OpenGroupId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_group_id", this.OpenGroupId);
        }

        #endregion
    }
}
