using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.user.associated_unionid.transfer
    /// </summary>
    public class OapiUserAssociatedUnionidTransferRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiUserAssociatedUnionidTransferResponse>
    {
        /// <summary>
        /// 用户统一ID
        /// </summary>
        public string AssociatedUnionid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.user.associated_unionid.transfer";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("associated_unionid", this.AssociatedUnionid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("associated_unionid", this.AssociatedUnionid);
        }

        #endregion
    }
}
