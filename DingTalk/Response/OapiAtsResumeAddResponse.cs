using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAtsResumeAddResponse.
    /// </summary>
    public class OapiAtsResumeAddResponse : DingTalkResponse
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
        /// 处理结果
        /// </summary>
        [XmlElement("result")]
        public TopCollectResumeResultDomain Result { get; set; }

	/// <summary>
/// TopCollectResumeResultDomain Data Structure.
/// </summary>
[Serializable]

public class TopCollectResumeResultDomain : TopObject
{
	        /// <summary>
	        /// 移动端跳转地址
	        /// </summary>
	        [XmlElement("mobile_jump_url")]
	        public string MobileJumpUrl { get; set; }
	
	        /// <summary>
	        /// pc端跳转地址
	        /// </summary>
	        [XmlElement("pc_jump_url")]
	        public string PcJumpUrl { get; set; }
	
	        /// <summary>
	        /// 简历id
	        /// </summary>
	        [XmlElement("resume_id")]
	        public string ResumeId { get; set; }
}

    }
}
