using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMiniappAppinfoQueryResponse.
    /// </summary>
    public class OapiMiniappAppinfoQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回的数据实体
        /// </summary>
        [XmlElement("data")]
        public AppInfoDoModelDomain Data { get; set; }

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
/// AppInfoDoModelDomain Data Structure.
/// </summary>
[Serializable]

public class AppInfoDoModelDomain : TopObject
{
	        /// <summary>
	        /// alias
	        /// </summary>
	        [XmlElement("alias")]
	        public string Alias { get; set; }
	
	        /// <summary>
	        /// 应用通道
	        /// </summary>
	        [XmlElement("app_channel")]
	        public long AppChannel { get; set; }
	
	        /// <summary>
	        /// 应用ID
	        /// </summary>
	        [XmlElement("app_id")]
	        public string AppId { get; set; }
	
	        /// <summary>
	        /// 应用key
	        /// </summary>
	        [XmlElement("app_key")]
	        public string AppKey { get; set; }
	
	        /// <summary>
	        /// 应用类型
	        /// </summary>
	        [XmlElement("app_type")]
	        public long AppType { get; set; }
	
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
	        /// 描述
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 设备ID
	        /// </summary>
	        [XmlElement("dev_id")]
	        public string DevId { get; set; }
	
	        /// <summary>
	        /// 英文名称
	        /// </summary>
	        [XmlElement("english_name")]
	        public string EnglishName { get; set; }
	
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
	        /// inheritConfig
	        /// </summary>
	        [XmlElement("inherit_config")]
	        public string InheritConfig { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("inst_id")]
	        public long InstId { get; set; }
	
	        /// <summary>
	        /// isDeleted
	        /// </summary>
	        [XmlElement("is_deleted")]
	        public long IsDeleted { get; set; }
	
	        /// <summary>
	        /// lastDiscards
	        /// </summary>
	        [XmlElement("last_discards")]
	        public string LastDiscards { get; set; }
	
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
	        /// 来源
	        /// </summary>
	        [XmlElement("origin")]
	        public long Origin { get; set; }
	
	        /// <summary>
	        /// 预装载
	        /// </summary>
	        [XmlElement("preset")]
	        public long Preset { get; set; }
	
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
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 子类型
	        /// </summary>
	        [XmlElement("sub_type")]
	        public long SubType { get; set; }
	
	        /// <summary>
	        /// vhost
	        /// </summary>
	        [XmlElement("v_host")]
	        public string VHost { get; set; }
}

    }
}
