using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.plugin.statistics.job.list
    /// </summary>
    public class OapiAtsPluginStatisticsJobListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsPluginStatisticsJobListResponse>
    {
        /// <summary>
        /// 招聘业务标识
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 分页游标位置，不传默认第一页
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.plugin.statistics.job.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
