using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.workbench.shortcut.update
    /// </summary>
    public class OapiWorkbenchShortcutUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiWorkbenchShortcutUpdateResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 系统交互唯一业务单号
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 图标Url
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 快捷方式名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// PC端快捷方式跳转地址
        /// </summary>
        public string PcShortcutUri { get; set; }

        /// <summary>
        /// 快捷方式跳转地址(移动端地址-默认地址)
        /// </summary>
        public string ShortcutUri { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.workbench.shortcut.update";
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
            parameters.Add("icon", this.Icon);
            parameters.Add("name", this.Name);
            parameters.Add("pc_shortcut_uri", this.PcShortcutUri);
            parameters.Add("shortcut_uri", this.ShortcutUri);
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
