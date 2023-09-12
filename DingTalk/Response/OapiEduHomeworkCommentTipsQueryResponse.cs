using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduHomeworkCommentTipsQueryResponse.
    /// </summary>
    public class OapiEduHomeworkCommentTipsQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误编码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("open_hw_comment_tips_response")]
        public List<OpenHwCommentTipsResponseDomain> Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenHwCommentTipsResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenHwCommentTipsResponseDomain : TopObject
{
	        /// <summary>
	        /// 属性字段
	        /// </summary>
	        [XmlElement("attributes")]
	        public string Attributes { get; set; }
	
	        /// <summary>
	        /// 音频
	        /// </summary>
	        [XmlElement("audio")]
	        public string Audio { get; set; }
	
	        /// <summary>
	        /// 内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 视频
	        /// </summary>
	        [XmlElement("media")]
	        public string Media { get; set; }
	
	        /// <summary>
	        /// 图片
	        /// </summary>
	        [XmlElement("photo")]
	        public string Photo { get; set; }
	
	        /// <summary>
	        /// 用户userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
