using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.health.stepinfo.listbyuserid
    /// </summary>
    public class OapiHealthStepinfoListbyuseridRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiHealthStepinfoListbyuseridResponse>
    {
        /// <summary>
        /// 时间，注意时间格式是YYMMDD
        /// </summary>
        public string StatDate { get; set; }

        /// <summary>
        /// 员工userid列表，最多传50个
        /// </summary>
        public string Userids { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.health.stepinfo.listbyuserid";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("stat_date", this.StatDate);
            parameters.Add("userids", this.Userids);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("stat_date", this.StatDate);
            RequestValidator.ValidateRequired("userids", this.Userids);
            RequestValidator.ValidateMaxListSize("userids", this.Userids, 50);
        }

        #endregion
    }
}
