using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.exec.clothes.id.listbypage
    /// </summary>
    public class OapiRhinoMosExecClothesIdListbypageRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosExecClothesIdListbypageResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Req { get; set; }

        public PageQueryClothesReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.exec.clothes.id.listbypage";
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
/// PageDomain Data Structure.
/// </summary>
[Serializable]

public class PageDomain : TopObject
{
	        /// <summary>
	        /// 每页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 起始位置，从0开始
	        /// </summary>
	        [XmlElement("start")]
	        public Nullable<long> Start { get; set; }
}

	/// <summary>
/// SourceDomain Data Structure.
/// </summary>
[Serializable]

public class SourceDomain : TopObject
{
	        /// <summary>
	        /// 来源ID，创建该实体的来源业务ID，会用来源ID和来源类型一起做幂等
	        /// </summary>
	        [XmlElement("source_id")]
	        public string SourceId { get; set; }
	
	        /// <summary>
	        /// 来源类型，创建该实体的来源的类型
	        /// </summary>
	        [XmlElement("source_type")]
	        public string SourceType { get; set; }
}

	/// <summary>
/// PageQueryClothesReqDomain Data Structure.
/// </summary>
[Serializable]

public class PageQueryClothesReqDomain : TopObject
{
	        /// <summary>
	        /// 业务类型
	        /// </summary>
	        [XmlArray("biz_types")]
	        [XmlArrayItem("string")]
	        public List<string> BizTypes { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("order_id")]
	        public Nullable<long> OrderId { get; set; }
	
	        /// <summary>
	        /// 分页
	        /// </summary>
	        [XmlElement("page")]
	        public PageDomain Page { get; set; }
	
	        /// <summary>
	        /// 尺码CODE
	        /// </summary>
	        [XmlElement("size_code")]
	        public string SizeCode { get; set; }
	
	        /// <summary>
	        /// 来源
	        /// </summary>
	        [XmlElement("source")]
	        public SourceDomain Source { get; set; }
	
	        /// <summary>
	        /// 状态列表
	        /// </summary>
	        [XmlArray("status_list")]
	        [XmlArrayItem("string")]
	        public List<string> StatusList { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 预留参数
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
