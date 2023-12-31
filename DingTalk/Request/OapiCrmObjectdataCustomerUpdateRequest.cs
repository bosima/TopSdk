using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.crm.objectdata.customer.update
    /// </summary>
    public class OapiCrmObjectdataCustomerUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCrmObjectdataCustomerUpdateResponse>
    {
        /// <summary>
        /// 客户数据
        /// </summary>
        public string Instance { get; set; }

        public ObjectDataInstanceVoDomain Instance_ { set { this.Instance = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.crm.objectdata.customer.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("instance", this.Instance);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("instance", this.Instance);
        }

	/// <summary>
/// DataPermissionVoDomain Data Structure.
/// </summary>
[Serializable]

public class DataPermissionVoDomain : TopObject
{
	        /// <summary>
	        /// 负责人的用户ID
	        /// </summary>
	        [XmlArray("owner_userids")]
	        [XmlArrayItem("string")]
	        public List<string> OwnerUserids { get; set; }
	
	        /// <summary>
	        /// 协同人的用户ID
	        /// </summary>
	        [XmlArray("participant_userids")]
	        [XmlArrayItem("string")]
	        public List<string> ParticipantUserids { get; set; }
}

	/// <summary>
/// ObjectDataInstanceVoDomain Data Structure.
/// </summary>
[Serializable]

public class ObjectDataInstanceVoDomain : TopObject
{
	        /// <summary>
	        /// 公海领取客户：publicDraw 公海分配客户：publicAssign 其余场景：（不用传）
	        /// </summary>
	        [XmlElement("action")]
	        public string Action { get; set; }
	
	        /// <summary>
	        /// 数据内容
	        /// </summary>
	        [XmlElement("data")]
	        public string Data { get; set; }
	
	        /// <summary>
	        /// 扩展数据内容
	        /// </summary>
	        [XmlElement("extend_data")]
	        public string ExtendData { get; set; }
	
	        /// <summary>
	        /// 客户数据id
	        /// </summary>
	        [XmlElement("instance_id")]
	        public string InstanceId { get; set; }
	
	        /// <summary>
	        /// 修改的钉钉用户nick
	        /// </summary>
	        [XmlElement("modifier_nick")]
	        public string ModifierNick { get; set; }
	
	        /// <summary>
	        /// 修改的钉钉用户id
	        /// </summary>
	        [XmlElement("modifier_userid")]
	        public string ModifierUserid { get; set; }
	
	        /// <summary>
	        /// 权限
	        /// </summary>
	        [XmlElement("permission")]
	        public DataPermissionVoDomain Permission { get; set; }
	
	        /// <summary>
	        /// 跳过查重
	        /// </summary>
	        [XmlElement("skip_duplicate_check")]
	        public Nullable<bool> SkipDuplicateCheck { get; set; }
}

        #endregion
    }
}
