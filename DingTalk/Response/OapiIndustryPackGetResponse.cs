using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiIndustryPackGetResponse.
    /// </summary>
    public class OapiIndustryPackGetResponse : DingTalkResponse
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
        /// 查询结果列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("package_dto")]
        public List<PackageDtoDomain> Result { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// PackageDtoDomain Data Structure.
/// </summary>
[Serializable]

public class PackageDtoDomain : TopObject
{
	        /// <summary>
	        /// 课包ID
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 课包名称
	        /// </summary>
	        [XmlElement("package_name")]
	        public string PackageName { get; set; }
}

    }
}
