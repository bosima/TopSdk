using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmMasterDeleteResponse.
    /// </summary>
    public class OapiSmartworkHrmMasterDeleteResponse : DingTalkResponse
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
        /// 批量处理结果
        /// </summary>
        [XmlElement("result")]
        public IntegrateBatchResultVoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// FailresultDomain Data Structure.
/// </summary>
[Serializable]

public class FailresultDomain : TopObject
{
	        /// <summary>
	        /// 业务UK,唯一确定一条流水
	        /// </summary>
	        [XmlElement("biz_uk")]
	        public string BizUk { get; set; }
	
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

	/// <summary>
/// IntegrateBatchResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class IntegrateBatchResultVoDomain : TopObject
{
	        /// <summary>
	        /// 是否全部成功
	        /// </summary>
	        [XmlElement("all_success")]
	        public bool AllSuccess { get; set; }
	
	        /// <summary>
	        /// 失败的处理结果
	        /// </summary>
	        [XmlArray("fail_result")]
	        [XmlArrayItem("failresult")]
	        public List<FailresultDomain> FailResult { get; set; }
}

    }
}
