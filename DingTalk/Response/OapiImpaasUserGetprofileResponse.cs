using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImpaasUserGetprofileResponse.
    /// </summary>
    public class OapiImpaasUserGetprofileResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码  -1 系统异常 40035 参数错误 400023 用户不存在
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 用户属性
        /// </summary>
        [XmlElement("result")]
        public GetProfileRespDomain Result { get; set; }

        /// <summary>
        /// 接口是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// GetProfileRespDomain Data Structure.
/// </summary>
[Serializable]

public class GetProfileRespDomain : TopObject
{
	        /// <summary>
	        /// 业务方的唯一id
	        /// </summary>
	        [XmlElement("app_userid")]
	        public string AppUserid { get; set; }
	
	        /// <summary>
	        /// 头像的mediaid
	        /// </summary>
	        [XmlElement("avatar_mediaid")]
	        public string AvatarMediaid { get; set; }
	
	        /// <summary>
	        /// 业务方渠道ID
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 附件信息
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// im的唯一id
	        /// </summary>
	        [XmlElement("im_openid")]
	        public string ImOpenid { get; set; }
	
	        /// <summary>
	        /// 昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 用户状态 1 未激活 2 已激活 3 已注销
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
}

    }
}
