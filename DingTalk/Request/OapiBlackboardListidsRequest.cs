using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.blackboard.listids
    /// </summary>
    public class OapiBlackboardListidsRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiBlackboardListidsResponse>
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        public string QueryRequest { get; set; }

        public OapiBlackboardQueryVoDomain QueryRequest_ { set { this.QueryRequest = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.blackboard.listids";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query_request", this.QueryRequest);
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
/// OapiBlackboardQueryVoDomain Data Structure.
/// </summary>
[Serializable]

public class OapiBlackboardQueryVoDomain : TopObject
{
	        /// <summary>
	        /// 分类id，可以通过https://oapi.dingtalk.com/blackboard/category/get获取有效值
	        /// </summary>
	        [XmlElement("category_id")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// 结束时间(开区间）
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<DateTime> EndTime { get; set; }
	
	        /// <summary>
	        /// 操作人userId(必须是公告管理员)
	        /// </summary>
	        [XmlElement("operation_userid")]
	        public string OperationUserid { get; set; }
	
	        /// <summary>
	        /// 页码，从1开始且必须为正整数
	        /// </summary>
	        [XmlElement("page")]
	        public Nullable<long> Page { get; set; }
	
	        /// <summary>
	        /// 分页大小，必须为正整数，且不超过30
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 开始时间(闭区间）
	        /// </summary>
	        [XmlElement("start_time")]
	        public Nullable<DateTime> StartTime { get; set; }
}

        #endregion
    }
}
