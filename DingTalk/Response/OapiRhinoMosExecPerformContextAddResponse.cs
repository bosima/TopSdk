using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosExecPerformContextAddResponse.
    /// </summary>
    public class OapiRhinoMosExecPerformContextAddResponse : DingTalkResponse
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
        /// 执行上下文
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("operation_perform_dto")]
        public List<OperationPerformDtoDomain> Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OperationPerformDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OperationPerformDtoDomain : TopObject
{
	        /// <summary>
	        /// 上下文
	        /// </summary>
	        [XmlElement("context")]
	        public string Context { get; set; }
	
	        /// <summary>
	        /// 工序执行ID
	        /// </summary>
	        [XmlElement("operation_record_id")]
	        public long OperationRecordId { get; set; }
}

    }
}
