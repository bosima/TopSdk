using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workrecord.getbyuserid
    /// </summary>
    public class OapiWorkrecordGetbyuseridRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkrecordGetbyuseridResponse>
    {
        /// <summary>
        /// 分页大小，最多50
        /// </summary>
        public Nullable<long> Limit { get; set; }

        /// <summary>
        /// 分页游标，从0开始，如返回结果中has_more为true，则表示还有数据，offset再传上一次的offset+limit
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 待办事项状态，0表示未完成，1表示完成
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 用户唯一ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workrecord.getbyuserid";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("limit", this.Limit);
            parameters.Add("offset", this.Offset);
            parameters.Add("status", this.Status);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("limit", this.Limit);
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
