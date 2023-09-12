using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiExtcontactListlabelgroupsResponse.
    /// </summary>
    public class OapiExtcontactListlabelgroupsResponse : DingTalkResponse
    {
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
        /// results
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("open_label_group")]
        public List<OpenLabelGroupDomain> Results { get; set; }

	/// <summary>
/// OpenLabelDomain Data Structure.
/// </summary>
[Serializable]

public class OpenLabelDomain : TopObject
{
	        /// <summary>
	        /// 标签id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 标签名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// OpenLabelGroupDomain Data Structure.
/// </summary>
[Serializable]

public class OpenLabelGroupDomain : TopObject
{
	        /// <summary>
	        /// 标签组颜色
	        /// </summary>
	        [XmlElement("color")]
	        public long Color { get; set; }
	
	        /// <summary>
	        /// labels
	        /// </summary>
	        [XmlArray("labels")]
	        [XmlArrayItem("open_label")]
	        public List<OpenLabelDomain> Labels { get; set; }
	
	        /// <summary>
	        /// 标签组名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

    }
}
