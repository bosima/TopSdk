using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.order.batch.get
    /// </summary>
    public class OapiRhinoOrderBatchGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoOrderBatchGetResponse>
    {
        /// <summary>
        /// 请求体
        /// </summary>
        public string Req { get; set; }

        public OpenApiBatchGetProductOrderReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.order.batch.get";
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
        }

	/// <summary>
/// OpenApiBatchGetProductOrderReqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiBatchGetProductOrderReqDomain : TopObject
{
	        /// <summary>
	        /// 订单id列表
	        /// </summary>
	        [XmlArray("id_list")]
	        [XmlArrayItem("number")]
	        public List<string> IdList { get; set; }
	
	        /// <summary>
	        /// 租户Id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
