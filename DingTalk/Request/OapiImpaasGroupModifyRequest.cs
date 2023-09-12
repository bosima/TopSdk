using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.group.modify
    /// </summary>
    public class OapiImpaasGroupModifyRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasGroupModifyResponse>
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        public string Request { get; set; }

        public GroupInfoModifyRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.group.modify";
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
	        /// 修改后的群主ID，ID类型由type字段决定
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// ID类型，当type=staff时，id填写staffid，当type=channelUser时，id字段填写channelUserId
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// GroupInfoModifyRequestDomain Data Structure.
/// </summary>
[Serializable]

public class GroupInfoModifyRequestDomain : TopObject
{
	        /// <summary>
	        /// 群ID，由创建群接口返回
	        /// </summary>
	        [XmlElement("chatid")]
	        public string Chatid { get; set; }
	
	        /// <summary>
	        /// 修改后的群名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
	
	        /// <summary>
	        /// 修改后的群主，若为空或与当前群主相同，则不会对群主进行变更操作。
	        /// </summary>
	        [XmlElement("group_owner")]
	        public BaseGroupMemberInfoDomain GroupOwner { get; set; }
	
	        /// <summary>
	        /// 新人进群是否能查看最近100条记录。0:不能；1:可以查看最近100条记录；不填默认为0
	        /// </summary>
	        [XmlElement("show_history_type")]
	        public Nullable<long> ShowHistoryType { get; set; }
}

        #endregion
    }
}
