using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.employee.dismission.update
    /// </summary>
    public class OapiSmartworkHrmEmployeeDismissionUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmEmployeeDismissionUpdateResponse>
    {
        /// <summary>
        /// 微应用在企业的AgentId
        /// </summary>
        public string Agentid { get; set; }

        /// <summary>
        /// 离职信息
        /// </summary>
        public string Param { get; set; }

        public EmpDismissionUpdateParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.employee.dismission.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("param", this.Param);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("agentid", this.Agentid);
            RequestValidator.ValidateRequired("param", this.Param);
        }

	/// <summary>
/// EmpDismissionUpdateParamDomain Data Structure.
/// </summary>
[Serializable]

public class EmpDismissionUpdateParamDomain : TopObject
{
	        /// <summary>
	        /// 离职备注
	        /// </summary>
	        [XmlElement("dismission_memo")]
	        public string DismissionMemo { get; set; }
	
	        /// <summary>
	        /// 最后工作日期
	        /// </summary>
	        [XmlElement("last_work_date")]
	        public Nullable<DateTime> LastWorkDate { get; set; }
	
	        /// <summary>
	        /// 是否计入离职不统计
	        /// </summary>
	        [XmlElement("partner")]
	        public Nullable<bool> Partner { get; set; }
	
	        /// <summary>
	        /// 主动原因
	        /// </summary>
	        [XmlArray("terminationReasonPassive")]
	        [XmlArrayItem("string")]
	        public List<string> TerminationReasonPassive { get; set; }
	
	        /// <summary>
	        /// 被动原因
	        /// </summary>
	        [XmlArray("terminationReasonVoluntary")]
	        [XmlArrayItem("string")]
	        public List<string> TerminationReasonVoluntary { get; set; }
	
	        /// <summary>
	        /// 员工userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
