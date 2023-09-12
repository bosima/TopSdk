using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.user.list
    /// </summary>
    public class OapiEduUserListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduUserListResponse>
    {
        /// <summary>
        /// 班级id
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// 页码，从1开始
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 最大30条，最小1条
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 家校人员身份
        /// </summary>
        public string Role { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.user.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("class_id", this.ClassId);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("role", this.Role);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("class_id", this.ClassId);
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("role", this.Role);
        }

        #endregion
    }
}
