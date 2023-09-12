using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.conversation.modifymember
    /// </summary>
    public class OapiImpaasConversationModifymemberRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasConversationModifymemberResponse>
    {
        /// <summary>
        /// 渠道
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// 群ID
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 会员ID列表
        /// </summary>
        public string MemberidList { get; set; }

        /// <summary>
        /// 1 添加 2 删除
        /// </summary>
        public Nullable<long> Type { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.conversation.modifymember";
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
            parameters.Add("memberid_list", this.MemberidList);
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("channel", this.Channel);
            RequestValidator.ValidateRequired("chatid", this.Chatid);
            RequestValidator.ValidateRequired("memberid_list", this.MemberidList);
            RequestValidator.ValidateMaxListSize("memberid_list", this.MemberidList, 500);
            RequestValidator.ValidateRequired("type", this.Type);
        }

        #endregion
    }
}
