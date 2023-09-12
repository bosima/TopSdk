using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.chatbot.updatebychatbotid
    /// </summary>
    public class CorpChatbotUpdatebychatbotidRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpChatbotUpdatebychatbotidResponse>
    {
        /// <summary>
        /// 机器人简单描述
        /// </summary>
        public string Breif { get; set; }

        /// <summary>
        /// 机器人id(钉钉分配)
        /// </summary>
        public string ChatbotId { get; set; }

        /// <summary>
        /// 机器人详细描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 机器人头像
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 机器人名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 机器人预览图
        /// </summary>
        public string PreviewMediaId { get; set; }

        /// <summary>
        /// 更新名字或头像时是否更新群里已添加机器人的名字或头像。         * 0-不更新群里机器人名字或头像         * 1-更新群里机器人名字或头像
        /// </summary>
        public Nullable<long> UpdateType { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.chatbot.updatebychatbotid";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("breif", this.Breif);
            parameters.Add("chatbot_id", this.ChatbotId);
            parameters.Add("description", this.Description);
            parameters.Add("icon", this.Icon);
            parameters.Add("name", this.Name);
            parameters.Add("preview_media_id", this.PreviewMediaId);
            parameters.Add("update_type", this.UpdateType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("update_type", this.UpdateType);
        }

        #endregion
    }
}
