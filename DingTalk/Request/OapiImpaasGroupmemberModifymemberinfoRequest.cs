using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.groupmember.modifymemberinfo
    /// </summary>
    public class OapiImpaasGroupmemberModifymemberinfoRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasGroupmemberModifymemberinfoResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public ModifyGroupMemberInfoRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.groupmember.modifymemberinfo";
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
/// GroupMemberInfoDomain Data Structure.
/// </summary>
[Serializable]

public class GroupMemberInfoDomain : TopObject
{
	        /// <summary>
	        /// 扩展属性
	        /// </summary>
	        [XmlElement("ext")]
	        public string Ext { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 用户昵称，要修改到的值
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// ModifyGroupMemberInfoRequestDomain Data Structure.
/// </summary>
[Serializable]

public class ModifyGroupMemberInfoRequestDomain : TopObject
{
	        /// <summary>
	        /// 群ID
	        /// </summary>
	        [XmlElement("chatid")]
	        public string Chatid { get; set; }
	
	        /// <summary>
	        /// 要修改的成员信息
	        /// </summary>
	        [XmlElement("member_info")]
	        public GroupMemberInfoDomain MemberInfo { get; set; }
}

        #endregion
    }
}
