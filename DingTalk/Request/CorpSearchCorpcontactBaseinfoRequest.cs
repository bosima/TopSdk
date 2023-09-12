using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.search.corpcontact.baseinfo
    /// </summary>
    public class CorpSearchCorpcontactBaseinfoRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpSearchCorpcontactBaseinfoResponse>
    {
        /// <summary>
        /// 开始位置,从0开始
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 搜索词,长度大于2开始搜
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 拉取个数上限100
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.search.corpcontact.baseinfo";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("offset", this.Offset);
            parameters.Add("query", this.Query);
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
            RequestValidator.ValidateRequired("query", this.Query);
            RequestValidator.ValidateRequired("size", this.Size);
        }

        #endregion
    }
}
