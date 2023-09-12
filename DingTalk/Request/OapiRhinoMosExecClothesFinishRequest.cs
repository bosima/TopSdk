using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.clothes.finish
    /// </summary>
    public class OapiRhinoMosExecClothesFinishRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecClothesFinishResponse>
    {
        /// <summary>
        /// 衣服ID列表
        /// </summary>
        public string EntityIds { get; set; }

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
            return "dingtalk.oapi.rhino.mos.exec.clothes.finish";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("entity_ids", this.EntityIds);
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
            RequestValidator.ValidateRequired("entity_ids", this.EntityIds);
            RequestValidator.ValidateMaxListSize("entity_ids", this.EntityIds, 500);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

        #endregion
    }
}
