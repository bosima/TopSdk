using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.instance.terminate
    /// </summary>
    public class OapiProcessInstanceTerminateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessInstanceTerminateResponse>
    {
        /// <summary>
        /// 终止审批请求
        /// </summary>
        public string Request { get; set; }

        public TerminateProcessInstanceRequestV2Domain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.instance.terminate";
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
/// TerminateProcessInstanceRequestV2Domain Data Structure.
/// </summary>
[Serializable]

public class TerminateProcessInstanceRequestV2Domain : TopObject
{
	        /// <summary>
	        /// 是否系统调用
	        /// </summary>
	        [XmlElement("is_system")]
	        public Nullable<bool> IsSystem { get; set; }
	
	        /// <summary>
	        /// 操作人工号
	        /// </summary>
	        [XmlElement("operating_userid")]
	        public string OperatingUserid { get; set; }
	
	        /// <summary>
	        /// 审批实例
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
	
	        /// <summary>
	        /// 说明
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
}

        #endregion
    }
}
