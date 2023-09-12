using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.openservice.query
    /// </summary>
    public class OapiRhinoOpenserviceQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoOpenserviceQueryResponse>
    {
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public Nullable<DateTime> GmtCreate { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenentId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.openservice.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("code", this.Code);
            parameters.Add("gmt_create", this.GmtCreate);
            parameters.Add("id", this.Id);
            parameters.Add("tenent_id", this.TenentId);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
