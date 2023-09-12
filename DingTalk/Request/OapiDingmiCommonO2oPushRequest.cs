using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingmi.common.o2o.push
    /// </summary>
    public class OapiDingmiCommonO2oPushRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingmiCommonO2oPushResponse>
    {
        /// <summary>
        /// 机器人id
        /// </summary>
        public string ChatbotId { get; set; }

        /// <summary>
        /// 模板key
        /// </summary>
        public string MsgKey { get; set; }

        /// <summary>
        /// 模块替换值
        /// </summary>
        public string MsgParam { get; set; }

        /// <summary>
        /// 用户在服务号所在企业的用户id
        /// </summary>
        public string StaffId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingmi.common.o2o.push";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("chatbot_id", this.ChatbotId);
            parameters.Add("msg_key", this.MsgKey);
            parameters.Add("msg_param", this.MsgParam);
            parameters.Add("staff_id", this.StaffId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("msg_key", this.MsgKey);
            RequestValidator.ValidateRequired("msg_param", this.MsgParam);
            RequestValidator.ValidateRequired("staff_id", this.StaffId);
        }

        #endregion
    }
}
