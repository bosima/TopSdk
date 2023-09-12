using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.template.list
    /// </summary>
    public class OapiProcessTemplateListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessTemplateListResponse>
    {
        /// <summary>
        /// 游标属性
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// abc123
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.template.list";
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
        }

        #endregion
    }
}
