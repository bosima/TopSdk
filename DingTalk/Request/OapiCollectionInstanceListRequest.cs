using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.collection.instance.list
    /// </summary>
    public class OapiCollectionInstanceListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCollectionInstanceListResponse>
    {
        /// <summary>
        /// 时间，必须是YYYY-MM-DD的格式
        /// </summary>
        public string ActionDate { get; set; }

        /// <summary>
        /// 填表类型
        /// </summary>
        public Nullable<long> BizType { get; set; }

        /// <summary>
        /// 填表code
        /// </summary>
        public string FormCode { get; set; }

        /// <summary>
        /// 分页起始
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 分页大小，最大100
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.collection.instance.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("action_date", this.ActionDate);
            parameters.Add("biz_type", this.BizType);
            parameters.Add("form_code", this.FormCode);
            parameters.Add("offset", this.Offset);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("form_code", this.FormCode);
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
