using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.ccoservice.servicegroup.addmember
    /// </summary>
    public class CcoserviceServicegroupAddmemberRequest : BaseDingTalkRequest<DingTalk.Api.Response.CcoserviceServicegroupAddmemberResponse>
    {
        /// <summary>
        /// 服务群id
        /// </summary>
        public string OpenGroupId { get; set; }

        /// <summary>
        /// 企业员工id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.ccoservice.servicegroup.addmember";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_group_id", this.OpenGroupId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_group_id", this.OpenGroupId);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
