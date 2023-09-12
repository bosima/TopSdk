using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingmi.common.login.accesstoken
    /// </summary>
    public class OapiDingmiCommonLoginAccesstokenRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingmiCommonLoginAccesstokenResponse>
    {
        /// <summary>
        /// 用户外部系统id
        /// </summary>
        public string ForeignId { get; set; }

        /// <summary>
        /// 登录用户昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 业务账号登录source
        /// </summary>
        public Nullable<long> Source { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingmi.common.login.accesstoken";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("foreign_id", this.ForeignId);
            parameters.Add("nick", this.Nick);
            parameters.Add("source", this.Source);
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
