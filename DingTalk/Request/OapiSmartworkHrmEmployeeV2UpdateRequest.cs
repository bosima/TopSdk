using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.employee.v2.update
    /// </summary>
    public class OapiSmartworkHrmEmployeeV2UpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmEmployeeV2UpdateResponse>
    {
        /// <summary>
        /// 微应用在企业的AgentId
        /// </summary>
        public Nullable<long> Agentid { get; set; }

        /// <summary>
        /// 编辑花名册入参
        /// </summary>
        public string Param { get; set; }

        public EmpUpdateByCustomParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.employee.v2.update";
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
	        /// 字段标识
	        /// </summary>
	        [XmlElement("field_code")]
	        public string FieldCode { get; set; }
	
	        /// <summary>
	        /// 字段值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// EmpListFieldVoDomain Data Structure.
/// </summary>
[Serializable]

public class EmpListFieldVoDomain : TopObject
{
	        /// <summary>
	        /// 明细下标（注意：当传入该值时，表示当前传入的section为编辑员工花名册现有的第oldIndex条明细，此时系统会只编辑该条明细中传入的字段；当不传入该值时，表示传入的是新增明细，此时系统会保存该条明细传入的字段，未传字段会清空）
	        /// </summary>
	        [XmlElement("old_index")]
	        public Nullable<long> OldIndex { get; set; }
	
	        /// <summary>
	        /// 分组下字段列表
	        /// </summary>
	        [XmlArray("section")]
	        [XmlArrayItem("emp_field_vo")]
	        public List<EmpFieldVoDomain> Section { get; set; }
}

	/// <summary>
/// EmpGroupFieldVoDomain Data Structure.
/// </summary>
[Serializable]

public class EmpGroupFieldVoDomain : TopObject
{
	        /// <summary>
	        /// 分组标识
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 分组下明细（非明细分组仅一条明细）
	        /// </summary>
	        [XmlArray("sections")]
	        [XmlArrayItem("emp_list_field_vo")]
	        public List<EmpListFieldVoDomain> Sections { get; set; }
}

	/// <summary>
/// EmpUpdateByCustomParamDomain Data Structure.
/// </summary>
[Serializable]

public class EmpUpdateByCustomParamDomain : TopObject
{
	        /// <summary>
	        /// 花名册分组
	        /// </summary>
	        [XmlArray("groups")]
	        [XmlArrayItem("emp_group_field_vo")]
	        public List<EmpGroupFieldVoDomain> Groups { get; set; }
	
	        /// <summary>
	        /// 员工userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
