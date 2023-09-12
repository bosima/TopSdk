using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.space.poi.upsert
    /// </summary>
    public class OapiRhinoMosSpacePoiUpsertRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosSpacePoiUpsertResponse>
    {
        /// <summary>
        /// request
        /// </summary>
        public string Request { get; set; }

        public SpacePoiUpsertReqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.space.poi.upsert";
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
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// SpacePoiUpsertReqDomain Data Structure.
/// </summary>
[Serializable]

public class SpacePoiUpsertReqDomain : TopObject
{
	        /// <summary>
	        /// 类目code
	        /// </summary>
	        [XmlElement("category_code")]
	        public string CategoryCode { get; set; }
	
	        /// <summary>
	        /// 类目子code
	        /// </summary>
	        [XmlElement("category_sub_code")]
	        public string CategorySubCode { get; set; }
	
	        /// <summary>
	        /// 兴趣点code
	        /// </summary>
	        [XmlElement("poi_code")]
	        public string PoiCode { get; set; }
	
	        /// <summary>
	        /// 兴趣点name
	        /// </summary>
	        [XmlElement("poi_name")]
	        public string PoiName { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
