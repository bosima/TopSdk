using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.call.calluser
    /// </summary>
    public class OapiCallCalluserRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCallCalluserResponse>
    {
        /// <summary>
        /// 授权isv套件企业的corpid
        /// </summary>
        public string AuthedCorpId { get; set; }

        /// <summary>
        /// 授权isv套件企业的员工userid
        /// </summary>
        public string AuthedStaffId { get; set; }

        /// <summary>
        /// isv套件所属企业下的员工userid
        /// </summary>
        public string StaffId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.call.calluser";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("authed_corp_id", this.AuthedCorpId);
            parameters.Add("authed_staff_id", this.AuthedStaffId);
            parameters.Add("staff_id", this.StaffId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("authed_corp_id", this.AuthedCorpId);
            RequestValidator.ValidateRequired("authed_staff_id", this.AuthedStaffId);
            RequestValidator.ValidateRequired("staff_id", this.StaffId);
        }

        #endregion
    }
}
