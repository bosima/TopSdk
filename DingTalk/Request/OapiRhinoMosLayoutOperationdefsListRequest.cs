using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.layout.operationdefs.list
    /// </summary>
    public class OapiRhinoMosLayoutOperationdefsListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosLayoutOperationdefsListResponse>
    {
        /// <summary>
        /// 版本：如果为空，查生效版本；不为空，查指定版本
        /// </summary>
        public Nullable<long> FlowVersion { get; set; }

        /// <summary>
        /// 是否需要分配信息
        /// </summary>
        public Nullable<bool> NeedAssignInfo { get; set; }

        /// <summary>
        /// 工序唯一ID
        /// </summary>
        public string OperationUids { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 查询暂存版本
        /// </summary>
        public Nullable<bool> TmpSave { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.layout.operationdefs.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("flow_version", this.FlowVersion);
            parameters.Add("need_assignInfo", this.NeedAssignInfo);
            parameters.Add("operation_uids", this.OperationUids);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("tmp_save", this.TmpSave);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("need_assignInfo", this.NeedAssignInfo);
            RequestValidator.ValidateRequired("operation_uids", this.OperationUids);
            RequestValidator.ValidateMaxListSize("operation_uids", this.OperationUids, 2000);
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

        #endregion
    }
}
