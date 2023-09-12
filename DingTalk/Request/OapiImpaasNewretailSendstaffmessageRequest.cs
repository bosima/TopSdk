using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.newretail.sendstaffmessage
    /// </summary>
    public class OapiImpaasNewretailSendstaffmessageRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasNewretailSendstaffmessageResponse>
    {
        /// <summary>
        /// 消息体
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 0系统消息
        /// </summary>
        public Nullable<long> MsgType { get; set; }

        /// <summary>
        /// 系统账号
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// 用账号列表
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.newretail.sendstaffmessage";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("content", this.Content);
            parameters.Add("msg_type", this.MsgType);
            parameters.Add("sender", this.Sender);
            parameters.Add("userid_list", this.UseridList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 100);
        }

        #endregion
    }
}
