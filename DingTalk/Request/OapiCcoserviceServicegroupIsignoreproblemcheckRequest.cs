using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ccoservice.servicegroup.isignoreproblemcheck
    /// </summary>
    public class OapiCcoserviceServicegroupIsignoreproblemcheckRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCcoserviceServicegroupIsignoreproblemcheckResponse>
    {
        /// <summary>
        /// 用户dingtalk加密id
        /// </summary>
        public string DingtalkId { get; set; }

        /// <summary>
        /// 群id
        /// </summary>
        public string OpenConversationId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ccoservice.servicegroup.isignoreproblemcheck";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dingtalk_id", this.DingtalkId);
            parameters.Add("open_conversation_id", this.OpenConversationId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("dingtalk_id", this.DingtalkId);
            RequestValidator.ValidateRequired("open_conversation_id", this.OpenConversationId);
        }

        #endregion
    }
}
