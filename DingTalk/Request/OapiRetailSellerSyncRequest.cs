using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.retail.seller.sync
    /// </summary>
    public class OapiRetailSellerSyncRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRetailSellerSyncResponse>
    {
        /// <summary>
        /// 卖家信息
        /// </summary>
        public string SellerParam { get; set; }

        public SellerParamDomain SellerParam_ { set { this.SellerParam = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// staffId
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.retail.seller.sync";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("seller_param", this.SellerParam);
            parameters.Add("userid", this.Userid);
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
/// SellerParamDomain Data Structure.
/// </summary>
[Serializable]

public class SellerParamDomain : TopObject
{
	        /// <summary>
	        /// 操作类型
	        /// </summary>
	        [XmlElement("action_type")]
	        public string ActionType { get; set; }
	
	        /// <summary>
	        /// 手机号
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 商家名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 卖家ID
	        /// </summary>
	        [XmlElement("seller_id")]
	        public Nullable<long> SellerId { get; set; }
	
	        /// <summary>
	        /// 开店来源
	        /// </summary>
	        [XmlElement("source")]
	        public string Source { get; set; }
	
	        /// <summary>
	        /// 原始手机号
	        /// </summary>
	        [XmlElement("src_mobile")]
	        public string SrcMobile { get; set; }
}

        #endregion
    }
}
