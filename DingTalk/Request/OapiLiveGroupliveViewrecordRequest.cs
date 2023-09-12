using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.live.grouplive.viewrecord
    /// </summary>
    public class OapiLiveGroupliveViewrecordRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiLiveGroupliveViewrecordResponse>
    {
        /// <summary>
        /// 部门id
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        /// <summary>
        /// 直播uuid
        /// </summary>
        public string LiveUuid { get; set; }

        /// <summary>
        /// 分页拉取
        /// </summary>
        public Nullable<long> PageIndex { get; set; }

        /// <summary>
        /// 一页多少数据，默认100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.live.grouplive.viewrecord";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dept_id", this.DeptId);
            parameters.Add("live_uuid", this.LiveUuid);
            parameters.Add("page_index", this.PageIndex);
            parameters.Add("page_size", this.PageSize);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("dept_id", this.DeptId);
            RequestValidator.ValidateRequired("live_uuid", this.LiveUuid);
            RequestValidator.ValidateRequired("page_index", this.PageIndex);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

        #endregion
    }
}
