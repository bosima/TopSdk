using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sceneservicegroup.group.get
    /// </summary>
    public class OapiSceneservicegroupGroupGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSceneservicegroupGroupGetResponse>
    {
        /// <summary>
        /// 开放群ID
        /// </summary>
        public string OpenConversationid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sceneservicegroup.group.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_conversationid", this.OpenConversationid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_conversationid", this.OpenConversationid);
        }

        #endregion
    }
}
