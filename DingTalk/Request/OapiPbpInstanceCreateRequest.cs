using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.pbp.instance.create
    /// </summary>
    public class OapiPbpInstanceCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPbpInstanceCreateResponse>
    {
        /// <summary>
        /// 是否启用，建议传入该参数，只有启用状态的实例才允许打卡。如果不传入该参数，则实例默认为“已创建”状态而非“启用”状态。
        /// </summary>
        public Nullable<bool> Active { get; set; }

        /// <summary>
        /// 业务id，接入时由系统分配
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 实例结束时间，时间戳
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 外部id，唯一对应一次业务实例，如一次会议的meeting_id
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 实例开始时间，时间戳
        /// </summary>
        public Nullable<long> StartTime { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.pbp.instance.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("active", this.Active);
            parameters.Add("biz_id", this.BizId);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("start_time", this.StartTime);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_id", this.BizId);
            RequestValidator.ValidateRequired("outer_id", this.OuterId);
        }

        #endregion
    }
}
