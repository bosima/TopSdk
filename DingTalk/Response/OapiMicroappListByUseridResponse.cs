using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMicroappListByUseridResponse.
    /// </summary>
    public class OapiMicroappListByUseridResponse : DingTalkResponse
    {
        /// <summary>
        /// appList
        /// </summary>
        [XmlArray("appList")]
        [XmlArrayItem("applist")]
        public List<ApplistDomain> AppList { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 对返回码的文本描述内容
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

	/// <summary>
/// ApplistDomain Data Structure.
/// </summary>
[Serializable]

public class ApplistDomain : TopObject
{
	        /// <summary>
	        /// 微应用实例化id
	        /// </summary>
	        [XmlElement("agentId")]
	        public long AgentId { get; set; }
	
	        /// <summary>
	        /// 微应用描述
	        /// </summary>
	        [XmlElement("appDesc")]
	        public string AppDesc { get; set; }
	
	        /// <summary>
	        /// 微应用图标
	        /// </summary>
	        [XmlElement("appIcon")]
	        public string AppIcon { get; set; }
	
	        /// <summary>
	        /// 微应用状态，1表示启用，0表示停用
	        /// </summary>
	        [XmlElement("appStatus")]
	        public long AppStatus { get; set; }
	
	        /// <summary>
	        /// 微应用的移动端主页
	        /// </summary>
	        [XmlElement("homepageLink")]
	        public string HomepageLink { get; set; }
	
	        /// <summary>
	        /// 表示是否是自建微应用
	        /// </summary>
	        [XmlElement("isSelf")]
	        public bool IsSelf { get; set; }
	
	        /// <summary>
	        /// 微应用图标
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 微应用的OA后台管理主页
	        /// </summary>
	        [XmlElement("ompLink")]
	        public string OmpLink { get; set; }
	
	        /// <summary>
	        /// 微应用的pc端主页
	        /// </summary>
	        [XmlElement("pcHomepageLink")]
	        public string PcHomepageLink { get; set; }
}

    }
}
