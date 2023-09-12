using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.humanres.employee.productionteam.list
    /// </summary>
    public class OapiRhinoHumanresEmployeeProductionteamListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoHumanresEmployeeProductionteamListResponse>
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public string QueryEmployeeProductionTeamParam { get; set; }

        public QueryCorpEmployeeProductionTeamDtoDomain QueryEmployeeProductionTeamParam_ { set { this.QueryEmployeeProductionTeamParam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.humanres.employee.productionteam.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query_employee_production_team_param", this.QueryEmployeeProductionTeamParam);
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
/// QueryCorpEmployeeProductionTeamDtoDomain Data Structure.
/// </summary>
[Serializable]

public class QueryCorpEmployeeProductionTeamDtoDomain : TopObject
{
	        /// <summary>
	        /// 是否包含未激活或者离职状态
	        /// </summary>
	        [XmlElement("include_inactive")]
	        public Nullable<bool> IncludeInactive { get; set; }
	
	        /// <summary>
	        /// 资产ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// uicic 列表
	        /// </summary>
	        [XmlArray("uic_ids")]
	        [XmlArrayItem("number")]
	        public List<string> UicIds { get; set; }
	
	        /// <summary>
	        /// userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
