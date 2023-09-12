using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.isv.call.getuserlist
    /// </summary>
    public class IsvCallGetuserlistRequest : BaseDingTalkRequest<DingTalk.Api.Response.IsvCallGetuserlistResponse>
    {
        /// <summary>
        /// 批量值
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// 游标开始值
        /// </summary>
        public Nullable<long> Start { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.isv.call.getuserlist";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("offset", this.Offset);
            parameters.Add("start", this.Start);
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
