using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.cost.center.query
    /// </summary>
    public class OapiAlitripBtripCostCenterQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripCostCenterQueryResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Rq { get; set; }

        public OpenCostCenterQueryRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.cost.center.query";
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
/// OpenCostCenterQueryRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCostCenterQueryRqDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 是否需要展示成员信息，当成本中心为部分人员适用的时候有返回
	        /// </summary>
	        [XmlElement("need_org_entity")]
	        public Nullable<bool> NeedOrgEntity { get; set; }
	
	        /// <summary>
	        /// 第三方成本中心id，不填写的时候user_id必填
	        /// </summary>
	        [XmlElement("thirdpart_id")]
	        public string ThirdpartId { get; set; }
	
	        /// <summary>
	        /// 成本中心名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 用户id，不填的时候thirdpart_id必填
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
