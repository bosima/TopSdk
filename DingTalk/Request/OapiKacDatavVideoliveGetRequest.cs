using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.kac.datav.videolive.get
    /// </summary>
    public class OapiKacDatavVideoliveGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiKacDatavVideoliveGetResponse>
    {
        /// <summary>
        /// 请求参数对象
        /// </summary>
        public string ParamVideoLiveSummaryRequest { get; set; }

        public VideoLiveSummaryRequestDomain ParamVideoLiveSummaryRequest_ { set { this.ParamVideoLiveSummaryRequest = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.kac.datav.videolive.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_video_live_summary_request", this.ParamVideoLiveSummaryRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("param_video_live_summary_request", this.ParamVideoLiveSummaryRequest);
        }

	/// <summary>
/// VideoLiveSummaryRequestDomain Data Structure.
/// </summary>
[Serializable]

public class VideoLiveSummaryRequestDomain : TopObject
{
	        /// <summary>
	        /// 日期标识
	        /// </summary>
	        [XmlElement("data_id")]
	        public string DataId { get; set; }
}

        #endregion
    }
}
