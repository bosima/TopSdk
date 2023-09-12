using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.feed.sync
    /// </summary>
    public class OapiEduFeedSyncRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduFeedSyncResponse>
    {
        /// <summary>
        /// 媒体相册id
        /// </summary>
        public string AlbumId { get; set; }

        /// <summary>
        /// 部门或班级id
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        /// <summary>
        /// 同步类型(1.全量同步，2.单个同步)
        /// </summary>
        public Nullable<long> FeeType { get; set; }

        /// <summary>
        /// 媒体list
        /// </summary>
        public string FeedMedias { get; set; }

        public List<IndustrySyncFeedMediaReqDomain> FeedMedias_ { set { this.FeedMedias = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 拓展字段
        /// </summary>
        public string Future { get; set; }

        /// <summary>
        /// 媒体用户id
        /// </summary>
        public string MediaUid { get; set; }

        /// <summary>
        /// 接口同步id(选填)
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 发送时间戳(毫秒)
        /// </summary>
        public Nullable<long> SendTime { get; set; }

        /// <summary>
        /// 媒体发送用户id
        /// </summary>
        public string SendUid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.feed.sync";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("album_id", this.AlbumId);
            parameters.Add("dept_id", this.DeptId);
            parameters.Add("fee_type", this.FeeType);
            parameters.Add("feed_medias", this.FeedMedias);
            parameters.Add("future", this.Future);
            parameters.Add("media_uid", this.MediaUid);
            parameters.Add("op_userId", this.OpUserId);
            parameters.Add("send_time", this.SendTime);
            parameters.Add("send_uid", this.SendUid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("fee_type", this.FeeType);
            RequestValidator.ValidateRequired("feed_medias", this.FeedMedias);
            RequestValidator.ValidateObjectMaxListSize("feed_medias", this.FeedMedias, 999);
        }

	/// <summary>
/// IndustrySyncFeedMediaReqDomain Data Structure.
/// </summary>
[Serializable]

public class IndustrySyncFeedMediaReqDomain : TopObject
{
	        /// <summary>
	        /// 媒体类型
	        /// </summary>
	        [XmlElement("media_type")]
	        public Nullable<long> MediaType { get; set; }
	
	        /// <summary>
	        /// 媒体链接
	        /// </summary>
	        [XmlElement("media_url")]
	        public string MediaUrl { get; set; }
	
	        /// <summary>
	        /// 媒体缩略图链接
	        /// </summary>
	        [XmlElement("thumbnail_url")]
	        public string ThumbnailUrl { get; set; }
}

        #endregion
    }
}
