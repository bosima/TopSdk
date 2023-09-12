using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.conversation.create
    /// </summary>
    public class OapiImpaasConversationCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasConversationCreateResponse>
    {
        /// <summary>
        /// 渠道
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 群主员工id
        /// </summary>
        public string OwnerUserid { get; set; }

        /// <summary>
        /// 成员员工id列表
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.conversation.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel", this.Channel);
            parameters.Add("name", this.Name);
            parameters.Add("owner_userid", this.OwnerUserid);
            parameters.Add("userid_list", this.UseridList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("channel", this.Channel);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("owner_userid", this.OwnerUserid);
            RequestValidator.ValidateRequired("userid_list", this.UseridList);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 500);
        }

        #endregion
    }
}
