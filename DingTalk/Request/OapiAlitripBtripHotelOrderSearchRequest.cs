using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.hotel.order.search
    /// </summary>
    public class OapiAlitripBtripHotelOrderSearchRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripHotelOrderSearchResponse>
    {
        /// <summary>
        /// rq
        /// </summary>
        public string Rq { get; set; }

        public OpenSearchRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.hotel.order.search";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("rq", this.Rq);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("rq", this.Rq);
        }

	/// <summary>
/// OpenSearchRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenSearchRqDomain : TopObject
{
	        /// <summary>
	        /// false:搜索未报销订单
	        /// </summary>
	        [XmlElement("all_apply")]
	        public Nullable<bool> AllApply { get; set; }
	
	        /// <summary>
	        /// 商旅审批单id
	        /// </summary>
	        [XmlElement("apply_id")]
	        public Nullable<long> ApplyId { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("deptid")]
	        public string Deptid { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<DateTime> EndTime { get; set; }
	
	        /// <summary>
	        /// 页数，从1开始
	        /// </summary>
	        [XmlElement("page")]
	        public Nullable<long> Page { get; set; }
	
	        /// <summary>
	        /// 每页数量，默认10，最大50
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public Nullable<DateTime> StartTime { get; set; }
	
	        /// <summary>
	        /// 第三方申请单ID
	        /// </summary>
	        [XmlElement("thirdpart_apply_id")]
	        public string ThirdpartApplyId { get; set; }
	
	        /// <summary>
	        /// 更新开始时间
	        /// </summary>
	        [XmlElement("update_end_time")]
	        public Nullable<DateTime> UpdateEndTime { get; set; }
	
	        /// <summary>
	        /// 更新结束时间
	        /// </summary>
	        [XmlElement("update_start_time")]
	        public Nullable<DateTime> UpdateStartTime { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
