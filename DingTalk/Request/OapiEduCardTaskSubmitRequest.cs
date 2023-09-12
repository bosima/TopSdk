using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.card.task.submit
    /// </summary>
    public class OapiEduCardTaskSubmitRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCardTaskSubmitResponse>
    {
        /// <summary>
        /// 打卡类型,跳绳:jump
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// 打卡内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 计量数量
        /// </summary>
        public string MeteringNumber { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        public Nullable<long> UserCardTaskId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.card.task.submit";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("card_type", this.CardType);
            parameters.Add("content", this.Content);
            parameters.Add("metering_number", this.MeteringNumber);
            parameters.Add("user_card_task_id", this.UserCardTaskId);
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
