using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.clothes.unperformed.get
    /// </summary>
    public class OapiRhinoMosExecClothesUnperformedGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecClothesUnperformedGetResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Req { get; set; }

        public GetUnPerformedClothesByOperationReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.clothes.unperformed.get";
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
/// PageDomain Data Structure.
/// </summary>
[Serializable]

public class PageDomain : TopObject
{
	        /// <summary>
	        /// 页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 其实位置
	        /// </summary>
	        [XmlElement("start")]
	        public Nullable<long> Start { get; set; }
}

	/// <summary>
/// GetUnPerformedClothesByOperationReqDomain Data Structure.
/// </summary>
[Serializable]

public class GetUnPerformedClothesByOperationReqDomain : TopObject
{
	        /// <summary>
	        /// 业务类型
	        /// </summary>
	        [XmlArray("biz_types")]
	        [XmlArrayItem("string")]
	        public List<string> BizTypes { get; set; }
	
	        /// <summary>
	        /// 工序id
	        /// </summary>
	        [XmlArray("operation_uids")]
	        [XmlArrayItem("number")]
	        public List<string> OperationUids { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
	        /// <summary>
	        /// 分页
	        /// </summary>
	        [XmlElement("page")]
	        public PageDomain Page { get; set; }
	
	        /// <summary>
	        /// 尺码信息
	        /// </summary>
	        [XmlElement("size_code")]
	        public string SizeCode { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlArray("status")]
	        [XmlArrayItem("string")]
	        public List<string> Status { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
