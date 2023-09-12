using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProjectInviteDataQueryResponse.
    /// </summary>
    public class OapiProjectInviteDataQueryResponse : DingTalkResponse
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
        /// 响应结果
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// InviteDataModelDomain Data Structure.
/// </summary>
[Serializable]

public class InviteDataModelDomain : TopObject
{
	        /// <summary>
	        /// 渠道，"MARKET"表示通过营销的数据，其他是通过系统的方式进入
	        /// </summary>
	        [XmlElement("channel")]
	        public string Channel { get; set; }
	
	        /// <summary>
	        /// 组织机构id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 结果数据，场景ID，sence_id会放在这个地方
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 修改时间，亦用于游标查询
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public long GmtModified { get; set; }
	
	        /// <summary>
	        /// 邀请人用户id
	        /// </summary>
	        [XmlElement("invite_userid")]
	        public string InviteUserid { get; set; }
	
	        /// <summary>
	        /// 加入日期，格式：yyyyMMdd
	        /// </summary>
	        [XmlElement("join_at")]
	        public long JoinAt { get; set; }
	
	        /// <summary>
	        /// 状态.0表示无效（包括过程数据），1:表示有效
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 被邀请人用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 结果集数据
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("invite_data_model")]
	        public List<InviteDataModelDomain> Data { get; set; }
	
	        /// <summary>
	        /// 是否有更多数据，如果为false，这表示本次查询没有更多的数据了。
	        /// </summary>
	        [XmlElement("has_more")]
	        public string HasMore { get; set; }
	
	        /// <summary>
	        /// 下次游标开始
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
}

    }
}
