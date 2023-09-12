using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.groupmember.modify
    /// </summary>
    public class OapiImpaasGroupmemberModifyRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasGroupmemberModifyResponse>
    {
        /// <summary>
        /// 修改群成员列表入参
        /// </summary>
        public string Request { get; set; }

        public GroupMemberListModifyRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.groupmember.modify";
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
	        /// 待操作成员id，ID类型由type字段确定。当type为“staff”时，本字段填写staffid，当type为“channelUser”时，本字段填写channelUserId。
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 代操作成员ID类型，目前支持“staff” “channelUser”两种类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// GroupMemberListModifyRequestDomain Data Structure.
/// </summary>
[Serializable]

public class GroupMemberListModifyRequestDomain : TopObject
{
	        /// <summary>
	        /// 接入方channel信息，该值由接入方接入IMPaaS平台时，向IMPaaS平台申请，例如“hema”“eleme”等。
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 群ID，由创建群接口返回。
	        /// </summary>
	        [XmlElement("chatid")]
	        public string Chatid { get; set; }
	
	        /// <summary>
	        /// 待操作成员列表
	        /// </summary>
	        [XmlArray("member_list")]
	        [XmlArrayItem("base_group_member_info")]
	        public List<BaseGroupMemberInfoDomain> MemberList { get; set; }
	
	        /// <summary>
	        /// 该参数表示本次请求的操作类型，“1”表示添加成员，“2”表示删除成员。
	        /// </summary>
	        [XmlElement("modify_type")]
	        public string ModifyType { get; set; }
}

        #endregion
    }
}
