using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.retail.user.unbind
    /// </summary>
    public class OapiRetailUserUnbindRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRetailUserUnbindResponse>
    {
        /// <summary>
        /// 中心组织下唯一Id
        /// </summary>
        public string AssociateUnionId { get; set; }

        /// <summary>
        /// 业务身份
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// 主帐号ID
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 子帐号ID
        /// </summary>
        public string SubOuterId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.retail.user.unbind";
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
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("sub_outer_id", this.SubOuterId);
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
