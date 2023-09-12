using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.batchdelete
    /// </summary>
    public class OapiUserBatchdeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserBatchdeleteResponse>
    {
        /// <summary>
        /// 员工UserID列表。列表长度在1到20之间
        /// </summary>
        public List<string> Useridlist { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.batchdelete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("useridlist", TopUtils.ObjectToJson(this.Useridlist));
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("useridlist", this.Useridlist, 20);
        }

        #endregion
    }
}
