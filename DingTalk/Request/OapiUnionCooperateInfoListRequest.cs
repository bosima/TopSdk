using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.union.cooperate.info.list
    /// </summary>
    public class OapiUnionCooperateInfoListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUnionCooperateInfoListResponse>
    {
        /// <summary>
        /// 加入的状态：0申请中 1审核通过成功加入
        /// </summary>
        public Nullable<long> Status { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.union.cooperate.info.list";
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
