using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.property.update
    /// </summary>
    public class OapiProcessPropertyUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessPropertyUpdateResponse>
    {
        /// <summary>
        /// 控件id
        /// </summary>
        public string ComponentId { get; set; }

        /// <summary>
        /// 模板code
        /// </summary>
        public string ProcessCode { get; set; }

        /// <summary>
        /// 控件属性集
        /// </summary>
        public string Props { get; set; }

        public ProcessTemplatePropsVoDomain Props_ { set { this.Props = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 员工工号 企业唯一
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.property.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("component_id", this.ComponentId);
            parameters.Add("process_code", this.ProcessCode);
            parameters.Add("props", this.Props);
            parameters.Add("userid", this.Userid);
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
/// ProcessTemplatePropsVoDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessTemplatePropsVoDomain : TopObject
{
	        /// <summary>
	        /// 单个控件属性
	        /// </summary>
	        [XmlElement("pay_enable")]
	        public Nullable<bool> PayEnable { get; set; }
}

        #endregion
    }
}
