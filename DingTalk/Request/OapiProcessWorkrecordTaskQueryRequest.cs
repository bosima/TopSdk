using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.workrecord.task.query
    /// </summary>
    public class OapiProcessWorkrecordTaskQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessWorkrecordTaskQueryResponse>
    {
        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> Count { get; set; }

        /// <summary>
        /// 分页游标
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.workrecord.task.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("count", this.Count);
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
            RequestValidator.ValidateRequired("count", this.Count);
            RequestValidator.ValidateRequired("offset", this.Offset);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

        #endregion
    }
}
