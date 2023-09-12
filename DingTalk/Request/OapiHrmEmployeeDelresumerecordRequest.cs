using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.hrm.employee.delresumerecord
    /// </summary>
    public class OapiHrmEmployeeDelresumerecordRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiHrmEmployeeDelresumerecordResponse>
    {
        /// <summary>
        /// 成长记录唯一标识
        /// </summary>
        public string ResumeId { get; set; }

        /// <summary>
        /// 员工userid
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.hrm.employee.delresumerecord";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("resume_id", this.ResumeId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("resume_id", this.ResumeId);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
