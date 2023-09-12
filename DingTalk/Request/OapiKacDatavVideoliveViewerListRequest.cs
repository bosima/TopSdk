using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.kac.datav.videolive.viewer.list
    /// </summary>
    public class OapiKacDatavVideoliveViewerListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiKacDatavVideoliveViewerListResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Request { get; set; }

        public GroupLiveViewerReqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.kac.datav.videolive.viewer.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// GroupLiveViewerReqDomain Data Structure.
/// </summary>
[Serializable]

public class GroupLiveViewerReqDomain : TopObject
{
	        /// <summary>
	        /// 群标识id
	        /// </summary>
	        [XmlElement("cid")]
	        public string Cid { get; set; }
	
	        /// <summary>
	        /// 分页游标；首页请使用0，之后直接使用返回结果中的next_cursor
	        /// </summary>
	        [XmlElement("cursor")]
	        public Nullable<long> Cursor { get; set; }
	
	        /// <summary>
	        /// 直播uuid
	        /// </summary>
	        [XmlElement("live_uuid")]
	        public string LiveUuid { get; set; }
	
	        /// <summary>
	        /// 对外群id
	        /// </summary>
	        [XmlElement("openConversationId")]
	        public string OpenConversationId { get; set; }
	
	        /// <summary>
	        /// 分页大小;不超过500
	        /// </summary>
	        [XmlElement("size")]
	        public Nullable<long> Size { get; set; }
}

        #endregion
    }
}
