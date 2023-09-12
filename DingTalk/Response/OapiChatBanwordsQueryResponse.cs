using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiChatBanwordsQueryResponse.
    /// </summary>
    public class OapiChatBanwordsQueryResponse : DingTalkResponse
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
        /// 结果集
        /// </summary>
        [XmlElement("result")]
        public OpenBanWordModelDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// UserBanWordModelDomain Data Structure.
/// </summary>
[Serializable]

public class UserBanWordModelDomain : TopObject
{
	        /// <summary>
	        /// true为该用户禁言，false该用户没有被禁言
	        /// </summary>
	        [XmlElement("ban_words_status")]
	        public bool BanWordsStatus { get; set; }
	
	        /// <summary>
	        /// 结束禁言的时间戳
	        /// </summary>
	        [XmlElement("end_time")]
	        public long EndTime { get; set; }
	
	        /// <summary>
	        /// 开始禁言的时间戳
	        /// </summary>
	        [XmlElement("start_time")]
	        public long StartTime { get; set; }
}

	/// <summary>
/// OpenBanWordModelDomain Data Structure.
/// </summary>
[Serializable]

public class OpenBanWordModelDomain : TopObject
{
	        /// <summary>
	        /// true为开启全员禁言，false为关闭全员禁言
	        /// </summary>
	        [XmlElement("all_ban_words")]
	        public bool AllBanWords { get; set; }
	
	        /// <summary>
	        /// 单个人禁言的状态
	        /// </summary>
	        [XmlElement("user_ban_words")]
	        public UserBanWordModelDomain UserBanWords { get; set; }
}

    }
}
