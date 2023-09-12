using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.perform.query
    /// </summary>
    public class OapiRhinoMosExecPerformQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecPerformQueryResponse>
    {
        /// <summary>
        /// 生效条件
        /// </summary>
        public string ActiveCondition { get; set; }

        /// <summary>
        /// 实体ID列表
        /// </summary>
        public string EntityIds { get; set; }

        /// <summary>
        /// 实体类型
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// 工序列表
        /// </summary>
        public string OperationUids { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 执行状态
        /// </summary>
        public string PerformStatusList { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 业务参数[这里先预留],这里是用户ID,比如钉钉用户ID
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 执行工位列表
        /// </summary>
        public string WorkstationCodes { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.perform.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("active_condition", this.ActiveCondition);
            parameters.Add("entity_ids", this.EntityIds);
            parameters.Add("entity_type", this.EntityType);
            parameters.Add("operation_uids", this.OperationUids);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("perform_status_list", this.PerformStatusList);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("userid", this.Userid);
            parameters.Add("workstation_codes", this.WorkstationCodes);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("entity_ids", this.EntityIds, 500);
            RequestValidator.ValidateRequired("entity_type", this.EntityType);
            RequestValidator.ValidateMaxListSize("operation_uids", this.OperationUids, 500);
            RequestValidator.ValidateMaxListSize("perform_status_list", this.PerformStatusList, 20);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
            RequestValidator.ValidateMaxListSize("workstation_codes", this.WorkstationCodes, 20);
        }

        #endregion
    }
}
