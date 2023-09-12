using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserGetbyunionidResponse.
    /// </summary>
    public class OapiUserGetbyunionidResponse : DingTalkResponse
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
        public UserGetByUnionIdResponseDomain Result { get; set; }

	/// <summary>
/// UserGetByUnionIdResponseDomain Data Structure.
/// </summary>
[Serializable]

public class UserGetByUnionIdResponseDomain : TopObject
{
	        /// <summary>
	        /// 联系类型，0 企业内部员工 1 企业外部联系人
	        /// </summary>
	        [XmlElement("contact_type")]
	        public long ContactType { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
