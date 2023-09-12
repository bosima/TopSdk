using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workbench.shortcut.listbypaging
    /// </summary>
    public class OapiWorkbenchShortcutListbypagingRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkbenchShortcutListbypagingResponse>
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        public Nullable<long> PageIndex { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workbench.shortcut.listbypaging";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("page_index", this.PageIndex);
            parameters.Add("page_size", this.PageSize);
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
