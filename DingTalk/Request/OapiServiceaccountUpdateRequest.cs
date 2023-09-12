using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.serviceaccount.update
    /// </summary>
    public class OapiServiceaccountUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServiceaccountUpdateResponse>
    {
        /// <summary>
        /// 头像图片mediaId
        /// </summary>
        public string AvatarMediaId { get; set; }

        /// <summary>
        /// 机器人管理列表中的简介，最多60个字符
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

        /// <summary>
        /// normal-正常，disabled-删除
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 服务号的unionid
        /// </summary>
        public string Unionid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.serviceaccount.update";
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
            parameters.Add("status", this.Status);
            parameters.Add("unionid", this.Unionid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxLength("brief", this.Brief, 60);
            RequestValidator.ValidateMaxLength("desc", this.Desc, 200);
            RequestValidator.ValidateMaxLength("name", this.Name, 30);
            RequestValidator.ValidateRequired("unionid", this.Unionid);
        }

        #endregion
    }
}
