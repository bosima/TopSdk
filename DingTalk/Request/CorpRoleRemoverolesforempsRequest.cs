using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.role.removerolesforemps
    /// </summary>
    public class CorpRoleRemoverolesforempsRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpRoleRemoverolesforempsResponse>
    {
        /// <summary>
        /// 角色标签id
        /// </summary>
        public string RoleidList { get; set; }

        /// <summary>
        /// 用户userId
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.role.removerolesforemps";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("roleid_list", this.RoleidList);
            parameters.Add("userid_list", this.UseridList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("roleid_list", this.RoleidList);
            RequestValidator.ValidateMaxListSize("roleid_list", this.RoleidList, 20);
            RequestValidator.ValidateRequired("userid_list", this.UseridList);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 100);
        }

        #endregion
    }
}
