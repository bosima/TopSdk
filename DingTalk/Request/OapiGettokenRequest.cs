using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.gettoken
    /// </summary>
    public class OapiGettokenRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiGettokenResponse>
    {
        /// <summary>
        /// 应用的唯一标识key
        /// </summary>
        public string Appkey { get; set; }

        /// <summary>
        /// 应用的密钥
        /// </summary>
        public string Appsecret { get; set; }

        /// <summary>
        /// 企业的corpid
        /// </summary>
        public string Corpid { get; set; }

        /// <summary>
        /// 企业的密钥
        /// </summary>
        public string Corpsecret { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.gettoken";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("appkey", this.Appkey);
            parameters.Add("appsecret", this.Appsecret);
            parameters.Add("corpid", this.Corpid);
            parameters.Add("corpsecret", this.Corpsecret);
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
