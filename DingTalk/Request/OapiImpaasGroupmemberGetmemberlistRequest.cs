using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.groupmember.getmemberlist
    /// </summary>
    public class OapiImpaasGroupmemberGetmemberlistRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasGroupmemberGetmemberlistResponse>
    {
        /// <summary>
        /// 请求结构体
        /// </summary>
        public string Request { get; set; }

        public GetGroupMemberListRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.groupmember.getmemberlist";
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
/// GetGroupMemberListRequestDomain Data Structure.
/// </summary>
[Serializable]

public class GetGroupMemberListRequestDomain : TopObject
{
	        /// <summary>
	        /// 群ID
	        /// </summary>
	        [XmlElement("chatid")]
	        public string Chatid { get; set; }
	
	        /// <summary>
	        /// 本次请求返回的群成员列表数量
	        /// </summary>
	        [XmlElement("length")]
	        public Nullable<long> Length { get; set; }
	
	        /// <summary>
	        /// 群成员列表偏移
	        /// </summary>
	        [XmlElement("offset")]
	        public Nullable<long> Offset { get; set; }
}

        #endregion
    }
}
