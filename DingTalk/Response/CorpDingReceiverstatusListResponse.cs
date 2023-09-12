using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpDingReceiverstatusListResponse.
    /// </summary>
    public class CorpDingReceiverstatusListResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回的根对象
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// DingReceiverStatusResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingReceiverStatusResultDomain : TopObject
{
	        /// <summary>
	        /// 确认状态。0-未确认；1-已确认；
	        /// </summary>
	        [XmlElement("confirmed_status")]
	        public long ConfirmedStatus { get; set; }
	
	        /// <summary>
	        /// 确认时间
	        /// </summary>
	        [XmlElement("confirmed_time")]
	        public long ConfirmedTime { get; set; }
	
	        /// <summary>
	        /// dingId
	        /// </summary>
	        [XmlElement("ding_id")]
	        public string DingId { get; set; }
	
	        /// <summary>
	        /// 接收者id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 接收者状态列表，当这里返回为null表示分页已经结束
	        /// </summary>
	        [XmlArray("result_list")]
	        [XmlArrayItem("ding_receiver_status_result")]
	        public List<DingReceiverStatusResultDomain> ResultList { get; set; }
	
	        /// <summary>
	        /// 接口调用是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
