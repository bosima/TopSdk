using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2UserGetbymobileResponse.
    /// </summary>
    public class OapiV2UserGetbymobileResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码。0代表成功。
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public UserGetByMobileResponseDomain Result { get; set; }

	/// <summary>
/// UserGetByMobileResponseDomain Data Structure.
/// </summary>
[Serializable]

public class UserGetByMobileResponseDomain : TopObject
{
	        /// <summary>
	        /// 专属帐号员工的userid列表(不含其他组织创建的专属帐号)
	        /// </summary>
	        [XmlArray("exclusive_account_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> ExclusiveAccountUseridList { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
