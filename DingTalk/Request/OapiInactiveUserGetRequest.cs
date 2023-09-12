using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.inactive.user.get
    /// </summary>
    public class OapiInactiveUserGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiInactiveUserGetResponse>
    {
        /// <summary>
        /// 获取数据偏移量，从0开始
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 查询日期
        /// </summary>
        public string QueryDate { get; set; }

        /// <summary>
        /// 获取数据size,最大100
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.inactive.user.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("offset", this.Offset);
            parameters.Add("query_date", this.QueryDate);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateRequired("query_date", this.QueryDate);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
