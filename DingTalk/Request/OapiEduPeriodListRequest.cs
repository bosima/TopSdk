using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.period.list
    /// </summary>
    public class OapiEduPeriodListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduPeriodListResponse>
    {
        /// <summary>
        /// 校区ID
        /// </summary>
        public Nullable<long> CampusId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.period.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("campus_id", this.CampusId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("campus_id", this.CampusId);
        }

        #endregion
    }
}
