using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiReportStatisticsResponse.
    /// </summary>
    public class OapiReportStatisticsResponse : DingTalkResponse
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
        /// 统计结果
        /// </summary>
        [XmlElement("result")]
        public ReportStatisticsVoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ReportStatisticsVoDomain Data Structure.
/// </summary>
[Serializable]

public class ReportStatisticsVoDomain : TopObject
{
	        /// <summary>
	        /// 评论个数
	        /// </summary>
	        [XmlElement("comment_num")]
	        public long CommentNum { get; set; }
	
	        /// <summary>
	        /// 评论人数，去重
	        /// </summary>
	        [XmlElement("comment_user_num")]
	        public long CommentUserNum { get; set; }
	
	        /// <summary>
	        /// 点赞人数
	        /// </summary>
	        [XmlElement("like_num")]
	        public long LikeNum { get; set; }
	
	        /// <summary>
	        /// 已读人数
	        /// </summary>
	        [XmlElement("read_num")]
	        public long ReadNum { get; set; }
}

    }
}
