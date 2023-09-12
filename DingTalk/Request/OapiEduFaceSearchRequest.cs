using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.face.search
    /// </summary>
    public class OapiEduFaceSearchRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduFaceSearchResponse>
    {
        /// <summary>
        /// 班级id
        /// </summary>
        public Nullable<long> ClassId { get; set; }

        /// <summary>
        /// 图片宽度，同步调用时候必须
        /// </summary>
        public Nullable<long> Height { get; set; }

        /// <summary>
        /// 是否同步调用，默认不同步
        /// </summary>
        public Nullable<bool> Synchronous { get; set; }

        /// <summary>
        /// https://img.alicdn.com/tfs/TB1._LRfUz1gK0jSZLeXXb9kVXa-36-32.png
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 图片宽度，同步调用时候必须
        /// </summary>
        public Nullable<long> Width { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.face.search";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("class_id", this.ClassId);
            parameters.Add("height", this.Height);
            parameters.Add("synchronous", this.Synchronous);
            parameters.Add("url", this.Url);
            parameters.Add("userid", this.Userid);
            parameters.Add("width", this.Width);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("class_id", this.ClassId);
            RequestValidator.ValidateRequired("url", this.Url);
        }

        #endregion
    }
}
