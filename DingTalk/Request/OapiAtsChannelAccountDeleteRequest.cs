using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.channel.account.delete
    /// </summary>
    public class OapiAtsChannelAccountDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsChannelAccountDeleteResponse>
    {
        /// <summary>
        /// 招聘业务码
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 渠道用户唯一标识
        /// </summary>
        public string ChannelUserIdentify { get; set; }

        /// <summary>
        /// 钉钉用户userId
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.channel.account.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("channel_user_identify", this.ChannelUserIdentify);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("channel_user_identify", this.ChannelUserIdentify);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
