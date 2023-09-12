using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// SmartworkBpmsProcessGetvisibleResponse.
    /// </summary>
    public class SmartworkBpmsProcessGetvisibleResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// ProcessTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessTopVoDomain : TopObject
{
	        /// <summary>
	        /// 可见的流程模板唯一标识，最多20条
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 返回的业务数据
	        /// </summary>
	        [XmlArray("processes")]
	        [XmlArrayItem("process_top_vo")]
	        public List<ProcessTopVoDomain> Processes { get; set; }
	
	        /// <summary>
	        /// 请求状态
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
