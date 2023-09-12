using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.crm.group.create
    /// </summary>
    public class OapiCrmGroupCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCrmGroupCreateResponse>
    {
        /// <summary>
        /// 需要入群的同事userId列表
        /// </summary>
        public string ColleagueUseridList { get; set; }

        /// <summary>
        /// 联系人userId列表
        /// </summary>
        public string ContactIdList { get; set; }

        /// <summary>
        /// 客户归属的企业id
        /// </summary>
        public string CustomerCorpid { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// 群主userId
        /// </summary>
        public string GroupOwner { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.crm.group.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("colleague_userid_list", this.ColleagueUseridList);
            parameters.Add("contact_id_list", this.ContactIdList);
            parameters.Add("customer_corpid", this.CustomerCorpid);
            parameters.Add("customer_id", this.CustomerId);
            parameters.Add("group_owner", this.GroupOwner);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("colleague_userid_list", this.ColleagueUseridList, 20);
            RequestValidator.ValidateMaxListSize("contact_id_list", this.ContactIdList, 20);
            RequestValidator.ValidateRequired("customer_corpid", this.CustomerCorpid);
            RequestValidator.ValidateRequired("customer_id", this.CustomerId);
            RequestValidator.ValidateRequired("group_owner", this.GroupOwner);
        }

        #endregion
    }
}
