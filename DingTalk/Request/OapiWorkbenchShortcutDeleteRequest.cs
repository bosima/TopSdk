using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workbench.shortcut.delete
    /// </summary>
    public class OapiWorkbenchShortcutDeleteRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkbenchShortcutDeleteResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 系统交互唯一流水号(ISV维度下不可重复)
        /// </summary>
        public string BizNo { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workbench.shortcut.delete";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_id", this.AppId);
            parameters.Add("biz_no", this.BizNo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("app_id", this.AppId);
            RequestValidator.ValidateRequired("biz_no", this.BizNo);
        }

        #endregion
    }
}
