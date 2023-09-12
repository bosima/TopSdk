using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workbench.shortcut.list
    /// </summary>
    public class OapiWorkbenchShortcutListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkbenchShortcutListResponse>
    {
        /// <summary>
        /// ISV微应用id
        /// </summary>
        public string AppId { get; set; }

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
            return "dingtalk.oapi.workbench.shortcut.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_id", this.AppId);
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
            RequestValidator.ValidateRequired("app_id", this.AppId);
        }

        #endregion
    }
}
