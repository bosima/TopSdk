using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.subadmin.update
    /// </summary>
    public class OapiChatSubadminUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatSubadminUpdateResponse>
    {
        /// <summary>
        /// 群会话id
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 设置2添加为管理员，设置3删除该管理员
        /// </summary>
        public Nullable<long> Role { get; set; }

        /// <summary>
        /// 群成员id
        /// </summary>
        public string Userids { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.subadmin.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatid", this.Chatid);
            parameters.Add("role", this.Role);
            parameters.Add("userids", this.Userids);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("chatid", this.Chatid);
            RequestValidator.ValidateRequired("role", this.Role);
            RequestValidator.ValidateRequired("userids", this.Userids);
            RequestValidator.ValidateMaxListSize("userids", this.Userids, 12);
        }

        #endregion
    }
}
