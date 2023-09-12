using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.circle.post.list
    /// </summary>
    public class OapiEduCirclePostListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduCirclePostListResponse>
    {
        /// <summary>
        /// 1
        /// </summary>
        public string OpenFeedQueryParam { get; set; }

        public OpenFeedQueryParamDomain OpenFeedQueryParam_ { set { this.OpenFeedQueryParam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.circle.post.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_feed_query_param", this.OpenFeedQueryParam);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// OpenFeedQueryParamDomain Data Structure.
/// </summary>
[Serializable]

public class OpenFeedQueryParamDomain : TopObject
{
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("biz_type")]
	        public Nullable<long> BizType { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("class_id")]
	        public Nullable<long> ClassId { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("count")]
	        public Nullable<long> Count { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("cursor")]
	        public Nullable<long> Cursor { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("feed_type")]
	        public Nullable<long> FeedType { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("student_id")]
	        public string StudentId { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("topic_id")]
	        public Nullable<long> TopicId { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("user_role")]
	        public string UserRole { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
