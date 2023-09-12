using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiHireBizflowStartResponse.
    /// </summary>
    public class OapiHireBizflowStartResponse : DingTalkResponse
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
        /// 发起应聘流程结果
        /// </summary>
        [XmlElement("result")]
        public TopStartBizFlowResultDomain Result { get; set; }

	/// <summary>
/// TopStartBizFlowResultDomain Data Structure.
/// </summary>
[Serializable]

public class TopStartBizFlowResultDomain : TopObject
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
	        /// pc端重定向地址
	        /// </summary>
	        [XmlElement("pc_redirect_url")]
	        public string PcRedirectUrl { get; set; }
}

    }
}
