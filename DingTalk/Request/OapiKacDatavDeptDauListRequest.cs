using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.kac.datav.dept.dau.list
    /// </summary>
    public class OapiKacDatavDeptDauListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiKacDatavDeptDauListResponse>
    {
        /// <summary>
        /// 请求参数对象
        /// </summary>
        public string Request { get; set; }

        public DeptDauSummaryRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.kac.datav.dept.dau.list";
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
/// DeptDauSummaryRequestDomain Data Structure.
/// </summary>
[Serializable]

public class DeptDauSummaryRequestDomain : TopObject
{
	        /// <summary>
	        /// 分页游标；首页请使用0，之后直接使用返回结果中的next_cursor
	        /// </summary>
	        [XmlElement("cursor")]
	        public Nullable<long> Cursor { get; set; }
	
	        /// <summary>
	        /// 日期标识
	        /// </summary>
	        [XmlElement("data_id")]
	        public string DataId { get; set; }
	
	        /// <summary>
	        /// 请求的部门id
	        /// </summary>
	        [XmlElement("deptId")]
	        public string DeptId { get; set; }
	
	        /// <summary>
	        /// 分页大小;不超过100
	        /// </summary>
	        [XmlElement("size")]
	        public Nullable<long> Size { get; set; }
	
	        /// <summary>
	        /// 请求部门的父部门id
	        /// </summary>
	        [XmlElement("superDeptId")]
	        public string SuperDeptId { get; set; }
}

        #endregion
    }
}
