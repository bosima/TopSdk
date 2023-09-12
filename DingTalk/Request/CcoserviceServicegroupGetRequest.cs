using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.ccoservice.servicegroup.get
    /// </summary>
    public class CcoserviceServicegroupGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.CcoserviceServicegroupGetResponse>
    {
        /// <summary>
        /// 服务群id
        /// </summary>
        public string OpenGroupId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.ccoservice.servicegroup.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
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
