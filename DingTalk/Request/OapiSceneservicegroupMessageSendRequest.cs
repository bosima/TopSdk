using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.sceneservicegroup.message.send
    /// </summary>
    public class OapiSceneservicegroupMessageSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSceneservicegroupMessageSendResponse>
    {
        /// <summary>
        /// 根据dingtalkId设置at用户
        /// </summary>
        public string AtDingtalkids { get; set; }

        /// <summary>
        /// 根据手机号设置at用户
        /// </summary>
        public string AtMobiles { get; set; }

        /// <summary>
        /// 根据unionId设置at用户
        /// </summary>
        public string AtUnionids { get; set; }

        /// <summary>
        /// 业务方自身系统关联ID，与开放群ID二选一填入
        /// </summary>
        public string Bizid { get; set; }

        /// <summary>
        /// 0-按钮竖直排列，1-按钮横向排列
        /// </summary>
        public string BtnOrientation { get; set; }

        /// <summary>
        /// card按钮
        /// </summary>
        public string Btns { get; set; }

        public List<BtnsDomain> Btns_ { set { this.Btns = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 是否at所有人
        /// </summary>
        public Nullable<bool> IsAtAll { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public string MessageType { get; set; }

        /// <summary>
        /// 开放群ID
        /// </summary>
        public string OpenConversationid { get; set; }

        /// <summary>
        /// 根据dingtalkId设置接收者
        /// </summary>
        public string ReceiverDingtalkids { get; set; }

        /// <summary>
        /// 根据手机号设置接收者
        /// </summary>
        public string ReceiverMobiles { get; set; }

        /// <summary>
        /// 根据unionId设置接收者
        /// </summary>
        public string ReceiverUnionids { get; set; }

        /// <summary>
        /// 消息标题
        /// </summary>
        public string Title { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.sceneservicegroup.message.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("at_dingtalkids", this.AtDingtalkids);
            parameters.Add("at_mobiles", this.AtMobiles);
            parameters.Add("at_unionids", this.AtUnionids);
            parameters.Add("bizid", this.Bizid);
            parameters.Add("btn_orientation", this.BtnOrientation);
            parameters.Add("btns", this.Btns);
            parameters.Add("content", this.Content);
            parameters.Add("is_at_all", this.IsAtAll);
            parameters.Add("message_type", this.MessageType);
            parameters.Add("open_conversationid", this.OpenConversationid);
            parameters.Add("receiver_dingtalkids", this.ReceiverDingtalkids);
            parameters.Add("receiver_mobiles", this.ReceiverMobiles);
            parameters.Add("receiver_unionids", this.ReceiverUnionids);
            parameters.Add("title", this.Title);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("at_dingtalkids", this.AtDingtalkids, 999);
            RequestValidator.ValidateMaxListSize("at_mobiles", this.AtMobiles, 999);
            RequestValidator.ValidateMaxListSize("at_unionids", this.AtUnionids, 999);
            RequestValidator.ValidateObjectMaxListSize("btns", this.Btns, 999);
            RequestValidator.ValidateRequired("content", this.Content);
            RequestValidator.ValidateRequired("message_type", this.MessageType);
            RequestValidator.ValidateMaxListSize("receiver_dingtalkids", this.ReceiverDingtalkids, 999);
            RequestValidator.ValidateMaxListSize("receiver_mobiles", this.ReceiverMobiles, 999);
            RequestValidator.ValidateMaxListSize("receiver_unionids", this.ReceiverUnionids, 999);
            RequestValidator.ValidateRequired("title", this.Title);
        }

	/// <summary>
/// BtnsDomain Data Structure.
/// </summary>
[Serializable]

public class BtnsDomain : TopObject
{
	        /// <summary>
	        /// 按钮地址
	        /// </summary>
	        [XmlElement("actionURL")]
	        public string ActionURL { get; set; }
	
	        /// <summary>
	        /// 按钮标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

        #endregion
    }
}
