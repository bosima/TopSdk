using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.approvers.forecast
    /// </summary>
    public class OapiProcessApproversForecastRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessApproversForecastResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public ProcessForecastRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.approvers.forecast";
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
/// FormComponentValueVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormComponentValueVoDomain : TopObject
{
	        /// <summary>
	        /// 组件名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 组件值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// ProcessForecastRequestDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessForecastRequestDomain : TopObject
{
	        /// <summary>
	        /// 应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 表单数据
	        /// </summary>
	        [XmlArray("form_component_values")]
	        [XmlArrayItem("form_component_value_vo")]
	        public List<FormComponentValueVoDomain> FormComponentValues { get; set; }
	
	        /// <summary>
	        /// 发起人所在部门
	        /// </summary>
	        [XmlElement("originator_deptid")]
	        public Nullable<long> OriginatorDeptid { get; set; }
	
	        /// <summary>
	        /// 发起人id
	        /// </summary>
	        [XmlElement("originator_userid")]
	        public string OriginatorUserid { get; set; }
	
	        /// <summary>
	        /// 模板唯一码
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
}

        #endregion
    }
}
