using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCorpConversationMemberListResponse.
    /// </summary>
    public class OapiCorpConversationMemberListResponse : DingTalkResponse
    {
        /// <summary>
        /// 服务出参
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// OpenMemberModelDomain Data Structure.
/// </summary>
[Serializable]

public class OpenMemberModelDomain : TopObject
{
	        /// <summary>
	        /// 员工ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenMemberListModelDomain Data Structure.
/// </summary>
[Serializable]

public class OpenMemberListModelDomain : TopObject
{
	        /// <summary>
	        /// 成员信息
	        /// </summary>
	        [XmlArray("member_list")]
	        [XmlArrayItem("open_member_model")]
	        public List<OpenMemberModelDomain> MemberList { get; set; }
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
	        [XmlElement("errcode")]
	        public long Errcode { get; set; }
	
	        /// <summary>
	        /// 系统错误
	        /// </summary>
	        [XmlElement("errmsg")]
	        public string Errmsg { get; set; }
	
	        /// <summary>
	        /// 成员列表
	        /// </summary>
	        [XmlElement("result")]
	        public OpenMemberListModelDomain Result { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
