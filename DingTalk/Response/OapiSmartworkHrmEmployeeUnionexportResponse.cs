using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmEmployeeUnionexportResponse.
    /// </summary>
    public class OapiSmartworkHrmEmployeeUnionexportResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误code
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 导出结果对象
        /// </summary>
        [XmlElement("result")]
        public ExportRsultDomain Result { get; set; }

	/// <summary>
/// ExportRsultDomain Data Structure.
/// </summary>
[Serializable]

public class ExportRsultDomain : TopObject
{
	        /// <summary>
	        /// 导出记录id
	        /// </summary>
	        [XmlElement("export_id")]
	        public string ExportId { get; set; }
}

    }
}
