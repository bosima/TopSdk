using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.smartwork.attends.getusergroup
    /// </summary>
    public class SmartworkAttendsGetusergroupRequest : BaseDingTalkRequest<DingTalk.Api.Response.SmartworkAttendsGetusergroupResponse>
    {
        /// <summary>
        /// 员工在企业内的UserID，企业用来唯一标识用户的字段。
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.smartwork.attends.getusergroup";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
