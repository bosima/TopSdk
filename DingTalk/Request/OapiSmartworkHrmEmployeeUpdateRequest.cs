using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.employee.update
    /// </summary>
    public class OapiSmartworkHrmEmployeeUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmEmployeeUpdateResponse>
    {
        /// <summary>
        /// 微应用在企业的AgentId
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 添加待入职入参
        /// </summary>
        public string Param { get; set; }

        public PreEntryEmployeeAddParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.employee.update";
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
/// EmpFieldVoDomain Data Structure.
/// </summary>
[Serializable]

public class EmpFieldVoDomain : TopObject
{
	        /// <summary>
	        /// 更新的字段code
	        /// </summary>
	        [XmlElement("field_code")]
	        public string FieldCode { get; set; }
	
	        /// <summary>
	        /// 更新的字段值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// EmpListFieldVODomain Data Structure.
/// </summary>
[Serializable]

public class EmpListFieldVODomain : TopObject
{
	        /// <summary>
	        /// 单个组所有字段
	        /// </summary>
	        [XmlArray("section")]
	        [XmlArrayItem("emp_field_vo")]
	        public List<EmpFieldVoDomain> Section { get; set; }
}

	/// <summary>
/// GroupMetaInfoDomain Data Structure.
/// </summary>
[Serializable]

public class GroupMetaInfoDomain : TopObject
{
	        /// <summary>
	        /// 需改的字段所在组ID
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 同类型组明细
	        /// </summary>
	        [XmlArray("sections")]
	        [XmlArrayItem("emp_list_field_v_o")]
	        public List<EmpListFieldVODomain> Sections { get; set; }
}

	/// <summary>
/// PreEntryEmployeeAddParamDomain Data Structure.
/// </summary>
[Serializable]

public class PreEntryEmployeeAddParamDomain : TopObject
{
	        /// <summary>
	        /// 所有组明细
	        /// </summary>
	        [XmlArray("groups")]
	        [XmlArrayItem("group_meta_info")]
	        public List<GroupMetaInfoDomain> Groups { get; set; }
	
	        /// <summary>
	        /// staff_id or userId用户在企业的唯一标识
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
