using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingtax.groupdaudata.get
    /// </summary>
    public class OapiDingtaxGroupdaudataGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingtaxGroupdaudataGetResponse>
    {
        /// <summary>
        /// 开放群ID列表
        /// </summary>
        public string OpenConversationIdList { get; set; }

        /// <summary>
        /// 统计日期(格式为 yyyymmdd)
        /// </summary>
        public string StatDate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingtax.groupdaudata.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_conversation_id_list", this.OpenConversationIdList);
            parameters.Add("stat_date", this.StatDate);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_conversation_id_list", this.OpenConversationIdList);
            RequestValidator.ValidateMaxListSize("open_conversation_id_list", this.OpenConversationIdList, 999);
            RequestValidator.ValidateRequired("stat_date", this.StatDate);
        }

        #endregion
    }
}
