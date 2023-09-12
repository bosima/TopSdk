using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.enterprise.microapp.usedata.stat
    /// </summary>
    public class OapiEnterpriseMicroappUsedataStatRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEnterpriseMicroappUsedataStatResponse>
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        public string CorpId { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public string OrderBy { get; set; }

        public OrderByDomain OrderBy_ { set { this.OrderBy = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 分页查询条数，最多30条
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 分页起始点
        /// </summary>
        public Nullable<long> PageStart { get; set; }

        /// <summary>
        /// agent_name 组织微应用名称; open_micro_user_cnt_1d 最近1天打开微应用用户数; open_micro_user_cnt_1w 最近7天打开微应用用户数;
        /// </summary>
        public string ReturnFields { get; set; }

        /// <summary>
        /// 查询时间
        /// </summary>
        public string StatDate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.enterprise.microapp.usedata.stat";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("corp_id", this.CorpId);
            parameters.Add("order_by", this.OrderBy);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("page_start", this.PageStart);
            parameters.Add("return_fields", this.ReturnFields);
            parameters.Add("stat_date", this.StatDate);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("corp_id", this.CorpId);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("page_start", this.PageStart);
            RequestValidator.ValidateRequired("return_fields", this.ReturnFields);
            RequestValidator.ValidateMaxListSize("return_fields", this.ReturnFields, 20);
            RequestValidator.ValidateRequired("stat_date", this.StatDate);
        }

	/// <summary>
/// OrderByDomain Data Structure.
/// </summary>
[Serializable]

public class OrderByDomain : TopObject
{
	        /// <summary>
	        /// 排查的key
	        /// </summary>
	        [XmlElement("field")]
	        public string Field { get; set; }
	
	        /// <summary>
	        /// 升序或者降序
	        /// </summary>
	        [XmlElement("order")]
	        public string Order { get; set; }
}

        #endregion
    }
}
