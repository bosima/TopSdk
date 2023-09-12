using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.union.cooperate.joined.list
    /// </summary>
    public class OapiUnionCooperateJoinedListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUnionCooperateJoinedListResponse>
    {
        /// <summary>
        /// 加入空间的状态 0：申请中的 1：成功加入的
        /// </summary>
        public Nullable<long> Status { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.union.cooperate.joined.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("status", this.Status);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("status", this.Status);
        }

        #endregion
    }
}
