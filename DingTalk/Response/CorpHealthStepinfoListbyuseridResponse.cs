using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// CorpHealthStepinfoListbyuseridResponse.
    /// </summary>
    public class CorpHealthStepinfoListbyuseridResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// BasicStepInfoVoDomain Data Structure.
/// </summary>
[Serializable]

public class BasicStepInfoVoDomain : TopObject
{
	        /// <summary>
	        /// 统计的时间
	        /// </summary>
	        [XmlElement("stat_date")]
	        public long StatDate { get; set; }
	
	        /// <summary>
	        /// 步数
	        /// </summary>
	        [XmlElement("step_count")]
	        public long StepCount { get; set; }
	
	        /// <summary>
	        /// 员工userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 步数列表
	        /// </summary>
	        [XmlArray("stepinfo_list")]
	        [XmlArrayItem("basic_step_info_vo")]
	        public List<BasicStepInfoVoDomain> StepinfoList { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
