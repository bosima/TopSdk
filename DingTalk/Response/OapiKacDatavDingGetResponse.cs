using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavDingGetResponse.
    /// </summary>
    public class OapiKacDatavDingGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果对象
        /// </summary>
        [XmlElement("result")]
        public DingUsageSummaryResponseDomain Result { get; set; }

	/// <summary>
/// DingUsageSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DingUsageSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// 最近一天发送应用DING数
	        /// </summary>
	        [XmlElement("ding_app_cnt")]
	        public long DingAppCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送应用DING人数
	        /// </summary>
	        [XmlElement("ding_app_user_cnt")]
	        public long DingAppUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送电话DING数
	        /// </summary>
	        [XmlElement("ding_call_cnt")]
	        public long DingCallCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送电话DING人数
	        /// </summary>
	        [XmlElement("ding_call_user_cnt")]
	        public long DingCallUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近1天发送DING数
	        /// </summary>
	        [XmlElement("ding_cnt")]
	        public long DingCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送短信DING数
	        /// </summary>
	        [XmlElement("ding_sms_cnt")]
	        public long DingSmsCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送短信DING人数
	        /// </summary>
	        [XmlElement("ding_sms_user_cnt")]
	        public long DingSmsUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近1天发送DING人数
	        /// </summary>
	        [XmlElement("ding_user_cnt")]
	        public long DingUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送语音DING数
	        /// </summary>
	        [XmlElement("ding_voip_cnt")]
	        public long DingVoipCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发送语音DING人数
	        /// </summary>
	        [XmlElement("ding_voip_user_cnt")]
	        public long DingVoipUserCnt { get; set; }
}

    }
}
