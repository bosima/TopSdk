using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.card.intelligent.empgroup.send
    /// </summary>
    public class OapiCardIntelligentEmpgroupSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCardIntelligentEmpgroupSendResponse>
    {
        /// <summary>
        /// 模版卡片注册的key
        /// </summary>
        public string MsgKey { get; set; }

        /// <summary>
        /// 卡片中需要填充的参数
        /// </summary>
        public string ParamJson { get; set; }

        /// <summary>
        /// 卡片接收成员列表，不填写为全部接收
        /// </summary>
        public string ReceiverList { get; set; }

        /// <summary>
        /// 卡片消息去重复，长度不能大于64
        /// </summary>
        public string Uuid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.card.intelligent.empgroup.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("msg_key", this.MsgKey);
            parameters.Add("param_json", this.ParamJson);
            parameters.Add("receiver_list", this.ReceiverList);
            parameters.Add("uuid", this.Uuid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("msg_key", this.MsgKey);
            RequestValidator.ValidateMaxListSize("receiver_list", this.ReceiverList, 999);
        }

        #endregion
    }
}
