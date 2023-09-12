using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacOpenliveWhiteUsersListResponse.
    /// </summary>
    public class OapiKacOpenliveWhiteUsersListResponse : DingTalkResponse
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
        /// 结果集合
        /// </summary>
        [XmlElement("result")]
        public ResultListDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ListLiveUserWhitelistResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ListLiveUserWhitelistResponseDomain : TopObject
{
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("user_id")]
	        public string UserId { get; set; }
}

	/// <summary>
/// ResultListDomain Data Structure.
/// </summary>
[Serializable]

public class ResultListDomain : TopObject
{
	        /// <summary>
	        /// 人员总数
	        /// </summary>
	        [XmlElement("total_cnt")]
	        public long TotalCnt { get; set; }
	
	        /// <summary>
	        /// 直播对应的人员信息
	        /// </summary>
	        [XmlArray("values")]
	        [XmlArrayItem("list_live_user_whitelist_response")]
	        public List<ListLiveUserWhitelistResponseDomain> Values { get; set; }
}

    }
}
