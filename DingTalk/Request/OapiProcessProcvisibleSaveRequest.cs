using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.procvisible.save
    /// </summary>
    public class OapiProcessProcvisibleSaveRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessProcvisibleSaveResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public UpdateProcessVisibleRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.procvisible.save";
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
/// VisiblelistDomain Data Structure.
/// </summary>
[Serializable]

public class VisiblelistDomain : TopObject
{
	        /// <summary>
	        /// 可见性类型，部门可见（0），员工可见（1）
	        /// </summary>
	        [XmlElement("visible_type")]
	        public Nullable<long> VisibleType { get; set; }
	
	        /// <summary>
	        /// 可见值
	        /// </summary>
	        [XmlElement("visible_value")]
	        public string VisibleValue { get; set; }
}

	/// <summary>
/// UpdateProcessVisibleRequestDomain Data Structure.
/// </summary>
[Serializable]

public class UpdateProcessVisibleRequestDomain : TopObject
{
	        /// <summary>
	        /// 企业应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 流程模板processCode
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
	
	        /// <summary>
	        /// 操作人userId
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 可见权限配置列表
	        /// </summary>
	        [XmlArray("visible_list")]
	        [XmlArrayItem("visiblelist")]
	        public List<VisiblelistDomain> VisibleList { get; set; }
}

        #endregion
    }
}
