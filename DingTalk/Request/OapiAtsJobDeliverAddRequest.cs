using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.job.deliver.add
    /// </summary>
    public class OapiAtsJobDeliverAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsJobDeliverAddResponse>
    {
        /// <summary>
        /// 业务唯一标识，接入前请提前沟通
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 投递渠道, 接入前请提前沟通
        /// </summary>
        public string DeliverChannel { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        public string DeliverMsg { get; set; }

        /// <summary>
        /// 渠道中的一次职位外投的唯一id，如需要更新deliver_status该入参必传
        /// </summary>
        public string DeliverOuterId { get; set; }

        /// <summary>
        /// 投递中:created,投递失败:fail,投递成功:success,已下架:off_shelf
        /// </summary>
        public string DeliverStatus { get; set; }

        /// <summary>
        /// 智能招聘职位id
        /// </summary>
        public string JobId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.job.deliver.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("deliver_channel", this.DeliverChannel);
            parameters.Add("deliver_msg", this.DeliverMsg);
            parameters.Add("deliver_outer_id", this.DeliverOuterId);
            parameters.Add("deliver_status", this.DeliverStatus);
            parameters.Add("job_id", this.JobId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("deliver_channel", this.DeliverChannel);
            RequestValidator.ValidateRequired("deliver_status", this.DeliverStatus);
            RequestValidator.ValidateRequired("job_id", this.JobId);
        }

        #endregion
    }
}
