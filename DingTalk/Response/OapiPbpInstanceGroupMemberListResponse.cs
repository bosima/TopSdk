using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiPbpInstanceGroupMemberListResponse.
    /// </summary>
    public class OapiPbpInstanceGroupMemberListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误结果
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
	        /// 成员id，根据类型不同表示不同
	        /// </summary>
	        [XmlElement("member_id")]
	        public string MemberId { get; set; }
	
	        /// <summary>
	        /// 成员类型，0表示员工，1表示部门
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
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
	        /// 列表结果
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
