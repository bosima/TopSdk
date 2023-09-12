using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.card.task.today.list
    /// </summary>
    public class OapiEduCardTaskTodayListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCardTaskTodayListResponse>
    {
        /// <summary>
        /// 打卡类型,跳绳:jump
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// 用户userId
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.card.task.today.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("card_type", this.CardType);
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
