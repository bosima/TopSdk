using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.organization.dept.update
    /// </summary>
    public class OapiSmartworkHrmOrganizationDeptUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmOrganizationDeptUpdateResponse>
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string AttributeVOS { get; set; }

        public List<OrgDeptAttributeVoDomain> AttributeVOS_ { set { this.AttributeVOS = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 部门ID
        /// </summary>
        public Nullable<long> DeptId { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.organization.dept.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attributeVOS", this.AttributeVOS);
            parameters.Add("dept_id", this.DeptId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("attributeVOS", this.AttributeVOS, 999);
            RequestValidator.ValidateRequired("dept_id", this.DeptId);
        }

	/// <summary>
/// OrgDeptAttributeVoDomain Data Structure.
/// </summary>
[Serializable]

public class OrgDeptAttributeVoDomain : TopObject
{
	        /// <summary>
	        /// 字段code
	        /// </summary>
	        [XmlElement("field_code")]
	        public string FieldCode { get; set; }
	
	        /// <summary>
	        /// 字段值
	        /// </summary>
	        [XmlElement("field_value")]
	        public string FieldValue { get; set; }
}

        #endregion
    }
}
