using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUserCorpinfoListResponse.
    /// </summary>
    public class OapiUserCorpinfoListResponse : DingTalkResponse
    {
        /// <summary>
        /// 企业列表
        /// </summary>
        [XmlArray("corp_list")]
        [XmlArrayItem("corp_info_vo")]
        public List<CorpInfoVoDomain> CorpList { get; set; }

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
/// CorpInfoVoDomain Data Structure.
/// </summary>
[Serializable]

public class CorpInfoVoDomain : TopObject
{
	        /// <summary>
	        /// 是否认证，0表示未认证，1表示认证
	        /// </summary>
	        [XmlElement("auth_status")]
	        public long AuthStatus { get; set; }
	
	        /// <summary>
	        /// 企业名称
	        /// </summary>
	        [XmlElement("corp_name")]
	        public string CorpName { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
}

    }
}
