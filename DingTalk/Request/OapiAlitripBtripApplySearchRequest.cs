using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.apply.search
    /// </summary>
    public class OapiAlitripBtripApplySearchRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripApplySearchResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Rq { get; set; }

        public OpenSearchRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.apply.search";
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
	        /// false:未报销的申请单
	        /// </summary>
	        [XmlElement("all_apply")]
	        public Nullable<bool> AllApply { get; set; }
	
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
	        /// 更新时间大于等于此时间的审批单
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public Nullable<DateTime> GmtModified { get; set; }
	
	        /// <summary>
	        /// true:商旅申请单
	        /// </summary>
	        [XmlElement("only_shang_lv_apply")]
	        public Nullable<bool> OnlyShangLvApply { get; set; }
	
	        /// <summary>
	        /// 页数，从1开始
	        /// </summary>
	        [XmlElement("page")]
	        public Nullable<long> Page { get; set; }
	
	        /// <summary>
	        /// 每页返回数量，默认10，最多50
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public Nullable<DateTime> StartTime { get; set; }
	
	        /// <summary>
	        /// 申请单提交类型 1：代提交 2：本人提交 注意：当申请单为代提交时，申请单提交人自己无法为自己下单
	        /// </summary>
	        [XmlElement("type")]
	        public Nullable<long> Type { get; set; }
	
	        /// <summary>
	        /// 第三方关联单号
	        /// </summary>
	        [XmlElement("unionNo")]
	        public string UnionNo { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
