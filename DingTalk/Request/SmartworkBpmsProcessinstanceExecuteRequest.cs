using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.smartwork.bpms.processinstance.execute
    /// </summary>
    public class SmartworkBpmsProcessinstanceExecuteRequest : BaseDingTalkRequest<DingTalk.Api.Response.SmartworkBpmsProcessinstanceExecuteResponse>
    {
        /// <summary>
        /// 操作人id，通过dingtalk.smartwork.bpms.processinstance.get这个接口可以获取
        /// </summary>
        public string ActionerUserid { get; set; }

        /// <summary>
        /// 审批实例id
        /// </summary>
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 操作评论，可为空
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 审批操作，同意-agree，拒绝-refuse
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 任务节点id，dingtalk.smartwork.bpms.processinstance.get接口可获取
        /// </summary>
        public Nullable<long> TaskId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.smartwork.bpms.processinstance.execute";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("actioner_userid", this.ActionerUserid);
            parameters.Add("process_instance_id", this.ProcessInstanceId);
            parameters.Add("remark", this.Remark);
            parameters.Add("result", this.Result);
            parameters.Add("task_id", this.TaskId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("actioner_userid", this.ActionerUserid);
            RequestValidator.ValidateRequired("process_instance_id", this.ProcessInstanceId);
            RequestValidator.ValidateMaxLength("remark", this.Remark, 2000);
            RequestValidator.ValidateRequired("result", this.Result);
            RequestValidator.ValidateRequired("task_id", this.TaskId);
        }

        #endregion
    }
}
