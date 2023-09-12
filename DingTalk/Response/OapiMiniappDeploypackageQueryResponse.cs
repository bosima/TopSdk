using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMiniappDeploypackageQueryResponse.
    /// </summary>
    public class OapiMiniappDeploypackageQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回的数据实体
        /// </summary>
        [XmlElement("data")]
        public DeployPackageDoModelDomain Data { get; set; }

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
/// DeployPackageDoModelDomain Data Structure.
/// </summary>
[Serializable]

public class DeployPackageDoModelDomain : TopObject
{
	        /// <summary>
	        /// 应用ID
	        /// </summary>
	        [XmlElement("app_id")]
	        public string AppId { get; set; }
	
	        /// <summary>
	        /// 自动装载
	        /// </summary>
	        [XmlElement("auto_install")]
	        public long AutoInstall { get; set; }
	
	        /// <summary>
	        /// 客户端
	        /// </summary>
	        [XmlElement("client_id")]
	        public long ClientId { get; set; }
	
	        /// <summary>
	        /// 部署时间
	        /// </summary>
	        [XmlElement("deploy_time")]
	        public long DeployTime { get; set; }
	
	        /// <summary>
	        /// 描述
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 英文名
	        /// </summary>
	        [XmlElement("english_name")]
	        public string EnglishName { get; set; }
	
	        /// <summary>
	        /// 扩展信息
	        /// </summary>
	        [XmlElement("extend_info")]
	        public string ExtendInfo { get; set; }
	
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
	        /// 灰度
	        /// </summary>
	        [XmlElement("gray")]
	        public long Gray { get; set; }
	
	        /// <summary>
	        /// 灰度码
	        /// </summary>
	        [XmlElement("gray_code")]
	        public string GrayCode { get; set; }
	
	        /// <summary>
	        /// 灰度时间
	        /// </summary>
	        [XmlElement("gray_time")]
	        public long GrayTime { get; set; }
	
	        /// <summary>
	        /// 图标
	        /// </summary>
	        [XmlElement("icon_url")]
	        public string IconUrl { get; set; }
	
	        /// <summary>
	        /// ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
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
	        /// 名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 在线
	        /// </summary>
	        [XmlElement("online")]
	        public long Online { get; set; }
	
	        /// <summary>
	        /// 包ID
	        /// </summary>
	        [XmlElement("package_id")]
	        public long PackageId { get; set; }
	
	        /// <summary>
	        /// 包地址
	        /// </summary>
	        [XmlElement("package_url")]
	        public string PackageUrl { get; set; }
	
	        /// <summary>
	        /// 插件映射
	        /// </summary>
	        [XmlElement("plugin_refs")]
	        public string PluginRefs { get; set; }
	
	        /// <summary>
	        /// 插件大小
	        /// </summary>
	        [XmlElement("plugin_size")]
	        public long PluginSize { get; set; }
	
	        /// <summary>
	        /// 插件 url
	        /// </summary>
	        [XmlElement("plugin_url")]
	        public string PluginUrl { get; set; }
	
	        /// <summary>
	        /// 预发状态
	        /// </summary>
	        [XmlElement("pre")]
	        public long Pre { get; set; }
	
	        /// <summary>
	        /// 预发布时间
	        /// </summary>
	        [XmlElement("pre_time")]
	        public long PreTime { get; set; }
	
	        /// <summary>
	        /// 预装载
	        /// </summary>
	        [XmlElement("preset")]
	        public long Preset { get; set; }
	
	        /// <summary>
	        /// 上线状态
	        /// </summary>
	        [XmlElement("prod")]
	        public long Prod { get; set; }
	
	        /// <summary>
	        /// 回滚自哪个部署包
	        /// </summary>
	        [XmlElement("rollback_from")]
	        public long RollbackFrom { get; set; }
	
	        /// <summary>
	        /// 大小
	        /// </summary>
	        [XmlElement("size")]
	        public long Size { get; set; }
	
	        /// <summary>
	        /// 标语
	        /// </summary>
	        [XmlElement("slogan")]
	        public string Slogan { get; set; }
	
	        /// <summary>
	        /// 版本
	        /// </summary>
	        [XmlElement("version")]
	        public string Version { get; set; }
	
	        /// <summary>
	        /// vhost
	        /// </summary>
	        [XmlElement("vhost")]
	        public string Vhost { get; set; }
	
	        /// <summary>
	        /// 发布窗口ID
	        /// </summary>
	        [XmlElement("window_id")]
	        public long WindowId { get; set; }
}

    }
}
