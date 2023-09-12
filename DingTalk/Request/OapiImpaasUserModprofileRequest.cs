using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.user.modprofile
    /// </summary>
    public class OapiImpaasUserModprofileRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasUserModprofileResponse>
    {
        /// <summary>
        /// 修改profile入参
        /// </summary>
        public string Request { get; set; }

        public ModProfileReqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.user.modprofile";
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
/// AccountInfoDomain Data Structure.
/// </summary>
[Serializable]

public class AccountInfoDomain : TopObject
{
	        /// <summary>
	        /// 渠道
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 账号id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// ModProfileReqDomain Data Structure.
/// </summary>
[Serializable]

public class ModProfileReqDomain : TopObject
{
	        /// <summary>
	        /// 账号信息
	        /// </summary>
	        [XmlElement("account_info")]
	        public AccountInfoDomain AccountInfo { get; set; }
	
	        /// <summary>
	        /// 头像
	        /// </summary>
	        [XmlElement("avatar_mediaid")]
	        public string AvatarMediaid { get; set; }
	
	        /// <summary>
	        /// 附带信息
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// nick
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
}

        #endregion
    }
}
