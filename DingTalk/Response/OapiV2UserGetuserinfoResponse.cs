using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2UserGetuserinfoResponse.
    /// </summary>
    public class OapiV2UserGetuserinfoResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码, 0代表成功，其它代表失败。
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
        public UserGetByCodeResponseDomain Result { get; set; }

	/// <summary>
/// UserGetByCodeResponseDomain Data Structure.
/// </summary>
[Serializable]

public class UserGetByCodeResponseDomain : TopObject
{
	        /// <summary>
	        /// 用户统一id
	        /// </summary>
	        [XmlElement("associated_unionid")]
	        public string AssociatedUnionid { get; set; }
	
	        /// <summary>
	        /// 设备id
	        /// </summary>
	        [XmlElement("device_id")]
	        public string DeviceId { get; set; }
	
	        /// <summary>
	        /// 用户名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 是否为管理员
	        /// </summary>
	        [XmlElement("sys")]
	        public bool Sys { get; set; }
	
	        /// <summary>
	        /// 员工级别。 1：主管理员 2：子管理员 100：老板 0：其他（如普通员工）
	        /// </summary>
	        [XmlElement("sys_level")]
	        public long SysLevel { get; set; }
	
	        /// <summary>
	        /// 用户unionId
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
