using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMiniappPackageconfigQueryResponse.
    /// </summary>
    public class OapiMiniappPackageconfigQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回的数据实体
        /// </summary>
        [XmlElement("data")]
        public PackageConfigDOModelDomain Data { get; set; }

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
/// PackageConfigDOModelDomain Data Structure.
/// </summary>
[Serializable]

public class PackageConfigDOModelDomain : TopObject
{
	        /// <summary>
	        /// appid
	        /// </summary>
	        [XmlElement("app_id")]
	        public string AppId { get; set; }
	
	        /// <summary>
	        /// 构建结果url
	        /// </summary>
	        [XmlElement("build_result_url")]
	        public string BuildResultUrl { get; set; }
	
	        /// <summary>
	        /// fallback
	        /// </summary>
	        [XmlElement("fallback_url")]
	        public string FallbackUrl { get; set; }
	
	        /// <summary>
	        /// 是否删除
	        /// </summary>
	        [XmlElement("is_deleted")]
	        public long IsDeleted { get; set; }
	
	        /// <summary>
	        /// 包路径
	        /// </summary>
	        [XmlElement("package_path")]
	        public string PackagePath { get; set; }
	
	        /// <summary>
	        /// 包类型MAIN/SUB
	        /// </summary>
	        [XmlElement("package_type")]
	        public string PackageType { get; set; }
	
	        /// <summary>
	        /// 包地址
	        /// </summary>
	        [XmlElement("package_url")]
	        public string PackageUrl { get; set; }
	
	        /// <summary>
	        /// 大小
	        /// </summary>
	        [XmlElement("size")]
	        public long Size { get; set; }
	
	        /// <summary>
	        /// 版本ID
	        /// </summary>
	        [XmlElement("version_unique_id")]
	        public string VersionUniqueId { get; set; }
}

    }
}
