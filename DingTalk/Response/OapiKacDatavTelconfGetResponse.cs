using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavTelconfGetResponse.
    /// </summary>
    public class OapiKacDatavTelconfGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public TelConferenceSummaryResponseDomain Result { get; set; }

	/// <summary>
/// TelConferenceSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class TelConferenceSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// 呼叫成功次数
	        /// </summary>
	        [XmlElement("call_count")]
	        public long CallCount { get; set; }
	
	        /// <summary>
	        /// 呼叫成功时长(秒)
	        /// </summary>
	        [XmlElement("call_duration")]
	        public string CallDuration { get; set; }
	
	        /// <summary>
	        /// 呼叫成功时长(分钟)
	        /// </summary>
	        [XmlElement("call_duration_min")]
	        public string CallDurationMin { get; set; }
	
	        /// <summary>
	        /// 呼叫参与人次
	        /// </summary>
	        [XmlElement("call_join_pv")]
	        public long CallJoinPv { get; set; }
}

    }
}
