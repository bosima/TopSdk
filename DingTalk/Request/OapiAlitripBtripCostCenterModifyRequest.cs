using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.cost.center.modify
    /// </summary>
    public class OapiAlitripBtripCostCenterModifyRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripCostCenterModifyResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Rq { get; set; }

        public OpenCostCenterModifyRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.cost.center.modify";
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
/// OpenCostCenterModifyRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCostCenterModifyRqDomain : TopObject
{
	        /// <summary>
	        /// 绑定支付宝账号
	        /// </summary>
	        [XmlElement("alipay_no")]
	        public string AlipayNo { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 成本中心编号
	        /// </summary>
	        [XmlElement("number")]
	        public string Number { get; set; }
	
	        /// <summary>
	        /// 适用范围: 1全员，2部分员工
	        /// </summary>
	        [XmlElement("scope")]
	        public Nullable<long> Scope { get; set; }
	
	        /// <summary>
	        /// 第三方成本中心id
	        /// </summary>
	        [XmlElement("thirdpart_id")]
	        public string ThirdpartId { get; set; }
	
	        /// <summary>
	        /// 成本中心名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

        #endregion
    }
}
