using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.track.bind
    /// </summary>
    public class OapiRhinoMosExecTrackBindRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecTrackBindResponse>
    {
        /// <summary>
        /// 实体ID列表
        /// </summary>
        public string Entities { get; set; }

        /// <summary>
        /// 实体类型
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 追踪ID
        /// </summary>
        public string TrackId { get; set; }

        /// <summary>
        /// 追踪类型，吊挂或才RF
        /// </summary>
        public string TrackType { get; set; }

        /// <summary>
        /// 系统参数
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 工位
        /// </summary>
        public string WorkstationCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.track.bind";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("entities", this.Entities);
            parameters.Add("entity_type", this.EntityType);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("track_id", this.TrackId);
            parameters.Add("track_type", this.TrackType);
            parameters.Add("userid", this.Userid);
            parameters.Add("workstation_code", this.WorkstationCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("entities", this.Entities);
            RequestValidator.ValidateMaxListSize("entities", this.Entities, 500);
            RequestValidator.ValidateRequired("entity_type", this.EntityType);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
            RequestValidator.ValidateRequired("track_id", this.TrackId);
            RequestValidator.ValidateRequired("track_type", this.TrackType);
        }

        #endregion
    }
}
