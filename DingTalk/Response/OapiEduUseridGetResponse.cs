using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduUseridGetResponse.
    /// </summary>
    public class OapiEduUseridGetResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public OpenEduUserIdListResponseDomain Result { get; set; }

        /// <summary>
        /// 接口调用成功or失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// UserIdHoldDomain Data Structure.
/// </summary>
[Serializable]

public class UserIdHoldDomain : TopObject
{
	        /// <summary>
	        /// 手机号码
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenEduUserIdListResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduUserIdListResponseDomain : TopObject
{
	        /// <summary>
	        /// 用户id列表
	        /// </summary>
	        [XmlArray("users")]
	        [XmlArrayItem("user_id_hold")]
	        public List<UserIdHoldDomain> Users { get; set; }
}

    }
}
