using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.perform.start
    /// </summary>
    public class OapiRhinoMosExecPerformStartRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecPerformStartResponse>
    {
        /// <summary>
        /// 执行设备ID列表
        /// </summary>
        public string DeviceIds { get; set; }

        /// <summary>
        /// 工序执行记录ID列表
        /// </summary>
        public string OperationPerformRecordIds { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 系统参数
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 执行员工列表
        /// </summary>
        public string WorkNos { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.perform.start";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_ids", this.DeviceIds);
            parameters.Add("operation_perform_record_ids", this.OperationPerformRecordIds);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("userid", this.Userid);
            parameters.Add("work_nos", this.WorkNos);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("device_ids", this.DeviceIds, 500);
            RequestValidator.ValidateRequired("operation_perform_record_ids", this.OperationPerformRecordIds);
            RequestValidator.ValidateMaxListSize("operation_perform_record_ids", this.OperationPerformRecordIds, 500);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
            RequestValidator.ValidateMaxListSize("work_nos", this.WorkNos, 500);
        }

        #endregion
    }
}
