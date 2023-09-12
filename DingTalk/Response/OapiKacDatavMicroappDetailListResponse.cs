using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavMicroappDetailListResponse.
    /// </summary>
    public class OapiKacDatavMicroappDetailListResponse : DingTalkResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public MicroAppSummaryResponseDomain Result { get; set; }

	/// <summary>
/// MicroAppSummaryVoDomain Data Structure.
/// </summary>
[Serializable]

public class MicroAppSummaryVoDomain : TopObject
{
	        /// <summary>
	        /// 微应用名
	        /// </summary>
	        [XmlElement("micro_app_name")]
	        public string MicroAppName { get; set; }
	
	        /// <summary>
	        /// 微应用类型
	        /// </summary>
	        [XmlElement("micro_app_type")]
	        public long MicroAppType { get; set; }
	
	        /// <summary>
	        /// 访问用户数
	        /// </summary>
	        [XmlElement("micro_app_user_count")]
	        public long MicroAppUserCount { get; set; }
}

	/// <summary>
/// MicroAppSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class MicroAppSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// 数据列表
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("micro_app_summary_vo")]
	        public List<MicroAppSummaryVoDomain> Data { get; set; }
	
	        /// <summary>
	        /// 是否有下一页；true则存在更多分页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一次请求的分页游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
