using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceListResponse.
    /// </summary>
    public class OapiAttendanceListResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// hasMore
        /// </summary>
        [XmlElement("hasMore")]
        public bool HasMore { get; set; }

        /// <summary>
        /// recordresult
        /// </summary>
        [XmlArray("recordresult")]
        [XmlArrayItem("recordresult")]
        public List<RecordresultDomain> Recordresult { get; set; }

	/// <summary>
/// RecordresultDomain Data Structure.
/// </summary>
[Serializable]

public class RecordresultDomain : TopObject
{
	        /// <summary>
	        /// approveId
	        /// </summary>
	        [XmlElement("approveId")]
	        public long ApproveId { get; set; }
	
	        /// <summary>
	        /// baseCheckTime
	        /// </summary>
	        [XmlElement("baseCheckTime")]
	        public string BaseCheckTime { get; set; }
	
	        /// <summary>
	        /// checkType
	        /// </summary>
	        [XmlElement("checkType")]
	        public string CheckType { get; set; }
	
	        /// <summary>
	        /// groupId
	        /// </summary>
	        [XmlElement("groupId")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// locationResult
	        /// </summary>
	        [XmlElement("locationResult")]
	        public string LocationResult { get; set; }
	
	        /// <summary>
	        /// planId
	        /// </summary>
	        [XmlElement("planId")]
	        public long PlanId { get; set; }
	
	        /// <summary>
	        /// procInstId
	        /// </summary>
	        [XmlElement("procInstId")]
	        public string ProcInstId { get; set; }
	
	        /// <summary>
	        /// recordId
	        /// </summary>
	        [XmlElement("recordId")]
	        public long RecordId { get; set; }
	
	        /// <summary>
	        /// sourceType
	        /// </summary>
	        [XmlElement("sourceType")]
	        public string SourceType { get; set; }
	
	        /// <summary>
	        /// timeResult
	        /// </summary>
	        [XmlElement("timeResult")]
	        public string TimeResult { get; set; }
	
	        /// <summary>
	        /// userCheckTime
	        /// </summary>
	        [XmlElement("userCheckTime")]
	        public string UserCheckTime { get; set; }
	
	        /// <summary>
	        /// userId
	        /// </summary>
	        [XmlElement("userId")]
	        public string UserId { get; set; }
	
	        /// <summary>
	        /// workDate
	        /// </summary>
	        [XmlElement("workDate")]
	        public string WorkDate { get; set; }
}

    }
}
