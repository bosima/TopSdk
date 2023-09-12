using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.invoice.setting.rule
    /// </summary>
    public class OapiAlitripBtripInvoiceSettingRuleRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripInvoiceSettingRuleResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Request { get; set; }

        public OpenInvoiceRuleRqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.invoice.setting.rule";
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
/// EntityDomain Data Structure.
/// </summary>
[Serializable]

public class EntityDomain : TopObject
{
	        /// <summary>
	        /// 实体id，表示员工id/部门id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 实体名，表示员工名称/部门名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 1：员工，2：商旅内部部门，3：三方部门
	        /// </summary>
	        [XmlElement("type")]
	        public Nullable<long> Type { get; set; }
}

	/// <summary>
/// OpenInvoiceRuleRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenInvoiceRuleRqDomain : TopObject
{
	        /// <summary>
	        /// 是否适用所有员工
	        /// </summary>
	        [XmlElement("all_employe")]
	        public Nullable<bool> AllEmploye { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 人员列表
	        /// </summary>
	        [XmlArray("entities")]
	        [XmlArrayItem("entity")]
	        public List<EntityDomain> Entities { get; set; }
	
	        /// <summary>
	        /// 第三方发票id
	        /// </summary>
	        [XmlElement("third_part_id")]
	        public string ThirdPartId { get; set; }
}

        #endregion
    }
}
