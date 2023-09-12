using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRhinoMosExecClothesSizeCountResponse.
    /// </summary>
    public class OapiRhinoMosExecClothesSizeCountResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlArray("model")]
        [XmlArrayItem("clothes_count_group_by_size_dto")]
        public List<ClothesCountGroupBySizeDtoDomain> Model { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ClothesCountGroupBySizeDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ClothesCountGroupBySizeDtoDomain : TopObject
{
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("count")]
	        public long Count { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("size_code")]
	        public string SizeCode { get; set; }
}

    }
}
