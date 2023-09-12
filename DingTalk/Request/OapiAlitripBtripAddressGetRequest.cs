using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.address.get
    /// </summary>
    public class OapiAlitripBtripAddressGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripAddressGetResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Request { get; set; }

        public OpenApiJumpInfoRqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.address.get";
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
        }

	/// <summary>
/// OpenApiJumpInfoRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiJumpInfoRqDomain : TopObject
{
	        /// <summary>
	        /// 操作类型：1：预订，2：我的订单列表，3：商旅管理后台（其他参数可不要，只需corpid，userid），4：h5商旅首页
	        /// </summary>
	        [XmlElement("action_type")]
	        public Nullable<long> ActionType { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 第三方行程id（存在代表通过审批单预订，不存在代表特殊场景：普通员工是预览，特殊授权人和代订人是免审批预订场景）
	        /// </summary>
	        [XmlElement("itinerary_id")]
	        public string ItineraryId { get; set; }
	
	        /// <summary>
	        /// 员工第一次使用用车需要手机号，与司机联系
	        /// </summary>
	        [XmlElement("phone")]
	        public string Phone { get; set; }
	
	        /// <summary>
	        /// 类目类型：1：机票，2：火车票，3：酒店，4：用车
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
