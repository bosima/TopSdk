using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmMasterSaveResponse.
    /// </summary>
    public class OapiSmartworkHrmMasterSaveResponse : DingTalkResponse
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
        /// 保存结果
        /// </summary>
        [XmlElement("result")]
        public IntegrateBatchResultVODomain Result { get; set; }

	/// <summary>
/// FailresultDomain Data Structure.
/// </summary>
[Serializable]

public class FailresultDomain : TopObject
{
	        /// <summary>
	        /// 业务流水唯一标识，和入参一致
	        /// </summary>
	        [XmlElement("biz_uk")]
	        public string BizUk { get; set; }
	
	        /// <summary>
	        /// 保存错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// 保存错误信息
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
/// IntegrateBatchResultVODomain Data Structure.
/// </summary>
[Serializable]

public class IntegrateBatchResultVODomain : TopObject
{
	        /// <summary>
	        /// 是否全部保存成功
	        /// </summary>
	        [XmlElement("all_success")]
	        public bool AllSuccess { get; set; }
	
	        /// <summary>
	        /// 保存失败的结果，全部保存成功时为空
	        /// </summary>
	        [XmlArray("fail_result")]
	        [XmlArrayItem("failresult")]
	        public List<FailresultDomain> FailResult { get; set; }
}

    }
}
