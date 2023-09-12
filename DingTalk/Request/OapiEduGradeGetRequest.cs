using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.grade.get
    /// </summary>
    public class OapiEduGradeGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduGradeGetResponse>
    {
        /// <summary>
        /// 年级ID
        /// </summary>
        public Nullable<long> GradeId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.grade.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("grade_id", this.GradeId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("grade_id", this.GradeId);
        }

        #endregion
    }
}
