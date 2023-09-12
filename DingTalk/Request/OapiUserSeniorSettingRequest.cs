using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.senior.setting
    /// </summary>
    public class OapiUserSeniorSettingRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserSeniorSettingResponse>
    {
        /// <summary>
        /// 高管模式是否开启
        /// </summary>
        public Nullable<bool> Open { get; set; }

        /// <summary>
        /// 高管联系人白名单
        /// </summary>
        public string PermitStaffIds { get; set; }

        /// <summary>
        /// 高管保护开关，例如DING_SMS，保护高管不受短信DING打扰
        /// </summary>
        public string ProtectScenes { get; set; }

        /// <summary>
        /// 高管工号
        /// </summary>
        public string SeniorStaffId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.senior.setting";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open", this.Open);
            parameters.Add("permit_staffIds", this.PermitStaffIds);
            parameters.Add("protect_scenes", this.ProtectScenes);
            parameters.Add("senior_staffId", this.SeniorStaffId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("permit_staffIds", this.PermitStaffIds, 999);
            RequestValidator.ValidateMaxListSize("protect_scenes", this.ProtectScenes, 999);
        }

        #endregion
    }
}
