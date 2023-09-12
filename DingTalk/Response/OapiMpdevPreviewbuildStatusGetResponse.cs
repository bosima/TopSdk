using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMpdevPreviewbuildStatusGetResponse.
    /// </summary>
    public class OapiMpdevPreviewbuildStatusGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误文案
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public BuildResultVoDomain Result { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// BuildResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class BuildResultVoDomain : TopObject
{
	        /// <summary>
	        /// 构建记录ID
	        /// </summary>
	        [XmlElement("build_id")]
	        public long BuildId { get; set; }
	
	        /// <summary>
	        /// 任务结束
	        /// </summary>
	        [XmlElement("finished")]
	        public bool Finished { get; set; }
	
	        /// <summary>
	        /// 预览scheme
	        /// </summary>
	        [XmlElement("result_url")]
	        public string ResultUrl { get; set; }
	
	        /// <summary>
	        /// 构建状态
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 任务ID
	        /// </summary>
	        [XmlElement("task_id")]
	        public string TaskId { get; set; }
}

    }
}
