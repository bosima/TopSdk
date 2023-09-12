using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.perform.context.add
    /// </summary>
    public class OapiRhinoMosExecPerformContextAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecPerformContextAddResponse>
    {
        /// <summary>
        /// 上下文
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// 工序执行记录ID列表
        /// </summary>
        public string OperationRecordIds { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 业务参数，先预留ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.perform.context.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("context", this.Context);
            parameters.Add("operation_record_ids", this.OperationRecordIds);
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
            RequestValidator.ValidateRequired("context", this.Context);
            RequestValidator.ValidateRequired("operation_record_ids", this.OperationRecordIds);
            RequestValidator.ValidateMaxListSize("operation_record_ids", this.OperationRecordIds, 100);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

        #endregion
    }
}
