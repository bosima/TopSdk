using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.inspect.task.list
    /// </summary>
    public class OapiInspectTaskListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiInspectTaskListResponse>
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        public string Param { get; set; }

        public TopInspectTaskDeptQueryPramDomain Param_ { set { this.Param = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.inspect.task.list";
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
/// TopInspectTaskDeptQueryPramDomain Data Structure.
/// </summary>
[Serializable]

public class TopInspectTaskDeptQueryPramDomain : TopObject
{
	        /// <summary>
	        /// 游标，从返回结果中获取，第一次请求可为空
	        /// </summary>
	        [XmlElement("cursor")]
	        public Nullable<long> Cursor { get; set; }
	
	        /// <summary>
	        /// 部门id，从通讯录接口获取
	        /// </summary>
	        [XmlElement("dept_id")]
	        public string DeptId { get; set; }
	
	        /// <summary>
	        /// 请求开始时间，时间戳，单位毫秒
	        /// </summary>
	        [XmlElement("end_date")]
	        public Nullable<long> EndDate { get; set; }
	
	        /// <summary>
	        /// 分页请求数量，最大值50
	        /// </summary>
	        [XmlElement("size")]
	        public Nullable<long> Size { get; set; }
	
	        /// <summary>
	        /// 请求结束时间，时间戳，单位毫秒
	        /// </summary>
	        [XmlElement("start_date")]
	        public Nullable<long> StartDate { get; set; }
	
	        /// <summary>
	        /// 请求的状态列表，1已签到，2已正常签退，3已异常签退
	        /// </summary>
	        [XmlArray("status")]
	        [XmlArrayItem("number")]
	        public List<string> Status { get; set; }
}

        #endregion
    }
}
