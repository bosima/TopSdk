using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.serviceaccount.add
    /// </summary>
    public class OapiServiceaccountAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServiceaccountAddResponse>
    {
        /// <summary>
        /// 头像图片mediaId
        /// </summary>
        public string AvatarMediaId { get; set; }

        /// <summary>
        /// 机器人管理列表中的简介
        /// </summary>
        public string Brief { get; set; }

        /// <summary>
        /// 机器人主页中的服务号功能简介，最多200个字符
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 服务号名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 机器人主页中，消息预览图片的mediaId
        /// </summary>
        public string PreviewMediaId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.serviceaccount.add";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("avatar_media_id", this.AvatarMediaId);
            parameters.Add("brief", this.Brief);
            parameters.Add("desc", this.Desc);
            parameters.Add("name", this.Name);
            parameters.Add("preview_media_id", this.PreviewMediaId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("avatar_media_id", this.AvatarMediaId);
            RequestValidator.ValidateMaxLength("brief", this.Brief, 60);
            RequestValidator.ValidateRequired("desc", this.Desc);
            RequestValidator.ValidateMaxLength("desc", this.Desc, 200);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 30);
            RequestValidator.ValidateRequired("preview_media_id", this.PreviewMediaId);
        }

        #endregion
    }
}
