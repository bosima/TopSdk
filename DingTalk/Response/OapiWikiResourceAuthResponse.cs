using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWikiResourceAuthResponse.
    /// </summary>
    public class OapiWikiResourceAuthResponse : DingTalkResponse
    {
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
        /// 资源授权结果列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("open_resource_vo")]
        public List<OpenResourceVoDomain> Result { get; set; }

        /// <summary>
        /// 是否操作成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenResourceVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenResourceVoDomain : TopObject
{
	        /// <summary>
	        /// 资源id（加密后的值）
	        /// </summary>
	        [XmlElement("resource_id")]
	        public string ResourceId { get; set; }
	
	        /// <summary>
	        /// 资源类型
	        /// </summary>
	        [XmlElement("resource_type")]
	        public long ResourceType { get; set; }
	
	        /// <summary>
	        /// 是否授权成功（0:成功，1:失败）
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
}

    }
}
