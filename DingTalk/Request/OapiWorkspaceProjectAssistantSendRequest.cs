using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workspace.project.assistant.send
    /// </summary>
    public class OapiWorkspaceProjectAssistantSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkspaceProjectAssistantSendResponse>
    {
        /// <summary>
        /// 跳转链接
        /// </summary>
        public string ActionUrl { get; set; }

        /// <summary>
        /// 文章内容，最大支持10个文章段落
        /// </summary>
        public string Content { get; set; }

        public List<SectionDomain> Content_ { set { this.Content = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 链接图片
        /// </summary>
        public string PicUrl { get; set; }

        /// <summary>
        /// 消息接收人，最大支持 100人
        /// </summary>
        public string RecieverUserids { get; set; }

        /// <summary>
        /// 卡片样式，支持 动态卡片：ActionCardMessage，链接卡片：LinkMessage，markdown卡片：MarkdownMessage
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// 标题模板KEY
        /// </summary>
        public string Title { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workspace.project.assistant.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("action_url", this.ActionUrl);
            parameters.Add("content", this.Content);
            parameters.Add("pic_url", this.PicUrl);
            parameters.Add("reciever_userids", this.RecieverUserids);
            parameters.Add("style", this.Style);
            parameters.Add("title", this.Title);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("action_url", this.ActionUrl);
            RequestValidator.ValidateRequired("content", this.Content);
            RequestValidator.ValidateObjectMaxListSize("content", this.Content, 999);
            RequestValidator.ValidateRequired("reciever_userids", this.RecieverUserids);
            RequestValidator.ValidateMaxListSize("reciever_userids", this.RecieverUserids, 999);
            RequestValidator.ValidateRequired("style", this.Style);
            RequestValidator.ValidateRequired("title", this.Title);
        }

	/// <summary>
/// SectionDomain Data Structure.
/// </summary>
[Serializable]

public class SectionDomain : TopObject
{
	        /// <summary>
	        /// 段落模板KEY
	        /// </summary>
	        [XmlElement("msg_key")]
	        public string MsgKey { get; set; }
	
	        /// <summary>
	        /// 段落模板参数
	        /// </summary>
	        [XmlElement("msg_param")]
	        public string MsgParam { get; set; }
}

        #endregion
    }
}
