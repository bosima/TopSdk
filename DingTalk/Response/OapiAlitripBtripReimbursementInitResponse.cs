using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripReimbursementInitResponse.
    /// </summary>
    public class OapiAlitripBtripReimbursementInitResponse : DingTalkResponse
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
        /// 返回值
        /// </summary>
        [XmlElement("module")]
        public OpenApiNewReimbursementRsDomain Module { get; set; }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenApiNewReimbursementRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiNewReimbursementRsDomain : TopObject
{
	        /// <summary>
	        /// 报销单号
	        /// </summary>
	        [XmlElement("flow_no")]
	        public long FlowNo { get; set; }
	
	        /// <summary>
	        /// 第三方流程编号
	        /// </summary>
	        [XmlElement("thirdparty_flow_id")]
	        public string ThirdpartyFlowId { get; set; }
}

    }
}
