using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.employee.addpreentry
    /// </summary>
    public class OapiSmartworkHrmEmployeeAddpreentryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmEmployeeAddpreentryResponse>
    {
        /// <summary>
        /// 添加待入职入参
        /// </summary>
        public string Param { get; set; }

        public PreEntryEmployeeAddParamDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.employee.addpreentry";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param", this.Param);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("param", this.Param);
        }

	/// <summary>
/// PreEntryEmployeeAddParamDomain Data Structure.
/// </summary>
[Serializable]

public class PreEntryEmployeeAddParamDomain : TopObject
{
	        /// <summary>
	        /// 扩展信息，json串格式，按要求传入有效信息，无效信息不会保存。有效信息有：depts--部门id列表，"|"分隔多个；mainDeptId--主部门id； mainDeptName--主部门名称； position--职位； workPlace--工作地点；employeeType--员工类型枚举值（0，无类型;1，全职;2，兼职;3，实习;4，劳务派遣;5，退休返聘;6，劳务外包）
	        /// </summary>
	        [XmlElement("extend_info")]
	        public string ExtendInfo { get; set; }
	
	        /// <summary>
	        /// 待入职员工手机号
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 待入职员工姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 操作人userid
	        /// </summary>
	        [XmlElement("op_userid")]
	        public string OpUserid { get; set; }
	
	        /// <summary>
	        /// 预期入职时间
	        /// </summary>
	        [XmlElement("pre_entry_time")]
	        public Nullable<DateTime> PreEntryTime { get; set; }
}

        #endregion
    }
}
