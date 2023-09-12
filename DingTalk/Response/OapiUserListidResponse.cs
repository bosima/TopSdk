using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserListidResponse.
    /// </summary>
    public class OapiUserListidResponse : DingTalkResponse
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
        public ListUserByDeptResponseDomain Result { get; set; }

	/// <summary>
/// ListUserByDeptResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ListUserByDeptResponseDomain : TopObject
{
	        /// <summary>
	        /// 用户id列表
	        /// </summary>
	        [XmlArray("userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> UseridList { get; set; }
}

    }
}
