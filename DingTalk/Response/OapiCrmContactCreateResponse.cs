using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmContactCreateResponse.
    /// </summary>
    public class OapiCrmContactCreateResponse : DingTalkResponse
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
        /// 联系人信息
        /// </summary>
        [XmlElement("result")]
        public CreateContactResponseDomain Result { get; set; }

	/// <summary>
/// CreateContactResponseDomain Data Structure.
/// </summary>
[Serializable]

public class CreateContactResponseDomain : TopObject
{
	        /// <summary>
	        /// 联系人实例ID
	        /// </summary>
	        [XmlElement("contact_instance_id")]
	        public string ContactInstanceId { get; set; }
	
	        /// <summary>
	        /// 联系人unionId，自建应用视情况返回
	        /// </summary>
	        [XmlElement("contact_unionid")]
	        public string ContactUnionid { get; set; }
	
	        /// <summary>
	        /// 联系人在客户通讯录的ID
	        /// </summary>
	        [XmlElement("contact_userid")]
	        public string ContactUserid { get; set; }
}

    }
}
