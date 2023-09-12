using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceListRecordResponse.
    /// </summary>
    public class OapiAttendanceListRecordResponse : DingTalkResponse
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
	        /// baseAccuracy
	        /// </summary>
	        [XmlElement("baseAccuracy")]
	        public string BaseAccuracy { get; set; }
	
	        /// <summary>
	        /// baseAddress
	        /// </summary>
	        [XmlElement("baseAddress")]
	        public string BaseAddress { get; set; }
	
	        /// <summary>
	        /// baseCheckTime
	        /// </summary>
	        [XmlElement("baseCheckTime")]
	        public string BaseCheckTime { get; set; }
	
	        /// <summary>
	        /// baseLatitude
	        /// </summary>
	        [XmlElement("baseLatitude")]
	        public string BaseLatitude { get; set; }
	
	        /// <summary>
	        /// baseLongitude
	        /// </summary>
	        [XmlElement("baseLongitude")]
	        public string BaseLongitude { get; set; }
	
	        /// <summary>
	        /// baseMacAddr
	        /// </summary>
	        [XmlElement("baseMacAddr")]
	        public string BaseMacAddr { get; set; }
	
	        /// <summary>
	        /// baseSsid
	        /// </summary>
	        [XmlElement("baseSsid")]
	        public string BaseSsid { get; set; }
	
	        /// <summary>
	        /// bizId
	        /// </summary>
	        [XmlElement("bizId")]
	        public string BizId { get; set; }
	
	        /// <summary>
	        /// checkType
	        /// </summary>
	        [XmlElement("checkType")]
	        public string CheckType { get; set; }
	
	        /// <summary>
	        /// classId
	        /// </summary>
	        [XmlElement("classId")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// deviceId
	        /// </summary>
	        [XmlElement("deviceId")]
	        public string DeviceId { get; set; }
	
	        /// <summary>
	        /// deviceSN
	        /// </summary>
	        [XmlElement("deviceSN")]
	        public string DeviceSN { get; set; }
	
	        /// <summary>
	        /// gmtCreate
	        /// </summary>
	        [XmlElement("gmtCreate")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// gmtModified
	        /// </summary>
	        [XmlElement("gmtModified")]
	        public string GmtModified { get; set; }
	
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
	        /// invalidRecordMsg
	        /// </summary>
	        [XmlElement("invalidRecordMsg")]
	        public string InvalidRecordMsg { get; set; }
	
	        /// <summary>
	        /// invalidRecordType
	        /// </summary>
	        [XmlElement("invalidRecordType")]
	        public string InvalidRecordType { get; set; }
	
	        /// <summary>
	        /// isLegal
	        /// </summary>
	        [XmlElement("isLegal")]
	        public string IsLegal { get; set; }
	
	        /// <summary>
	        /// locationMethod
	        /// </summary>
	        [XmlElement("locationMethod")]
	        public string LocationMethod { get; set; }
	
	        /// <summary>
	        /// locationResult
	        /// </summary>
	        [XmlElement("locationResult")]
	        public string LocationResult { get; set; }
	
	        /// <summary>
	        /// outsideRemark
	        /// </summary>
	        [XmlElement("outsideRemark")]
	        public string OutsideRemark { get; set; }
	
	        /// <summary>
	        /// planCheckTime
	        /// </summary>
	        [XmlElement("planCheckTime")]
	        public string PlanCheckTime { get; set; }
	
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
	        /// userAccuracy
	        /// </summary>
	        [XmlElement("userAccuracy")]
	        public string UserAccuracy { get; set; }
	
	        /// <summary>
	        /// userAddress
	        /// </summary>
	        [XmlElement("userAddress")]
	        public string UserAddress { get; set; }
	
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
	        /// userLatitude
	        /// </summary>
	        [XmlElement("userLatitude")]
	        public string UserLatitude { get; set; }
	
	        /// <summary>
	        /// userLongitude
	        /// </summary>
	        [XmlElement("userLongitude")]
	        public string UserLongitude { get; set; }
	
	        /// <summary>
	        /// userMacAddr
	        /// </summary>
	        [XmlElement("userMacAddr")]
	        public string UserMacAddr { get; set; }
	
	        /// <summary>
	        /// userSsid
	        /// </summary>
	        [XmlElement("userSsid")]
	        public string UserSsid { get; set; }
	
	        /// <summary>
	        /// workDate
	        /// </summary>
	        [XmlElement("workDate")]
	        public string WorkDate { get; set; }
}

    }
}
