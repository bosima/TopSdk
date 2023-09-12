using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingmi.o2o.send
    /// </summary>
    public class OapiDingmiO2oSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingmiO2oSendResponse>
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public string MsgKey { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string MsgParam { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingmi.o2o.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("msg_key", this.MsgKey);
            parameters.Add("msg_param", this.MsgParam);
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
