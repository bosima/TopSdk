using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.humanres.corpemployee.get
    /// </summary>
    public class OapiRhinoHumanresCorpemployeeGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoHumanresCorpemployeeGetResponse>
    {
        /// <summary>
        /// 查询员工入参
        /// </summary>
        public string QueryCorpEmployeeParam { get; set; }

        public QueryCorpEmployeeDtoDomain QueryCorpEmployeeParam_ { set { this.QueryCorpEmployeeParam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.humanres.corpemployee.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query_corp_employee_param", this.QueryCorpEmployeeParam);
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
/// QueryCorpEmployeeDtoDomain Data Structure.
/// </summary>
[Serializable]

public class QueryCorpEmployeeDtoDomain : TopObject
{
	        /// <summary>
	        /// 资产ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 员工ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 工号
	        /// </summary>
	        [XmlElement("work_no")]
	        public string WorkNo { get; set; }
}

        #endregion
    }
}
