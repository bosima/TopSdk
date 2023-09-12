using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.instance.cancel
    /// </summary>
    public class OapiProcessInstanceCancelRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessInstanceCancelResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Request { get; set; }

        public CancelProcessInstanceRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.instance.cancel";
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
        }

	/// <summary>
/// CancelProcessInstanceRequestDomain Data Structure.
/// </summary>
[Serializable]

public class CancelProcessInstanceRequestDomain : TopObject
{
	        /// <summary>
	        /// 本次作废操作的发起者名字，通常指代系统名称
	        /// </summary>
	        [XmlElement("operator_name")]
	        public string OperatorName { get; set; }
	
	        /// <summary>
	        /// 审批实例id
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
	
	        /// <summary>
	        /// 本次作废操作的系统描述，会在审批操作记录里已操作备注的形式展示出来
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
}

        #endregion
    }
}
