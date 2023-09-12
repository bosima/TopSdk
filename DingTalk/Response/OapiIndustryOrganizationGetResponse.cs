using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiIndustryOrganizationGetResponse.
    /// </summary>
    public class OapiIndustryOrganizationGetResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public OpenIndustryOrgInfoDomain Result { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenIndustryOrgInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenIndustryOrgInfoDomain : TopObject
{
	        /// <summary>
	        /// 区域id信息
	        /// </summary>
	        [XmlElement("region_id")]
	        public string RegionId { get; set; }
	
	        /// <summary>
	        /// 区域信息
	        /// </summary>
	        [XmlElement("region_location")]
	        public string RegionLocation { get; set; }
	
	        /// <summary>
	        /// 区域类型，区/镇/村
	        /// </summary>
	        [XmlElement("region_type")]
	        public string RegionType { get; set; }
}

    }
}
