using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProjectPointHistoryPageResponse.
    /// </summary>
    public class OapiProjectPointHistoryPageResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public PageResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// PointHistoryDTODomain Data Structure.
/// </summary>
[Serializable]

public class PointHistoryDTODomain : TopObject
{
	        /// <summary>
	        /// 组织ID
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 创建时间（精确到毫秒数）
	        /// </summary>
	        [XmlElement("create_at")]
	        public long CreateAt { get; set; }
	
	        /// <summary>
	        /// 对应的行为代码（可空）
	        /// </summary>
	        [XmlElement("rule_code")]
	        public string RuleCode { get; set; }
	
	        /// <summary>
	        /// 对应的行为描述
	        /// </summary>
	        [XmlElement("rule_name")]
	        public string RuleName { get; set; }
	
	        /// <summary>
	        /// 增加或减少的分数（增加为正数，减少为负数）
	        /// </summary>
	        [XmlElement("score")]
	        public long Score { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 幂等键
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否有更多数据，如果为false，这表示本次查询没有更多的数据了。
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 结果集数据
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("point_history_d_t_o")]
	        public List<PointHistoryDTODomain> List { get; set; }
	
	        /// <summary>
	        /// 下次游标开始
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
