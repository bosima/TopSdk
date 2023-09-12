using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.kac.datav.videolive.detail.list
    /// </summary>
    public class OapiKacDatavVideoliveDetailListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiKacDatavVideoliveDetailListResponse>
    {
        /// <summary>
        /// 请求参数对象
        /// </summary>
        public string Request { get; set; }

        public VideoLiveDetailRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.kac.datav.videolive.detail.list";
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
/// VideoLiveDetailRequestDomain Data Structure.
/// </summary>
[Serializable]

public class VideoLiveDetailRequestDomain : TopObject
{
	        /// <summary>
	        /// 分页游标；首页请使用0，之后直接使用返回结果中的next_cursor
	        /// </summary>
	        [XmlElement("cursor")]
	        public Nullable<long> Cursor { get; set; }
	
	        /// <summary>
	        /// 日期标识
	        /// </summary>
	        [XmlElement("data_id")]
	        public string DataId { get; set; }
	
	        /// <summary>
	        /// 分页大小;不超过100
	        /// </summary>
	        [XmlElement("size")]
	        public Nullable<long> Size { get; set; }
}

        #endregion
    }
}
