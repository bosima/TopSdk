using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.crm.contact.create
    /// </summary>
    public class OapiCrmContactCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCrmContactCreateResponse>
    {
        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        public string ContactPhone { get; set; }

        /// <summary>
        /// 联系人职位
        /// </summary>
        public string ContactPositionList { get; set; }

        /// <summary>
        /// 创建人用户 ID
        /// </summary>
        public string CreatorUserid { get; set; }

        /// <summary>
        /// 所在客户实例 ID
        /// </summary>
        public string CustomerInstanceId { get; set; }

        /// <summary>
        /// 服务商组织id, 特殊场景使用，丁税宝客户自建应用时传入对应的丁税宝服务商id用以生成 UnionId 关联自然人
        /// </summary>
        public string ProviderCorpid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.crm.contact.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("contact_name", this.ContactName);
            parameters.Add("contact_phone", this.ContactPhone);
            parameters.Add("contact_position_list", this.ContactPositionList);
            parameters.Add("creator_userid", this.CreatorUserid);
            parameters.Add("customer_instance_id", this.CustomerInstanceId);
            parameters.Add("provider_corpid", this.ProviderCorpid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("contact_name", this.ContactName);
            RequestValidator.ValidateMaxLength("contact_name", this.ContactName, 20);
            RequestValidator.ValidateRequired("contact_phone", this.ContactPhone);
            RequestValidator.ValidateMaxLength("contact_phone", this.ContactPhone, 15);
            RequestValidator.ValidateMaxListSize("contact_position_list", this.ContactPositionList, 999);
            RequestValidator.ValidateRequired("creator_userid", this.CreatorUserid);
            RequestValidator.ValidateRequired("customer_instance_id", this.CustomerInstanceId);
            RequestValidator.ValidateMaxLength("customer_instance_id", this.CustomerInstanceId, 50);
        }

        #endregion
    }
}
