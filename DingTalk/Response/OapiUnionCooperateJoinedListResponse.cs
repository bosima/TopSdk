using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiUnionCooperateJoinedListResponse.
    /// </summary>
    public class OapiUnionCooperateJoinedListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误msg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 空间信息
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("open_cooperate_org_vo")]
        public List<OpenCooperateOrgVoDomain> Result { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenCooperateOrgVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCooperateOrgVoDomain : TopObject
{
	        /// <summary>
	        /// 空间归属企业corpId
	        /// </summary>
	        [XmlElement("belong_corp_id")]
	        public string BelongCorpId { get; set; }
	
	        /// <summary>
	        /// 空间归属企业名称
	        /// </summary>
	        [XmlElement("belong_org_name")]
	        public string BelongOrgName { get; set; }
	
	        /// <summary>
	        /// 空间底层组织corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 空间名称
	        /// </summary>
	        [XmlElement("org_name")]
	        public string OrgName { get; set; }
}

    }
}
