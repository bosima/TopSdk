using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMiniappDeploywindowQueryResponse.
    /// </summary>
    public class OapiMiniappDeploywindowQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回的数据实体
        /// </summary>
        [XmlElement("data")]
        public DeployWindowDoModelDomain Data { get; set; }

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
/// DeployWindowDoModelDomain Data Structure.
/// </summary>
[Serializable]

public class DeployWindowDoModelDomain : TopObject
{
	        /// <summary>
	        /// 安卓最大版本
	        /// </summary>
	        [XmlElement("android_client_max")]
	        public string AndroidClientMax { get; set; }
	
	        /// <summary>
	        /// 安卓最小版本
	        /// </summary>
	        [XmlElement("android_client_min")]
	        public string AndroidClientMin { get; set; }
	
	        /// <summary>
	        /// 安卓实例ID
	        /// </summary>
	        [XmlElement("android_instance_id")]
	        public long AndroidInstanceId { get; set; }
	
	        /// <summary>
	        /// 应用ID
	        /// </summary>
	        [XmlElement("app_id")]
	        public string AppId { get; set; }
	
	        /// <summary>
	        /// 客户端
	        /// </summary>
	        [XmlElement("client_id")]
	        public long ClientId { get; set; }
	
	        /// <summary>
	        /// 包ID
	        /// </summary>
	        [XmlElement("deploy_package_id")]
	        public long DeployPackageId { get; set; }
	
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
	        /// 租户ID
	        /// </summary>
	        [XmlElement("inst_id")]
	        public long InstId { get; set; }
	
	        /// <summary>
	        /// IOS客户端最大版本
	        /// </summary>
	        [XmlElement("ios_client_max")]
	        public string IosClientMax { get; set; }
	
	        /// <summary>
	        /// IOS客户端最小版本
	        /// </summary>
	        [XmlElement("ios_client_min")]
	        public string IosClientMin { get; set; }
	
	        /// <summary>
	        /// IOS实例ID
	        /// </summary>
	        [XmlElement("ios_instance_id")]
	        public long IosInstanceId { get; set; }
	
	        /// <summary>
	        /// 名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 安卓平台
	        /// </summary>
	        [XmlElement("platform_android")]
	        public long PlatformAndroid { get; set; }
	
	        /// <summary>
	        /// ios平台
	        /// </summary>
	        [XmlElement("platform_ios")]
	        public long PlatformIos { get; set; }
	
	        /// <summary>
	        /// 版本
	        /// </summary>
	        [XmlElement("version")]
	        public string Version { get; set; }
}

    }
}
