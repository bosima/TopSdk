using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiHealthStepinfoListbyuseridResponse.
    /// </summary>
    public class OapiHealthStepinfoListbyuseridResponse : DingTalkResponse
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
        /// 步数列表
        /// </summary>
        [XmlArray("stepinfo_list")]
        [XmlArrayItem("basic_step_info_vo")]
        public List<BasicStepInfoVoDomain> StepinfoList { get; set; }

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

    }
}
