using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.kac.openlive.white_users.batch_add
    /// </summary>
    public class OapiKacOpenliveWhiteUsersBatchAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiKacOpenliveWhiteUsersBatchAddResponse>
    {
        /// <summary>
        /// 直播id
        /// </summary>
        public string LiveId { get; set; }

        /// <summary>
        /// 员工id列表
        /// </summary>
        public string UserIds { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.kac.openlive.white_users.batch_add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("live_id", this.LiveId);
            parameters.Add("user_ids", this.UserIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("live_id", this.LiveId);
            RequestValidator.ValidateRequired("user_ids", this.UserIds);
            RequestValidator.ValidateMaxListSize("user_ids", this.UserIds, 999);
        }

        #endregion
    }
}
