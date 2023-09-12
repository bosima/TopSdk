using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.rhino.humanres.productionteam.query
    /// </summary>
    public class OapiRhinoHumanresProductionteamQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiRhinoHumanresProductionteamQueryResponse>
    {
        /// <summary>
        /// 查询生产组入参
        /// </summary>
        public string QueryProductionTeamParam { get; set; }

        public QueryProductionTeamDtoDomain QueryProductionTeamParam_ { set { this.QueryProductionTeamParam = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.rhino.humanres.productionteam.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query_production_team_param", this.QueryProductionTeamParam);
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
/// QueryProductionTeamDtoDomain Data Structure.
/// </summary>
[Serializable]

public class QueryProductionTeamDtoDomain : TopObject
{
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<DateTime> EndTime { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public Nullable<DateTime> StartTime { get; set; }
	
	        /// <summary>
	        /// 资产ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// 预业务参数[这里先预留],这里是用户ID,比如钉钉用户ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 工段CODE
	        /// </summary>
	        [XmlElement("workshop_section_code")]
	        public string WorkshopSectionCode { get; set; }
}

        #endregion
    }
}
