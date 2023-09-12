using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.role.addrolesforemps
    /// </summary>
    public class CorpRoleAddrolesforempsRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpRoleAddrolesforempsResponse>
    {
        /// <summary>
        /// 角色id list
        /// </summary>
        public string RolelidList { get; set; }

        /// <summary>
        /// 员工id list
        /// </summary>
        public string UseridList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.role.addrolesforemps";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("rolelid_list", this.RolelidList);
            parameters.Add("userid_list", this.UseridList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("rolelid_list", this.RolelidList);
            RequestValidator.ValidateMaxListSize("rolelid_list", this.RolelidList, 20);
            RequestValidator.ValidateRequired("userid_list", this.UseridList);
            RequestValidator.ValidateMaxListSize("userid_list", this.UseridList, 100);
        }

        #endregion
    }
}
