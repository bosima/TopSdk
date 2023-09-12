using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.live.grouplive.list
    /// </summary>
    public class OapiLiveGroupliveListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiLiveGroupliveListResponse>
    {
        /// <summary>
        /// 群id
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 截止时间ms
        /// </summary>
        public Nullable<long> FromTime { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public Nullable<long> OpenId { get; set; }

        /// <summary>
        /// 开始时间ms
        /// </summary>
        public Nullable<long> ToTime { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.live.grouplive.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cid", this.Cid);
            parameters.Add("from_time", this.FromTime);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("to_time", this.ToTime);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cid", this.Cid);
        }

        #endregion
    }
}
