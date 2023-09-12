using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.advanced.service.unbind
    /// </summary>
    public class OapiAttendanceAdvancedServiceUnbindRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceAdvancedServiceUnbindResponse>
    {
        /// <summary>
        /// 实体id
        /// </summary>
        public string EntityId { get; set; }

        /// <summary>
        /// 实体类型，目前支持user,group,corp
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// 操作者userid
        /// </summary>
        public string OpUserid { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        public Nullable<long> ServiceId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.advanced.service.unbind";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("entity_id", this.EntityId);
            parameters.Add("entity_type", this.EntityType);
            parameters.Add("op_userid", this.OpUserid);
            parameters.Add("service_id", this.ServiceId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("entity_id", this.EntityId);
            RequestValidator.ValidateRequired("entity_type", this.EntityType);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
            RequestValidator.ValidateRequired("service_id", this.ServiceId);
        }

        #endregion
    }
}
