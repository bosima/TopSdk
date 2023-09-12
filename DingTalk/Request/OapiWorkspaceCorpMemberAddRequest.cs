using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.corp.member.add
    /// </summary>
    public class OapiWorkspaceCorpMemberAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceCorpMemberAddResponse>
    {
        /// <summary>
        /// 加人的成员列表
        /// </summary>
        public string MemberAddDtoList { get; set; }

        public List<OpenMemberAddDtoDomain> MemberAddDtoList_ { set { this.MemberAddDtoList = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 目标加人组织
        /// </summary>
        public string TargetCorpId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.corp.member.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("member_add_dto_list", this.MemberAddDtoList);
            parameters.Add("target_corp_id", this.TargetCorpId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("member_add_dto_list", this.MemberAddDtoList, 20);
        }

	/// <summary>
/// OpenMemberAddDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenMemberAddDtoDomain : TopObject
{
	        /// <summary>
	        /// 成员来源组织
	        /// </summary>
	        [XmlElement("from_corp_id")]
	        public string FromCorpId { get; set; }
	
	        /// <summary>
	        /// 来源组织成员userId
	        /// </summary>
	        [XmlElement("from_userid")]
	        public string FromUserid { get; set; }
	
	        /// <summary>
	        /// 目标组织userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
