using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.microapp.custom.create
    /// </summary>
    public class OapiMicroappCustomCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMicroappCustomCreateResponse>
    {
        /// <summary>
        /// 定制应用所属企业
        /// </summary>
        public string AppCorpId { get; set; }

        /// <summary>
        /// 微应用描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 微应用类型0 H5 1小程序
        /// </summary>
        public Nullable<long> DevelopType { get; set; }

        /// <summary>
        /// 移动端地址
        /// </summary>
        public string HomepageLink { get; set; }

        /// <summary>
        /// 微应用图标, /media/upload生成
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// “1.1.1.1,2.2.2.2”
        /// </summary>
        public string IpWhiteList { get; set; }

        /// <summary>
        /// 微应用名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 管理后台地址
        /// </summary>
        public string OmpLink { get; set; }

        /// <summary>
        /// PC端地址
        /// </summary>
        public string PcHomepageLink { get; set; }

        /// <summary>
        /// 定制应用所属企业的顶级管理组织，通过该组织判断调用接口的白名单
        /// </summary>
        public string TopRelatedCorpId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.microapp.custom.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_corp_id", this.AppCorpId);
            parameters.Add("desc", this.Desc);
            parameters.Add("develop_type", this.DevelopType);
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
            RequestValidator.ValidateRequired("app_corp_id", this.AppCorpId);
            RequestValidator.ValidateRequired("desc", this.Desc);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("top_related_corp_id", this.TopRelatedCorpId);
        }

        #endregion
    }
}
