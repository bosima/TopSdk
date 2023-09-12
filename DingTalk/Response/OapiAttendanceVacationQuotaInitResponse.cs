using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceVacationQuotaInitResponse.
    /// </summary>
    public class OapiAttendanceVacationQuotaInitResponse : DingTalkResponse
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
        /// 结果值
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("result")]
        public List<ResultDomain> Result { get; set; }

        /// <summary>
        /// 是否正确访问
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// QuotaDomain Data Structure.
/// </summary>
[Serializable]

public class QuotaDomain : TopObject
{
	        /// <summary>
	        /// 假期类型唯一标识
	        /// </summary>
	        [XmlElement("leave_code")]
	        public string LeaveCode { get; set; }
	
	        /// <summary>
	        /// 额度所对应的周期(除了假期类型为调休的时候可以为空之外 其他情况均不能为空 且格式必须满足"yyyy")
	        /// </summary>
	        [XmlElement("quota_cycle")]
	        public string QuotaCycle { get; set; }
	
	        /// <summary>
	        /// 员工ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 失败记录
	        /// </summary>
	        [XmlElement("quota")]
	        public QuotaDomain Quota { get; set; }
	
	        /// <summary>
	        /// 失败原因
	        /// </summary>
	        [XmlElement("reason")]
	        public string Reason { get; set; }
}

    }
}
