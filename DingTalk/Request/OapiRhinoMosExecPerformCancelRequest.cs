using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.perform.cancel
    /// </summary>
    public class OapiRhinoMosExecPerformCancelRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecPerformCancelResponse>
    {
        /// <summary>
        /// 执行上下文
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// 工序执行记录ID列表
        /// </summary>
        public string OperationPerformRecordIds { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 是否停止调度
        /// </summary>
        public Nullable<bool> StopSchedule { get; set; }

        /// <summary>
        /// 租户ID列表
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 系统参数
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.perform.cancel";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("context", this.Context);
            parameters.Add("operation_perform_record_ids", this.OperationPerformRecordIds);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("stop_schedule", this.StopSchedule);
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
            RequestValidator.ValidateRequired("operation_perform_record_ids", this.OperationPerformRecordIds);
            RequestValidator.ValidateMaxListSize("operation_perform_record_ids", this.OperationPerformRecordIds, 500);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

        #endregion
    }
}
