using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.collection.form.list
    /// </summary>
    public class OapiCollectionFormListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiCollectionFormListResponse>
    {
        /// <summary>
        /// 填表类型。0表示通用填表，1表示教育版填表
        /// </summary>
        public Nullable<long> BizType { get; set; }

        /// <summary>
        /// 填表创建人userid
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// 分页游标，从0开始。后续取返回结果中next_cursor的值
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 分页大小，最大200
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.collection.form.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
            parameters.Add("creator", this.Creator);
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
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
