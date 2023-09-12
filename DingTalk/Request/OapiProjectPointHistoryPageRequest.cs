using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.project.point.history.page
    /// </summary>
    public class OapiProjectPointHistoryPageRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProjectPointHistoryPageResponse>
    {
        /// <summary>
        /// 数据游标，初始传0。后续传入返回参数中的next_cursor值
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 每页大小，最大200条
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 业务ID（固定值，农村积分传7001）
        /// </summary>
        public Nullable<long> TenantId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.project.point.history.page";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

        #endregion
    }
}
