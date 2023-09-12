using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAtsJobBatchaddResponse.
    /// </summary>
    public class OapiAtsJobBatchaddResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// JobSimpleVoDomain Data Structure.
/// </summary>
[Serializable]

public class JobSimpleVoDomain : TopObject
{
	        /// <summary>
	        /// 职位编号
	        /// </summary>
	        [XmlElement("job_code")]
	        public string JobCode { get; set; }
	
	        /// <summary>
	        /// 职位唯一标识
	        /// </summary>
	        [XmlElement("job_id")]
	        public string JobId { get; set; }
	
	        /// <summary>
	        /// 职位名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// BatchResultItemVODomain Data Structure.
/// </summary>
[Serializable]

public class BatchResultItemVODomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误描述
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 下标（从0开始）
	        /// </summary>
	        [XmlElement("index")]
	        public long Index { get; set; }
	
	        /// <summary>
	        /// 职位
	        /// </summary>
	        [XmlElement("item")]
	        public JobSimpleVoDomain Item { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

	/// <summary>
/// BatchResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class BatchResultVoDomain : TopObject
{
	        /// <summary>
	        /// 失败数量
	        /// </summary>
	        [XmlElement("failed_count")]
	        public long FailedCount { get; set; }
	
	        /// <summary>
	        /// 操作结果项列表
	        /// </summary>
	        [XmlArray("result")]
	        [XmlArrayItem("batch_result_item_v_o")]
	        public List<BatchResultItemVODomain> Result { get; set; }
	
	        /// <summary>
	        /// 成功数量
	        /// </summary>
	        [XmlElement("success_count")]
	        public long SuccessCount { get; set; }
	
	        /// <summary>
	        /// 总数量
	        /// </summary>
	        [XmlElement("total_count")]
	        public long TotalCount { get; set; }
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
	        [XmlElement("errcode")]
	        public long Errcode { get; set; }
	
	        /// <summary>
	        /// 错误描述
	        /// </summary>
	        [XmlElement("errmsg")]
	        public string Errmsg { get; set; }
	
	        /// <summary>
	        /// 批量操作结果
	        /// </summary>
	        [XmlElement("result")]
	        public BatchResultVoDomain Result { get; set; }
}

    }
}
