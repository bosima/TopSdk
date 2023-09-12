using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosSpaceWorkerCheckInListResponse.
    /// </summary>
    public class OapiRhinoMosSpaceWorkerCheckInListResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("prod_workstation_worker_check_dto")]
        public List<ProdWorkstationWorkerCheckDtoDomain> Model { get; set; }

	/// <summary>
/// ProdWorkstationWorkerCheckDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ProdWorkstationWorkerCheckDtoDomain : TopObject
{
	        /// <summary>
	        /// 登入时间
	        /// </summary>
	        [XmlElement("check_in_time")]
	        public string CheckInTime { get; set; }
	
	        /// <summary>
	        /// 登出时间
	        /// </summary>
	        [XmlElement("check_out_time")]
	        public string CheckOutTime { get; set; }
	
	        /// <summary>
	        /// 登入登出状态
	        /// </summary>
	        [XmlElement("check_status")]
	        public string CheckStatus { get; set; }
	
	        /// <summary>
	        /// 站位code
	        /// </summary>
	        [XmlElement("prod_workstation_code")]
	        public string ProdWorkstationCode { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 工号
	        /// </summary>
	        [XmlElement("work_no")]
	        public string WorkNo { get; set; }
}

    }
}
