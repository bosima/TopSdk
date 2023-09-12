using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sns.send_msg
    /// </summary>
    public class OapiSnsSendMsgRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSnsSendMsgResponse>
    {
        /// <summary>
        /// form表单提交成功后获取的formId
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Msg { get; set; }

        public MsgDomain Msg_ { set { this.Msg = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sns.send_msg";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("code", this.Code);
            parameters.Add("msg", this.Msg);
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
/// EappDomain Data Structure.
/// </summary>
[Serializable]

public class EappDomain : TopObject
{
	        /// <summary>
	        /// 消息内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 消息图片资源id
	        /// </summary>
	        [XmlElement("img")]
	        public string Img { get; set; }
	
	        /// <summary>
	        /// 消息链接
	        /// </summary>
	        [XmlElement("link")]
	        public string Link { get; set; }
	
	        /// <summary>
	        /// 消息标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// MsgDomain Data Structure.
/// </summary>
[Serializable]

public class MsgDomain : TopObject
{
	        /// <summary>
	        /// 消息内容
	        /// </summary>
	        [XmlElement("eapp")]
	        public EappDomain Eapp { get; set; }
	
	        /// <summary>
	        /// 消息类型
	        /// </summary>
	        [XmlElement("msgtype")]
	        public string Msgtype { get; set; }
}

        #endregion
    }
}
