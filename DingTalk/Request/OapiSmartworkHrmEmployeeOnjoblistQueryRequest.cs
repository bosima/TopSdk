using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.employee.onjoblist.query
    /// </summary>
    public class OapiSmartworkHrmEmployeeOnjoblistQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmEmployeeOnjoblistQueryResponse>
    {
        /// <summary>
        /// 分页起始值，默认0开始
        /// </summary>
        public Nullable<long> Cursor { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        public string SearchParam { get; set; }

        public EmpSearchParamVoDomain SearchParam_ { set { this.SearchParam = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 分页大小，最大50
        /// </summary>
        public Nullable<long> Size { get; set; }

        /// <summary>
        /// 在职员工子状态筛选。2，试用期；3，正式；5，待离职；-1，无状态
        /// </summary>
        public string StatusList { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.employee.onjoblist.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cursor", this.Cursor);
            parameters.Add("search_param", this.SearchParam);
            parameters.Add("size", this.Size);
            parameters.Add("status_list", this.StatusList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cursor", this.Cursor);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateRequired("status_list", this.StatusList);
            RequestValidator.ValidateMaxListSize("status_list", this.StatusList, 999);
        }

	/// <summary>
/// EmpSearchParamVoDomain Data Structure.
/// </summary>
[Serializable]

public class EmpSearchParamVoDomain : TopObject
{
	        /// <summary>
	        /// 结束入职日期
	        /// </summary>
	        [XmlElement("entry_end_date")]
	        public Nullable<DateTime> EntryEndDate { get; set; }
	
	        /// <summary>
	        /// 开始入职日期
	        /// </summary>
	        [XmlElement("entry_start_date")]
	        public Nullable<DateTime> EntryStartDate { get; set; }
}

        #endregion
    }
}
