using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.retail.user.bindapply
    /// </summary>
    public class OapiRetailUserBindapplyRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRetailUserBindapplyResponse>
    {
        /// <summary>
        /// 业务身份
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// 请求业务对象
        /// </summary>
        public string Request { get; set; }

        public UserBindParamDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.retail.user.bindapply";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel", this.Channel);
            parameters.Add("request", this.Request);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// UserBindParamDomain Data Structure.
/// </summary>
[Serializable]

public class UserBindParamDomain : TopObject
{
	        /// <summary>
	        /// 扩展字段
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 主帐号ID
	        /// </summary>
	        [XmlElement("outer_id")]
	        public string OuterId { get; set; }
	
	        /// <summary>
	        /// 主帐号名称
	        /// </summary>
	        [XmlElement("outer_nick")]
	        public string OuterNick { get; set; }
	
	        /// <summary>
	        /// 子帐号ID
	        /// </summary>
	        [XmlElement("sub_outer_id")]
	        public string SubOuterId { get; set; }
	
	        /// <summary>
	        /// 子帐号名称
	        /// </summary>
	        [XmlElement("sub_outer_nick")]
	        public string SubOuterNick { get; set; }
	
	        /// <summary>
	        /// token
	        /// </summary>
	        [XmlElement("token")]
	        public string Token { get; set; }
}

        #endregion
    }
}
