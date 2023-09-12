using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMiniappAppversionQueryResponse.
    /// </summary>
    public class OapiMiniappAppversionQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回的数据实体
        /// </summary>
        [XmlElement("data")]
        public AppVersionDoModelDomain Data { get; set; }

        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

	/// <summary>
/// AppVersionDoModelDomain Data Structure.
/// </summary>
[Serializable]

public class AppVersionDoModelDomain : TopObject
{
	        /// <summary>
	        /// appid
	        /// </summary>
	        [XmlElement("app_id")]
	        public string AppId { get; set; }
	
	        /// <summary>
	        /// 构建任务ID
	        /// </summary>
	        [XmlElement("build_task_no")]
	        public string BuildTaskNo { get; set; }
	
	        /// <summary>
	        /// 构建类型
	        /// </summary>
	        [XmlElement("build_type")]
	        public long BuildType { get; set; }
	
	        /// <summary>
	        /// 客户端
	        /// </summary>
	        [XmlElement("client_id")]
	        public long ClientId { get; set; }
	
	        /// <summary>
	        /// 模板实例化小程序的扩展数据
	        /// </summary>
	        [XmlElement("ext_json_config")]
	        public string ExtJsonConfig { get; set; }
	
	        /// <summary>
	        /// 模板实例化小程序的扩展数据url
	        /// </summary>
	        [XmlElement("ext_json_config_url")]
	        public string ExtJsonConfigUrl { get; set; }
	
	        /// <summary>
	        /// 扩展信息
	        /// </summary>
	        [XmlElement("extend_info")]
	        public string ExtendInfo { get; set; }
	
	        /// <summary>
	        /// 扩展
	        /// </summary>
	        [XmlElement("extra")]
	        public string Extra { get; set; }
	
	        /// <summary>
	        /// fallbackBaseUrl
	        /// </summary>
	        [XmlElement("fallback_base_url")]
	        public string FallbackBaseUrl { get; set; }
	
	        /// <summary>
	        /// 更新时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public long GmtCreate { get; set; }
	
	        /// <summary>
	        /// 更新时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public long GmtModified { get; set; }
	
	        /// <summary>
	        /// ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 未知
	        /// </summary>
	        [XmlElement("inherit_config")]
	        public string InheritConfig { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("inst_id")]
	        public long InstId { get; set; }
	
	        /// <summary>
	        /// 是否删除
	        /// </summary>
	        [XmlElement("is_deleted")]
	        public long IsDeleted { get; set; }
	
	        /// <summary>
	        /// 主URL
	        /// </summary>
	        [XmlElement("main_url")]
	        public string MainUrl { get; set; }
	
	        /// <summary>
	        /// MD5
	        /// </summary>
	        [XmlElement("md5")]
	        public string Md5 { get; set; }
	
	        /// <summary>
	        /// 猫爪任务ID
	        /// </summary>
	        [XmlElement("mosec_job_id")]
	        public string MosecJobId { get; set; }
	
	        /// <summary>
	        /// 猫爪扫描任务状态
	        /// </summary>
	        [XmlElement("mosec_status")]
	        public long MosecStatus { get; set; }
	
	        /// <summary>
	        /// 包地址
	        /// </summary>
	        [XmlElement("package_url")]
	        public string PackageUrl { get; set; }
	
	        /// <summary>
	        /// 插件关联
	        /// </summary>
	        [XmlElement("plugin_refs")]
	        public string PluginRefs { get; set; }
	
	        /// <summary>
	        /// 插件大小
	        /// </summary>
	        [XmlElement("plugin_size")]
	        public long PluginSize { get; set; }
	
	        /// <summary>
	        /// 插件url
	        /// </summary>
	        [XmlElement("plugin_url")]
	        public string PluginUrl { get; set; }
	
	        /// <summary>
	        /// 构建任务ID
	        /// </summary>
	        [XmlElement("qcloud_job_id")]
	        public string QcloudJobId { get; set; }
	
	        /// <summary>
	        /// 构建任务状态
	        /// </summary>
	        [XmlElement("qcloud_status")]
	        public long QcloudStatus { get; set; }
	
	        /// <summary>
	        /// 大小
	        /// </summary>
	        [XmlElement("size")]
	        public long Size { get; set; }
	
	        /// <summary>
	        /// 源URL
	        /// </summary>
	        [XmlElement("source_url")]
	        public string SourceUrl { get; set; }
	
	        /// <summary>
	        /// 模板应用ID
	        /// </summary>
	        [XmlElement("template_app_id")]
	        public string TemplateAppId { get; set; }
	
	        /// <summary>
	        /// 模板ID
	        /// </summary>
	        [XmlElement("template_id")]
	        public long TemplateId { get; set; }
	
	        /// <summary>
	        /// 模板版本
	        /// </summary>
	        [XmlElement("template_version")]
	        public string TemplateVersion { get; set; }
	
	        /// <summary>
	        /// tinyCliVersion
	        /// </summary>
	        [XmlElement("tiny_cli_version")]
	        public string TinyCliVersion { get; set; }
	
	        /// <summary>
	        /// 版本
	        /// </summary>
	        [XmlElement("version")]
	        public string Version { get; set; }
	
	        /// <summary>
	        /// 版本ID
	        /// </summary>
	        [XmlElement("version_unique_id")]
	        public string VersionUniqueId { get; set; }
}

    }
}
