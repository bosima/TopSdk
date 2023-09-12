using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCustomerserviceTicketCreateResponse.
    /// </summary>
    public class OapiCustomerserviceTicketCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 异常码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 异常消息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public TicketCreateResultDtoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TicketCreateResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TicketCreateResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 工单id
	        /// </summary>
	        [XmlElement("ticket_id")]
	        public string TicketId { get; set; }
}

    }
}
