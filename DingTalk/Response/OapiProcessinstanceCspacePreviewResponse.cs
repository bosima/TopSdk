using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessinstanceCspacePreviewResponse.
    /// </summary>
    public class OapiProcessinstanceCspacePreviewResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public AppSpaceResponseDomain Result { get; set; }

	/// <summary>
/// AppSpaceResponseDomain Data Structure.
/// </summary>
[Serializable]

public class AppSpaceResponseDomain : TopObject
{
	        /// <summary>
	        /// spaceId
	        /// </summary>
	        [XmlElement("space_id")]
	        public long SpaceId { get; set; }
}

    }
}
