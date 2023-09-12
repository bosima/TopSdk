using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCirclePostListResponse.
    /// </summary>
    public class OapiEduCirclePostListResponse : DingTalkResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("result")]
        public OpenCircleTopicResponseDomain Result { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OrgUserDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OrgUserDtoDomain : TopObject
{
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("show_name")]
	        public string ShowName { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("staff_id")]
	        public string StaffId { get; set; }
}

	/// <summary>
/// CommentsDomain Data Structure.
/// </summary>
[Serializable]

public class CommentsDomain : TopObject
{
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("comment_id")]
	        public long CommentId { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("origin_user")]
	        public OrgUserDtoDomain OriginUser { get; set; }
}

	/// <summary>
/// AuthorDomain Data Structure.
/// </summary>
[Serializable]

public class AuthorDomain : TopObject
{
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("avatar_media_id")]
	        public string AvatarMediaId { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("icon_media_id")]
	        public string IconMediaId { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("is_owner")]
	        public bool IsOwner { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("owner")]
	        public bool Owner { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("show_name")]
	        public string ShowName { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("staff_id")]
	        public string StaffId { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("tag")]
	        public long Tag { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("user_role")]
	        public string UserRole { get; set; }
}

	/// <summary>
/// ContentDomain Data Structure.
/// </summary>
[Serializable]

public class ContentDomain : TopObject
{
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("content_type")]
	        public long ContentType { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("geo_content")]
	        public string GeoContent { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
}

	/// <summary>
/// PostsDomain Data Structure.
/// </summary>
[Serializable]

public class PostsDomain : TopObject
{
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("author")]
	        public AuthorDomain Author { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("biz_id")]
	        public string BizId { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlArray("comments")]
	        [XmlArrayItem("comments")]
	        public List<CommentsDomain> Comments { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("content")]
	        public ContentDomain Content { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("create_at")]
	        public long CreateAt { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("feed_type")]
	        public long FeedType { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("post_id")]
	        public long PostId { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("tags")]
	        public string Tags { get; set; }
}

	/// <summary>
/// OpenCircleTopicResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCircleTopicResponseDomain : TopObject
{
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlArray("posts")]
	        [XmlArrayItem("posts")]
	        public List<PostsDomain> Posts { get; set; }
}

    }
}
