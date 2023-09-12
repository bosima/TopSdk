using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.kac.openlive.white_users.list
    /// </summary>
    public class OapiKacOpenliveWhiteUsersListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiKacOpenliveWhiteUsersListResponse>
    {
        /// <summary>
        /// 直播id
        /// </summary>
        public string LiveId { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        public Nullable<long> PageStart { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.kac.openlive.white_users.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("live_id", this.LiveId);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("page_start", this.PageStart);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("live_id", this.LiveId);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("page_start", this.PageStart);
        }

        #endregion
    }
}
