using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.perform.inactive
    /// </summary>
    public class OapiRhinoMosExecPerformInactiveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecPerformInactiveResponse>
    {
        /// <summary>
        /// 工序执行ID列表
        /// </summary>
        public string Ids { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 业务参数[这里先预留],这里是用户ID,比如钉钉用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.perform.inactive";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ids", this.Ids);
            parameters.Add("order_id", this.OrderId);
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
            RequestValidator.ValidateRequired("ids", this.Ids);
            RequestValidator.ValidateMaxListSize("ids", this.Ids, 500);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

        #endregion
    }
}
