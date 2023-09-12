using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.recommend.create
    /// </summary>
    public class OapiEduRecommendCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduRecommendCreateResponse>
    {
        /// <summary>
        /// 班级ID
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// 内容标签，推荐扩散给其他用户使用
        /// </summary>
        public string LabelList { get; set; }

        /// <summary>
        /// ISV侧内容唯一ID
        /// </summary>
        public string OutContentId { get; set; }

        /// <summary>
        /// 学段
        /// </summary>
        public string PeriodCode { get; set; }

        /// <summary>
        /// 回跳地址
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// 学科
        /// </summary>
        public string SubjectCode { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 教材版本
        /// </summary>
        public string TextbookCode { get; set; }

        /// <summary>
        /// 缩略图url地址
        /// </summary>
        public string Thumbnail { get; set; }

        /// <summary>
        /// 内容标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 内容总时长，单位秒
        /// </summary>
        public Nullable<long> TotalTime { get; set; }

        /// <summary>
        /// 类型：1词汇 2课文 3题目 4考试 5知识点 6课程 7其他
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 当前用户userid
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.recommend.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("class_id", this.ClassId);
            parameters.Add("labelList", this.LabelList);
            parameters.Add("out_content_id", this.OutContentId);
            parameters.Add("period_code", this.PeriodCode);
            parameters.Add("return_url", this.ReturnUrl);
            parameters.Add("subject_code", this.SubjectCode);
            parameters.Add("summary", this.Summary);
            parameters.Add("textbook_code", this.TextbookCode);
            parameters.Add("thumbnail", this.Thumbnail);
            parameters.Add("title", this.Title);
            parameters.Add("totalTime", this.TotalTime);
            parameters.Add("type", this.Type);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("labelList", this.LabelList, 100);
            RequestValidator.ValidateRequired("out_content_id", this.OutContentId);
            RequestValidator.ValidateRequired("period_code", this.PeriodCode);
            RequestValidator.ValidateRequired("return_url", this.ReturnUrl);
            RequestValidator.ValidateRequired("thumbnail", this.Thumbnail);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
