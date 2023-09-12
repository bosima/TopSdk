using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.sync
    /// </summary>
    public class OapiProcessSyncRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessSyncResponse>
    {
        /// <summary>
        /// 企业微应用标识
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 业务分类标识（建议采用JAVA包名的命名方式,如:com.alibaba）
        /// </summary>
        public string BizCategoryId { get; set; }

        /// <summary>
        /// 审批流名称
        /// </summary>
        public string ProcessName { get; set; }

        /// <summary>
        /// 源审批流的唯一码
        /// </summary>
        public string SrcProcessCode { get; set; }

        /// <summary>
        /// 目标审批流的唯一码
        /// </summary>
        public string TargetProcessCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.sync";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("biz_category_id", this.BizCategoryId);
            parameters.Add("process_name", this.ProcessName);
            parameters.Add("src_process_code", this.SrcProcessCode);
            parameters.Add("target_process_code", this.TargetProcessCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateMaxLength("biz_category_id", this.BizCategoryId, 64);
            RequestValidator.ValidateMaxLength("process_name", this.ProcessName, 64);
            RequestValidator.ValidateRequired("src_process_code", this.SrcProcessCode);
            RequestValidator.ValidateRequired("target_process_code", this.TargetProcessCode);
        }

        #endregion
    }
}
