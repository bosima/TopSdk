using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.smartwork.bpms.processinstance.create
    /// </summary>
    public class SmartworkBpmsProcessinstanceCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.SmartworkBpmsProcessinstanceCreateResponse>
    {
        /// <summary>
        /// 企业微应用标识
        /// </summary>
        public Nullable<long> AgentId { get; set; }

        /// <summary>
        /// 审批人userid列表
        /// </summary>
        public string Approvers { get; set; }

        /// <summary>
        /// 抄送人userid列表
        /// </summary>
        public string CcList { get; set; }

        /// <summary>
        /// 抄送时间,分为（START,FINISH,START_FINISH）
        /// </summary>
        public string CcPosition { get; set; }

        /// <summary>
        /// 发起人所在的部门
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        /// <summary>
        /// 审批流表单参数
        /// </summary>
        public string FormComponentValues { get; set; }

        public List<FormComponentValueVoDomain> FormComponentValues_ { set { this.FormComponentValues = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 审批实例发起人的userid
        /// </summary>
        public string OriginatorUserId { get; set; }

        /// <summary>
        /// 审批流的唯一码
        /// </summary>
        public string ProcessCode { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.smartwork.bpms.processinstance.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_id", this.AgentId);
            parameters.Add("approvers", this.Approvers);
            parameters.Add("cc_list", this.CcList);
            parameters.Add("cc_position", this.CcPosition);
            parameters.Add("dept_id", this.DeptId);
            parameters.Add("form_component_values", this.FormComponentValues);
            parameters.Add("originator_user_id", this.OriginatorUserId);
            parameters.Add("process_code", this.ProcessCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("approvers", this.Approvers);
            RequestValidator.ValidateMaxListSize("approvers", this.Approvers, 20);
            RequestValidator.ValidateMaxListSize("cc_list", this.CcList, 20);
            RequestValidator.ValidateRequired("dept_id", this.DeptId);
            RequestValidator.ValidateRequired("form_component_values", this.FormComponentValues);
            RequestValidator.ValidateObjectMaxListSize("form_component_values", this.FormComponentValues, 20);
            RequestValidator.ValidateRequired("originator_user_id", this.OriginatorUserId);
            RequestValidator.ValidateRequired("process_code", this.ProcessCode);
        }

	/// <summary>
/// FormComponentValueVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormComponentValueVoDomain : TopObject
{
	        /// <summary>
	        /// 扩展值
	        /// </summary>
	        [XmlElement("ext_value")]
	        public string ExtValue { get; set; }
	
	        /// <summary>
	        /// 表单每一栏的名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 表单每一栏的值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

        #endregion
    }
}
