using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.role.getrolegroup
    /// </summary>
    public class CorpRoleGetrolegroupRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpRoleGetrolegroupResponse>
    {
        /// <summary>
        /// 角色组的Id
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.role.getrolegroup";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_id", this.GroupId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_id", this.GroupId);
        }

        #endregion
    }
}
