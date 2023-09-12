using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiStatisticsDetailsResponse.
    /// </summary>
    public class OapiStatisticsDetailsResponse : DingTalkResponse
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
        /// 企业具体数据
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("enterprise_data_vo")]
        public List<EnterpriseDataVoDomain> Result { get; set; }

	/// <summary>
/// EnterpriseDataVoDomain Data Structure.
/// </summary>
[Serializable]

public class EnterpriseDataVoDomain : TopObject
{
	        /// <summary>
	        /// 数据的日期,格式为yyyy-MM-dd
	        /// </summary>
	        [XmlElement("date")]
	        public string Date { get; set; }
	
	        /// <summary>
	        /// 返回的数据列
	        /// </summary>
	        [XmlElement("return_fields")]
	        public string ReturnFields { get; set; }
	
	        /// <summary>
	        /// 业务类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 数据的下载地址
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

    }
}
