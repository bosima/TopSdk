using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripApprovalNewResponse.
    /// </summary>
    public class OapiAlitripBtripApprovalNewResponse : DingTalkResponse
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
        /// 结果对象
        /// </summary>
        [XmlElement("module")]
        public OpenApiNewApplyRsDomain Module { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenApiNewApplyRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiNewApplyRsDomain : TopObject
{
	        /// <summary>
	        /// 商旅申请单id
	        /// </summary>
	        [XmlElement("apply_id")]
	        public long ApplyId { get; set; }
	
	        /// <summary>
	        /// 外部申请单id
	        /// </summary>
	        [XmlElement("thirdpart_apply_id")]
	        public string ThirdpartApplyId { get; set; }
}

    }
}
