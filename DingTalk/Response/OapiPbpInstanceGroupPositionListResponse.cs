using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiPbpInstanceGroupPositionListResponse.
    /// </summary>
    public class OapiPbpInstanceGroupPositionListResponse : DingTalkResponse
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
        /// 分页结果
        /// </summary>
        [XmlElement("result")]
        public PageResultDomain Result { get; set; }

	/// <summary>
/// PositionVoDomain Data Structure.
/// </summary>
[Serializable]

public class PositionVoDomain : TopObject
{
	        /// <summary>
	        /// 位置唯一标识，根据type不同类型不同，如硬件类型代表硬件设备唯一标识
	        /// </summary>
	        [XmlElement("position_id")]
	        public string PositionId { get; set; }
	
	        /// <summary>
	        /// 位置名称
	        /// </summary>
	        [XmlElement("position_name")]
	        public string PositionName { get; set; }
	
	        /// <summary>
	        /// 位置类型，如100表示B1
	        /// </summary>
	        [XmlElement("position_type")]
	        public long PositionType { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否还有数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 位置列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("position_vo")]
	        public List<PositionVoDomain> List { get; set; }
	
	        /// <summary>
	        /// 下次请求需要带的游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
