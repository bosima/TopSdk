using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.mpdev.build.create
    /// </summary>
    public class OapiMpdevBuildCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMpdevBuildCreateResponse>
    {
        /// <summary>
        /// 是否开启TabBar
        /// </summary>
        public string EnableTabbar { get; set; }

        /// <summary>
        /// 小程序默认首页
        /// </summary>
        public string MainPage { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        public string MiniappId { get; set; }

        /// <summary>
        /// 上传包Key
        /// </summary>
        public string PackageKey { get; set; }

        /// <summary>
        /// 上传包MD5
        /// </summary>
        public string PackageMd5 { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        public string PackageVersion { get; set; }

        /// <summary>
        /// 静态插件信息
        /// </summary>
        public string PluginRefs { get; set; }

        public List<PluginReferenceDomain> PluginRefs_ { set { this.PluginRefs = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.mpdev.build.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("enable_tabbar", this.EnableTabbar);
            parameters.Add("main_page", this.MainPage);
            parameters.Add("miniapp_id", this.MiniappId);
            parameters.Add("package_key", this.PackageKey);
            parameters.Add("package_md5", this.PackageMd5);
            parameters.Add("package_version", this.PackageVersion);
            parameters.Add("plugin_refs", this.PluginRefs);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("enable_tabbar", this.EnableTabbar);
            RequestValidator.ValidateRequired("main_page", this.MainPage);
            RequestValidator.ValidateRequired("miniapp_id", this.MiniappId);
            RequestValidator.ValidateRequired("package_key", this.PackageKey);
            RequestValidator.ValidateRequired("package_md5", this.PackageMd5);
            RequestValidator.ValidateObjectMaxListSize("plugin_refs", this.PluginRefs, 999);
        }

	/// <summary>
/// PluginReferenceDomain Data Structure.
/// </summary>
[Serializable]

public class PluginReferenceDomain : TopObject
{
	        /// <summary>
	        /// 插件ID
	        /// </summary>
	        [XmlElement("plugin_id")]
	        public string PluginId { get; set; }
	
	        /// <summary>
	        /// 插件版本
	        /// </summary>
	        [XmlElement("plugin_version")]
	        public string PluginVersion { get; set; }
}

        #endregion
    }
}
