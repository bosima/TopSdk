using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.authorization.rbac.role.member.add
    /// </summary>
    public class OapiAuthorizationRbacRoleMemberAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAuthorizationRbacRoleMemberAddResponse>
    {
        /// <summary>
        /// 成员列表
        /// </summary>
        public string AddMembers { get; set; }

        public List<OpenMemberVoDomain> AddMembers_ { set { this.AddMembers = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 微应用agenId,需要联系权限平台配置
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 管理组id
        /// </summary>
        public string OpenRoleId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.authorization.rbac.role.member.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("add_members", this.AddMembers);
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("open_role_id", this.OpenRoleId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("add_members", this.AddMembers);
            RequestValidator.ValidateObjectMaxListSize("add_members", this.AddMembers, 999);
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("open_role_id", this.OpenRoleId);
        }

	/// <summary>
/// OpenMemberVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenMemberVoDomain : TopObject
{
	        /// <summary>
	        /// member所属corpid
	        /// </summary>
	        [XmlElement("belong_corpid")]
	        public string BelongCorpid { get; set; }
	
	        /// <summary>
	        /// member id
	        /// </summary>
	        [XmlElement("member_id")]
	        public string MemberId { get; set; }
	
	        /// <summary>
	        /// 成员类型
	        /// </summary>
	        [XmlElement("member_type")]
	        public string MemberType { get; set; }
	
	        /// <summary>
	        /// 操作人userid
	        /// </summary>
	        [XmlElement("operate_userid")]
	        public string OperateUserid { get; set; }
}

        #endregion
    }
}
