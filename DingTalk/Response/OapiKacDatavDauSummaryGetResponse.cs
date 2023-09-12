using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavDauSummaryGetResponse.
    /// </summary>
    public class OapiKacDatavDauSummaryGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 结果码
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
        [XmlElement("result")]
        public DauSummaryResponseDomain Result { get; set; }

	/// <summary>
/// DauSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DauSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// 激活人数（累计）
	        /// </summary>
	        [XmlElement("activated_count")]
	        public long ActivatedCount { get; set; }
	
	        /// <summary>
	        /// 钉钉app的登录用户
	        /// </summary>
	        [XmlElement("app_active_users")]
	        public long AppActiveUsers { get; set; }
	
	        /// <summary>
	        /// 聊天用户数
	        /// </summary>
	        [XmlElement("chat_user_count")]
	        public long ChatUserCount { get; set; }
	
	        /// <summary>
	        /// 通讯录人数
	        /// </summary>
	        [XmlElement("contacts_count")]
	        public long ContactsCount { get; set; }
	
	        /// <summary>
	        /// 日活跃人数
	        /// </summary>
	        [XmlElement("daily_active_users")]
	        public long DailyActiveUsers { get; set; }
	
	        /// <summary>
	        /// 钉钉pc端的登录用户
	        /// </summary>
	        [XmlElement("pc_active_users")]
	        public long PcActiveUsers { get; set; }
}

    }
}
