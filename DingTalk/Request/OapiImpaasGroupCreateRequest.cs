using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.group.create
    /// </summary>
    public class OapiImpaasGroupCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasGroupCreateResponse>
    {
        /// <summary>
        /// 创建群请求对象
        /// </summary>
        public string Request { get; set; }

        public CreateGroupRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.group.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// BaseGroupMemberInfoDomain Data Structure.
/// </summary>
[Serializable]

public class BaseGroupMemberInfoDomain : TopObject
{
	        /// <summary>
	        /// 创建者账号ID，类型由type字段决定
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 账号ID类型，当type=staff时，id填写staffid，当type=channelUser时，id字段填写channelUserId
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// CreateGroupRequestDomain Data Structure.
/// </summary>
[Serializable]

public class CreateGroupRequestDomain : TopObject
{
	        /// <summary>
	        /// 接入方channel信息，该值由接入方接入IMPaaS平台时，向IMPaaS平台申请，例如“hema”“eleme”等。
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 创建者
	        /// </summary>
	        [XmlElement("creater")]
	        public BaseGroupMemberInfoDomain Creater { get; set; }
	
	        /// <summary>
	        /// 二级会话入口ID
	        /// </summary>
	        [XmlElement("entrance_id")]
	        public Nullable<long> EntranceId { get; set; }
	
	        /// <summary>
	        /// 扩展数据,业务可以自定义，目前最大支持256B
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 群成员列表
	        /// </summary>
	        [XmlArray("member_list")]
	        [XmlArrayItem("base_group_member_info")]
	        public List<BaseGroupMemberInfoDomain> MemberList { get; set; }
	
	        /// <summary>
	        /// 群名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 新人进群是否能查看最近100条记录。0:不能；1:可以查看最近100条记录；不填默认为0
	        /// </summary>
	        [XmlElement("show_history_type")]
	        public Nullable<long> ShowHistoryType { get; set; }
	
	        /// <summary>
	        /// 群类型,目前没有使用，填0即可
	        /// </summary>
	        [XmlElement("type")]
	        public Nullable<long> Type { get; set; }
	
	        /// <summary>
	        /// uuid, 用于防止弱网情况下超时导致重复创建, 一分钟内传递相同的uuid会返回同一个群，传空则不去重
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

        #endregion
    }
}
