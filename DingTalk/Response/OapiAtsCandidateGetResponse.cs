using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAtsCandidateGetResponse.
    /// </summary>
    public class OapiAtsCandidateGetResponse : DingTalkResponse
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
        /// 候选人信息
        /// </summary>
        [XmlElement("result")]
        public TopCandidateVODomain Result { get; set; }

	/// <summary>
/// TopCandidateVODomain Data Structure.
/// </summary>
[Serializable]

public class TopCandidateVODomain : TopObject
{
	        /// <summary>
	        /// 候选人id
	        /// </summary>
	        [XmlElement("candidate_id")]
	        public string CandidateId { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 创建时间，unix毫秒时间戳
	        /// </summary>
	        [XmlElement("gmt_create_mils")]
	        public long GmtCreateMils { get; set; }
	
	        /// <summary>
	        /// 修改时间，unix毫秒时间戳
	        /// </summary>
	        [XmlElement("gmt_modified_mils")]
	        public long GmtModifiedMils { get; set; }
	
	        /// <summary>
	        /// 候选人姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

    }
}
