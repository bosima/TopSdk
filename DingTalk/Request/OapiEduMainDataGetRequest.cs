using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.main.data.get
    /// </summary>
    public class OapiEduMainDataGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduMainDataGetResponse>
    {
        /// <summary>
        /// 统计日期
        /// </summary>
        public string StatDate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.main.data.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("stat_date", this.StatDate);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("stat_date", this.StatDate);
        }

        #endregion
    }
}
