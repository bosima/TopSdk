using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.conversaion.changegroupowner
    /// </summary>
    public class OapiImpaasConversaionChangegroupownerRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasConversaionChangegroupownerResponse>
    {
        /// <summary>
        /// 应用channel
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// 钉钉会话id
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.conversaion.changegroupowner";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel", this.Channel);
            parameters.Add("chatid", this.Chatid);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
