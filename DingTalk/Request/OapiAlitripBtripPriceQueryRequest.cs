using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.price.query
    /// </summary>
    public class OapiAlitripBtripPriceQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripPriceQueryResponse>
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        public string Req { get; set; }

        public OpenApiIntervalPriceRqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.price.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("req", this.Req);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("req", this.Req);
        }

	/// <summary>
/// OpenApiIntervalPriceRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiIntervalPriceRqDomain : TopObject
{
	        /// <summary>
	        /// 类目flight\hotel\train
	        /// </summary>
	        [XmlElement("category")]
	        public string Category { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 返程时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<DateTime> EndTime { get; set; }
	
	        /// <summary>
	        /// 从哪里出发
	        /// </summary>
	        [XmlElement("from_where")]
	        public string FromWhere { get; set; }
	
	        /// <summary>
	        /// 行程id
	        /// </summary>
	        [XmlElement("itinerary_id")]
	        public string ItineraryId { get; set; }
	
	        /// <summary>
	        /// 根据key查询
	        /// </summary>
	        [XmlElement("query_key")]
	        public string QueryKey { get; set; }
	
	        /// <summary>
	        /// 出发时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public Nullable<DateTime> StartTime { get; set; }
	
	        /// <summary>
	        /// 目的地
	        /// </summary>
	        [XmlElement("to_where")]
	        public string ToWhere { get; set; }
	
	        /// <summary>
	        /// 钉用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
