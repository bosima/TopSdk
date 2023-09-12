using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.fugong.health_data.list
    /// </summary>
    public class OapiFugongHealthDataListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiFugongHealthDataListResponse>
    {
        /// <summary>
        /// 时间，必须是YYYY-MM-DD的格式
        /// </summary>
        public string ActionDate { get; set; }

        /// <summary>
        /// 分页起始
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 复工审批实例id
        /// </summary>
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 分页大小，最大100
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.fugong.health_data.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("action_date", this.ActionDate);
            parameters.Add("offset", this.Offset);
            parameters.Add("process_instance_id", this.ProcessInstanceId);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("action_date", this.ActionDate);
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateRequired("process_instance_id", this.ProcessInstanceId);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
