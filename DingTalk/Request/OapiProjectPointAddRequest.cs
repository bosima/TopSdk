using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.project.point.add
    /// </summary>
    public class OapiProjectPointAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProjectPointAddResponse>
    {
        /// <summary>
        /// 增加积分的时间戳毫秒数，如果为空使用系统当前毫秒数
        /// </summary>
        public Nullable<long> ActionTime { get; set; }

        /// <summary>
        /// 规则代码（可空）,如果不为空的话，score值使用ruleCode对应的score增加分数
        /// </summary>
        public string RuleCode { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        public string RuleName { get; set; }

        /// <summary>
        /// 本次增加积分：正数表示增加/负数表示扣减
        /// </summary>
        public Nullable<long> Score { get; set; }

        /// <summary>
        /// 业务ID（固定值，农村积分传7001）
        /// </summary>
        public Nullable<long> TenantId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 加积分的唯一幂等标志,建议使用UUID
        /// </summary>
        public string Uuid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.project.point.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("action_time", this.ActionTime);
            parameters.Add("rule_code", this.RuleCode);
            parameters.Add("rule_name", this.RuleName);
            parameters.Add("score", this.Score);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("userid", this.Userid);
            parameters.Add("uuid", this.Uuid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("action_time", this.ActionTime);
            RequestValidator.ValidateRequired("rule_name", this.RuleName);
            RequestValidator.ValidateRequired("score", this.Score);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
            RequestValidator.ValidateRequired("userid", this.Userid);
            RequestValidator.ValidateRequired("uuid", this.Uuid);
        }

        #endregion
    }
}
