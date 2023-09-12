using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.retail.user.bindquery
    /// </summary>
    public class OapiRetailUserBindqueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRetailUserBindqueryResponse>
    {
        /// <summary>
        /// 虚拟组织下的唯一ID
        /// </summary>
        public string AssociateUnionId { get; set; }

        /// <summary>
        /// 业务身份
        /// </summary>
        public string Channel { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.retail.user.bindquery";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("associate_union_id", this.AssociateUnionId);
            parameters.Add("channel", this.Channel);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
