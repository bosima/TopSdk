using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ats.job.query
    /// </summary>
    public class OapiAtsJobQueryRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAtsJobQueryResponse>
    {
        /// <summary>
        /// 招聘业务标识
        /// </summary>
        public string BizCode { get; set; }

        /// <summary>
        /// 分页游标，传空时默认为第一页
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        public string QueryParam { get; set; }

        public TopQueryJobsParamDomain QueryParam_ { set { this.QueryParam = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 分页大小，最大200
        /// </summary>
        public Nullable<long> Size { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ats.job.query";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_code", this.BizCode);
            parameters.Add("cursor", this.Cursor);
            parameters.Add("query_param", this.QueryParam);
            parameters.Add("size", this.Size);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_code", this.BizCode);
            RequestValidator.ValidateRequired("query_param", this.QueryParam);
            RequestValidator.ValidateRequired("size", this.Size);
            RequestValidator.ValidateMaxValue("size", this.Size, 200);
        }

	/// <summary>
/// TopQueryJobsParamDomain Data Structure.
/// </summary>
[Serializable]

public class TopQueryJobsParamDomain : TopObject
{
	        /// <summary>
	        /// 是否校招
	        /// </summary>
	        [XmlElement("campus")]
	        public Nullable<bool> Campus { get; set; }
	
	        /// <summary>
	        /// 创建人员工标识列表
	        /// </summary>
	        [XmlArray("creator_user_ids")]
	        [XmlArrayItem("string")]
	        public List<string> CreatorUserIds { get; set; }
	
	        /// <summary>
	        /// 更新时间的查询结束时间
	        /// </summary>
	        [XmlElement("end_modified_time")]
	        public Nullable<long> EndModifiedTime { get; set; }
	
	        /// <summary>
	        /// 职位标识列表
	        /// </summary>
	        [XmlArray("job_ids")]
	        [XmlArrayItem("string")]
	        public List<string> JobIds { get; set; }
	
	        /// <summary>
	        /// 职位性质
	        /// </summary>
	        [XmlElement("job_nature")]
	        public string JobNature { get; set; }
	
	        /// <summary>
	        /// 关联会话标识
	        /// </summary>
	        [XmlElement("open_conversation_id")]
	        public string OpenConversationId { get; set; }
	
	        /// <summary>
	        /// 更新时间的查询起始时间
	        /// </summary>
	        [XmlElement("start_modified_time")]
	        public Nullable<long> StartModifiedTime { get; set; }
	
	        /// <summary>
	        /// 职位状态列表，1表示启用中，2表示关闭
	        /// </summary>
	        [XmlArray("status_list")]
	        [XmlArrayItem("number")]
	        public List<string> StatusList { get; set; }
}

        #endregion
    }
}
