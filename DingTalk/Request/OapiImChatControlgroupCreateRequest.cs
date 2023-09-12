using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.im.chat.controlgroup.create
    /// </summary>
    public class OapiImChatControlgroupCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImChatControlgroupCreateResponse>
    {
        /// <summary>
        /// 群的管理权限设置，0-所有人可管理（默认），1-仅群主和群管理员可管理
        /// </summary>
        public Nullable<long> AuthorityType { get; set; }

        /// <summary>
        /// goc模拟群：goc， 网商银行群：eCommerce
        /// </summary>
        public string GroupType { get; set; }

        /// <summary>
        /// 建群去重的业务id
        /// </summary>
        public string GroupUniqId { get; set; }

        /// <summary>
        /// 群成员在钉钉组织内的userid列表
        /// </summary>
        public string MemberUserids { get; set; }

        /// <summary>
        /// 群主在钉钉组织内的userid
        /// </summary>
        public string OwnerUserid { get; set; }

        /// <summary>
        /// 群标题
        /// </summary>
        public string Title { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.im.chat.controlgroup.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("authority_type", this.AuthorityType);
            parameters.Add("group_type", this.GroupType);
            parameters.Add("group_uniq_id", this.GroupUniqId);
            parameters.Add("member_userids", this.MemberUserids);
            parameters.Add("owner_userid", this.OwnerUserid);
            parameters.Add("title", this.Title);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("member_userids", this.MemberUserids);
            RequestValidator.ValidateMaxListSize("member_userids", this.MemberUserids, 20);
            RequestValidator.ValidateRequired("owner_userid", this.OwnerUserid);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 256);
        }

        #endregion
    }
}
