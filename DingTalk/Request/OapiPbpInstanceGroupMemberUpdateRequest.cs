using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.pbp.instance.group.member.update
    /// </summary>
    public class OapiPbpInstanceGroupMemberUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiPbpInstanceGroupMemberUpdateResponse>
    {
        /// <summary>
        /// 同步参数
        /// </summary>
        public string SyncParam { get; set; }

        public PunchGroupSyncMemberParamDomain SyncParam_ { set { this.SyncParam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.pbp.instance.group.member.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("sync_param", this.SyncParam);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("sync_param", this.SyncParam);
        }

	/// <summary>
/// PunchGroupMemberParamDomain Data Structure.
/// </summary>
[Serializable]

public class PunchGroupMemberParamDomain : TopObject
{
	        /// <summary>
	        /// 员工userId
	        /// </summary>
	        [XmlElement("member_id")]
	        public string MemberId { get; set; }
	
	        /// <summary>
	        /// 成员类型，0表示员工
	        /// </summary>
	        [XmlElement("type")]
	        public Nullable<long> Type { get; set; }
}

	/// <summary>
/// PunchGroupSyncMemberParamDomain Data Structure.
/// </summary>
[Serializable]

public class PunchGroupSyncMemberParamDomain : TopObject
{
	        /// <summary>
	        /// 新增成员列表
	        /// </summary>
	        [XmlArray("add_member_list")]
	        [XmlArrayItem("punch_group_member_param")]
	        public List<PunchGroupMemberParamDomain> AddMemberList { get; set; }
	
	        /// <summary>
	        /// 业务唯一标识
	        /// </summary>
	        [XmlElement("biz_id")]
	        public string BizId { get; set; }
	
	        /// <summary>
	        /// 业务实例唯一标识
	        /// </summary>
	        [XmlElement("biz_inst_id")]
	        public string BizInstId { get; set; }
	
	        /// <summary>
	        /// 删除成员列表
	        /// </summary>
	        [XmlArray("delete_member_list")]
	        [XmlArrayItem("punch_group_member_param")]
	        public List<PunchGroupMemberParamDomain> DeleteMemberList { get; set; }
	
	        /// <summary>
	        /// 打卡组唯一标识
	        /// </summary>
	        [XmlElement("punch_group_id")]
	        public string PunchGroupId { get; set; }
}

        #endregion
    }
}
