using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workrecord.update
    /// </summary>
    public class OapiWorkrecordUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkrecordUpdateResponse>
    {
        /// <summary>
        /// 待办事项唯一id
        /// </summary>
        public string RecordId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workrecord.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("record_id", this.RecordId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("record_id", this.RecordId);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
