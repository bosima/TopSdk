using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.listbyuserid
    /// </summary>
    public class OapiProcessListbyuseridRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessListbyuseridResponse>
    {
        /// <summary>
        /// 分页游标，从0开始。根据返回结果里的next_cursor是否为空来判断是否还有下一页，且再次调用时offset设置成next_cursor的值
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 分页大小，最大可设置成100
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 用户id, 不传表示查询企业下所有审批模板
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.listbyuserid";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("offset", this.Offset);
            parameters.Add("size", this.Size);
            parameters.Add("userid", this.Userid);
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
