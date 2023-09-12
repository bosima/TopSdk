using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.microapp.delwithuserid
    /// </summary>
    public class OapiMicroappDelwithuseridRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMicroappDelwithuseridResponse>
    {
        /// <summary>
        /// 微应用实例化id，表示企业和微应用的唯一关系
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 用户id列表，最多10个
        /// </summary>
        public string Userids { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.microapp.delwithuserid";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentId", this.AgentId);
            parameters.Add("userids", this.Userids);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agentId", this.AgentId);
            RequestValidator.ValidateRequired("userids", this.Userids);
            RequestValidator.ValidateMaxListSize("userids", this.Userids, 20);
        }

        #endregion
    }
}
