using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.mos.space.workstation.list
    /// </summary>
    public class OapiRhinoMosSpaceWorkstationListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoMosSpaceWorkstationListResponse>
    {
        /// <summary>
        /// request
        /// </summary>
        public string Request { get; set; }

        public ProdWorkstationConditionListReqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.mos.space.workstation.list";
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
/// ProdWorkstationConditionListReqDomain Data Structure.
/// </summary>
[Serializable]

public class ProdWorkstationConditionListReqDomain : TopObject
{
	        /// <summary>
	        /// 站位code列表
	        /// </summary>
	        [XmlArray("prod_workstation_code_list")]
	        [XmlArrayItem("string")]
	        public List<string> ProdWorkstationCodeList { get; set; }
	
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
