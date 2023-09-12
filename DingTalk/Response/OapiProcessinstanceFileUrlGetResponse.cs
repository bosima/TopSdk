using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessinstanceFileUrlGetResponse.
    /// </summary>
    public class OapiProcessinstanceFileUrlGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public AppSpaceResponseDomain Result { get; set; }

        /// <summary>
        /// 成功失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// AppSpaceResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AppSpaceResponseDomain : TopObject
{
	        /// <summary>
	        /// 文件下载地址
	        /// </summary>
	        [XmlElement("download_uri")]
	        public string DownloadUri { get; set; }
	
	        /// <summary>
	        /// 文件id
	        /// </summary>
	        [XmlElement("file_id")]
	        public string FileId { get; set; }
	
	        /// <summary>
	        /// 文件spaceId
	        /// </summary>
	        [XmlElement("space_id")]
	        public long SpaceId { get; set; }
}

    }
}
