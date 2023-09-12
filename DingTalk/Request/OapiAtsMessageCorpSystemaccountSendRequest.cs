using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.message.corp.systemaccount.send
    /// </summary>
    public class OapiAtsMessageCorpSystemaccountSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsMessageCorpSystemaccountSendResponse>
    {
        /// <summary>
        /// 业务标识
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 系统账号发送消息参数
        /// </summary>
        public string Param { get; set; }

        public SystemAccountSendMessageParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.message.corp.systemaccount.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("param", this.Param);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("param", this.Param);
        }

	/// <summary>
/// SystemAccountSendMessageParamDomain Data Structure.
/// </summary>
[Serializable]

public class SystemAccountSendMessageParamDomain : TopObject
{
	        /// <summary>
	        /// 系统账号标识
	        /// </summary>
	        [XmlElement("account_key")]
	        public string AccountKey { get; set; }
	
	        /// <summary>
	        /// 消息模版标识
	        /// </summary>
	        [XmlElement("message_key")]
	        public string MessageKey { get; set; }
	
	        /// <summary>
	        /// 消息接收者userId列表
	        /// </summary>
	        [XmlArray("receiver_user_id_list")]
	        [XmlArrayItem("string")]
	        public List<string> ReceiverUserIdList { get; set; }
	
	        /// <summary>
	        /// 消息模版填充值
	        /// </summary>
	        [XmlElement("value_map")]
	        public string ValueMap { get; set; }
}

        #endregion
    }
}
