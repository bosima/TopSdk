using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.microapp.custom.update
    /// </summary>
    public class OapiMicroappCustomUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMicroappCustomUpdateResponse>
    {
        /// <summary>
        /// 定制应用Id
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 应用所属企业corpId
        /// </summary>
        public string AppCorpId { get; set; }

        /// <summary>
        /// 应用描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 移动端首页地址
        /// </summary>
        public string HomepageLink { get; set; }

        /// <summary>
        /// 微应用图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 出口IP白名单
        /// </summary>
        public string IpWhiteList { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 管理后台地址
        /// </summary>
        public string OmpLink { get; set; }

        /// <summary>
        /// PC端首页地址
        /// </summary>
        public string PcHomepageLink { get; set; }

        /// <summary>
        /// 应用所属组织的顶级关联组织corpId
        /// </summary>
        public string TopRelatedCorpId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.microapp.custom.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("app_corp_id", this.AppCorpId);
            parameters.Add("desc", this.Desc);
            parameters.Add("homepage_link", this.HomepageLink);
            parameters.Add("icon", this.Icon);
            parameters.Add("ip_white_list", this.IpWhiteList);
            parameters.Add("name", this.Name);
            parameters.Add("omp_link", this.OmpLink);
            parameters.Add("pc_homepage_link", this.PcHomepageLink);
            parameters.Add("top_related_corp_id", this.TopRelatedCorpId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agent_id", this.AgentId);
            RequestValidator.ValidateRequired("app_corp_id", this.AppCorpId);
            RequestValidator.ValidateRequired("desc", this.Desc);
            RequestValidator.ValidateRequired("ip_white_list", this.IpWhiteList);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("top_related_corp_id", this.TopRelatedCorpId);
        }

        #endregion
    }
}
