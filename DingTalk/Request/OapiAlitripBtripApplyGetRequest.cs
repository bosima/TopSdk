using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.apply.get
    /// </summary>
    public class OapiAlitripBtripApplyGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripApplyGetResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Rq { get; set; }

        public OpenSearchRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.apply.get";
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
/// OpenSearchRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenSearchRqDomain : TopObject
{
	        /// <summary>
	        /// 阿里商旅审批单id
	        /// </summary>
	        [XmlElement("apply_id")]
	        public Nullable<long> ApplyId { get; set; }
	
	        /// <summary>
	        /// 阿里商旅审批单展示id
	        /// </summary>
	        [XmlElement("apply_show_id")]
	        public string ApplyShowId { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 外部审批单id
	        /// </summary>
	        [XmlElement("thirdpart_apply_id")]
	        public string ThirdpartApplyId { get; set; }
	
	        /// <summary>
	        /// 申请单提交类型 1：代提交 2：本人提交 注意：当申请单为代提交时，申请单提交人自己无法为自己下单
	        /// </summary>
	        [XmlElement("type")]
	        public Nullable<long> Type { get; set; }
}

        #endregion
    }
}
