using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.copy
    /// </summary>
    public class OapiProcessCopyRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessCopyResponse>
    {
        /// <summary>
        /// 企业微应用标识
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 业务分类标识（建议采用JAVA包名的命名方式，）
        /// </summary>
        public string BizCategoryId { get; set; }

        /// <summary>
        /// 复制类型，1 不包含流程信息，2 包含流程信息且审批中员工可见。默认为1
        /// </summary>
        public Nullable<long> CopyType { get; set; }

        /// <summary>
        /// 审批流描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 审批流的唯一码
        /// </summary>
        public string ProcessCode { get; set; }

        /// <summary>
        /// 审批流名称
        /// </summary>
        public string ProcessName { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.copy";
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
            parameters.Add("copy_type", this.CopyType);
            parameters.Add("description", this.Description);
            parameters.Add("process_code", this.ProcessCode);
            parameters.Add("process_name", this.ProcessName);
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
            RequestValidator.ValidateRequired("process_code", this.ProcessCode);
            RequestValidator.ValidateMaxLength("process_name", this.ProcessName, 64);
        }

        #endregion
    }
}
