using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.mpdev.previewbuild.create
    /// </summary>
    public class OapiMpdevPreviewbuildCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiMpdevPreviewbuildCreateResponse>
    {
        /// <summary>
        /// SDK构建脚本版本
        /// </summary>
        public string BuildScriptVersion { get; set; }

        /// <summary>
        /// 远程调试的channel
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// scheme中corpId值
        /// </summary>
        public string Corpid { get; set; }

        /// <summary>
        /// 开启tabBar
        /// </summary>
        public string EnableTabbar { get; set; }

        /// <summary>
        /// 忽略http安全域名检查
        /// </summary>
        public Nullable<bool> IgnoreHttpReqPermission { get; set; }

        /// <summary>
        /// 忽略web-view安全域名检查
        /// </summary>
        public Nullable<bool> IgnoreWebviewDomainCheck { get; set; }

        /// <summary>
        /// 远程调试模式
        /// </summary>
        public Nullable<bool> IsRemoteDebug { get; set; }

        /// <summary>
        /// remoteX远程调试模式
        /// </summary>
        public Nullable<bool> IsRemoteX { get; set; }

        /// <summary>
        /// 包默认主页
        /// </summary>
        public string MainPage { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        public string MiniappId { get; set; }

        /// <summary>
        /// 预览上传包地址
        /// </summary>
        public string PackageKey { get; set; }

        /// <summary>
        /// scheme page参数
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// 插件预览包地址
        /// </summary>
        public string PluginPackageKey { get; set; }

        /// <summary>
        /// 静态插件信息
        /// </summary>
        public string PluginRefs { get; set; }

        public List<PluginReferenceDomain> PluginRefs_ { set { this.PluginRefs = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// scheme query参数
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 分包数据
        /// </summary>
        public string SubPackages { get; set; }

        public List<OpenSubPackageVoDomain> SubPackages_ { set { this.SubPackages = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 远程调试tyroid
        /// </summary>
        public string Tyroid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.mpdev.previewbuild.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("build_script_version", this.BuildScriptVersion);
            parameters.Add("channel", this.Channel);
            parameters.Add("corpid", this.Corpid);
            parameters.Add("enable_tabbar", this.EnableTabbar);
            parameters.Add("ignore_http_req_permission", this.IgnoreHttpReqPermission);
            parameters.Add("ignore_webview_domain_check", this.IgnoreWebviewDomainCheck);
            parameters.Add("is_remote_debug", this.IsRemoteDebug);
            parameters.Add("is_remote_x", this.IsRemoteX);
            parameters.Add("main_page", this.MainPage);
            parameters.Add("miniapp_id", this.MiniappId);
            parameters.Add("package_key", this.PackageKey);
            parameters.Add("page", this.Page);
            parameters.Add("plugin_package_key", this.PluginPackageKey);
            parameters.Add("plugin_refs", this.PluginRefs);
            parameters.Add("query", this.Query);
            parameters.Add("sub_packages", this.SubPackages);
            parameters.Add("tyroid", this.Tyroid);
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
            RequestValidator.ValidateRequired("plugin_package_key", this.PluginPackageKey);
            RequestValidator.ValidateObjectMaxListSize("plugin_refs", this.PluginRefs, 999);
            RequestValidator.ValidateObjectMaxListSize("sub_packages", this.SubPackages, 999);
        }

	/// <summary>
/// OpenSubPackageVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenSubPackageVoDomain : TopObject
{
	        /// <summary>
	        /// 包地址
	        /// </summary>
	        [XmlElement("package_key")]
	        public string PackageKey { get; set; }
	
	        /// <summary>
	        /// 分包路径
	        /// </summary>
	        [XmlElement("path")]
	        public string Path { get; set; }
	
	        /// <summary>
	        /// 包类型，主包or分包
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
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
	        /// 版本号
	        /// </summary>
	        [XmlElement("plugin_version")]
	        public string PluginVersion { get; set; }
}

        #endregion
    }
}
