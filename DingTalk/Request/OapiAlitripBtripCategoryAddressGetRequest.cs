using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.category.address.get
    /// </summary>
    public class OapiAlitripBtripCategoryAddressGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripCategoryAddressGetResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Rq { get; set; }

        public OpenJumpInfoRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.category.address.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("rq", this.Rq);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("rq", this.Rq);
        }

	/// <summary>
/// OpenJumpInfoRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenJumpInfoRqDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 第三方行程id
	        /// </summary>
	        [XmlElement("itinerary_id")]
	        public string ItineraryId { get; set; }
	
	        /// <summary>
	        /// 跳转类型：1机票，2火车票，3酒店
	        /// </summary>
	        [XmlElement("type")]
	        public Nullable<long> Type { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
