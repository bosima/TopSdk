using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.homework.comment.tips.create
    /// </summary>
    public class OapiEduHomeworkCommentTipsCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduHomeworkCommentTipsCreateResponse>
    {
        /// <summary>
        /// 属性字段
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// 音频
        /// </summary>
        public string Audio { get; set; }

        /// <summary>
        /// sfadf
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 视频
        /// </summary>
        public string Media { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public Nullable<long> SortOrder { get; set; }

        /// <summary>
        /// 用户userid
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.homework.comment.tips.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attributes", this.Attributes);
            parameters.Add("audio", this.Audio);
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("content", this.Content);
            parameters.Add("media", this.Media);
            parameters.Add("photo", this.Photo);
            parameters.Add("sort_order", this.SortOrder);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
