using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiMpdevPreviewbuildCreateResponse.
    /// </summary>
    public class OapiMpdevPreviewbuildCreateResponse : DingTalkResponse
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
        /// 返回内容
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
	        /// 构建ID
	        /// </summary>
	        [XmlElement("build_id")]
	        public string BuildId { get; set; }
	
	        /// <summary>
	        /// 构建信息
	        /// </summary>
	        [XmlElement("build_info")]
	        public string BuildInfo { get; set; }
	
	        /// <summary>
	        /// 构建完成
	        /// </summary>
	        [XmlElement("finished")]
	        public bool Finished { get; set; }
	
	        /// <summary>
	        /// 构建日志地址
	        /// </summary>
	        [XmlElement("log_url")]
	        public string LogUrl { get; set; }
	
	        /// <summary>
	        /// 结果url地址
	        /// </summary>
	        [XmlElement("result_url")]
	        public string ResultUrl { get; set; }
	
	        /// <summary>
	        /// 构建任务ID
	        /// </summary>
	        [XmlElement("task_id")]
	        public string TaskId { get; set; }
}

    }
}
