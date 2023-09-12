using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRetailUserBindqueryResponse.
    /// </summary>
    public class OapiRetailUserBindqueryResponse : DingTalkResponse
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
        /// xx
        /// </summary>
        [XmlElement("result")]
        public UserBindDtoDomain Result { get; set; }

        /// <summary>
        /// 成功失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ApplyUserDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ApplyUserDtoDomain : TopObject
{
	        /// <summary>
	        /// 业务渠道
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 扩展字段
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 主帐号ID
	        /// </summary>
	        [XmlElement("outer_id")]
	        public string OuterId { get; set; }
	
	        /// <summary>
	        /// 主帐号名称
	        /// </summary>
	        [XmlElement("outer_nick")]
	        public string OuterNick { get; set; }
	
	        /// <summary>
	        /// 子帐号ID
	        /// </summary>
	        [XmlElement("outer_sub_id")]
	        public string OuterSubId { get; set; }
	
	        /// <summary>
	        /// 子帐号名称
	        /// </summary>
	        [XmlElement("outer_sub_nick")]
	        public string OuterSubNick { get; set; }
}

	/// <summary>
/// UserBindDtoDomain Data Structure.
/// </summary>
[Serializable]

public class UserBindDtoDomain : TopObject
{
	        /// <summary>
	        /// 中心组织唯一ID
	        /// </summary>
	        [XmlElement("associate_union_id")]
	        public string AssociateUnionId { get; set; }
	
	        /// <summary>
	        /// 扩展字段
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 帐号列表
	        /// </summary>
	        [XmlArray("outer_list")]
	        [XmlArrayItem("apply_user_dto")]
	        public List<ApplyUserDtoDomain> OuterList { get; set; }
	
	        /// <summary>
	        /// token
	        /// </summary>
	        [XmlElement("token")]
	        public string Token { get; set; }
}

    }
}
