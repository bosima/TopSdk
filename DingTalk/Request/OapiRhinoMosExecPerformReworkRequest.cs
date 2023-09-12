using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.perform.rework
    /// </summary>
    public class OapiRhinoMosExecPerformReworkRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecPerformReworkResponse>
    {
        /// <summary>
        /// 执行上下文
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 要重新开始的工序执行ID
        /// </summary>
        public Nullable<long> ReworkStartId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 要失效的工序执行ID列表
        /// </summary>
        public string ToInactiveIds { get; set; }

        /// <summary>
        /// 系统参数
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.perform.rework";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("context", this.Context);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("rework_start_id", this.ReworkStartId);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("to_inactive_ids", this.ToInactiveIds);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("rework_start_id", this.ReworkStartId);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
            RequestValidator.ValidateRequired("to_inactive_ids", this.ToInactiveIds);
            RequestValidator.ValidateMaxListSize("to_inactive_ids", this.ToInactiveIds, 500);
        }

        #endregion
    }
}
