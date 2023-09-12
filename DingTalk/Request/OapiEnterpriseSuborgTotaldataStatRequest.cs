using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.enterprise.suborg.totaldata.stat
    /// </summary>
    public class OapiEnterpriseSuborgTotaldataStatRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEnterpriseSuborgTotaldataStatResponse>
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
        /// act_ratio_1d_001 最近1天活跃率； act_ratio_1w_001 最近7天活跃率； act_usr_cnt_1d_001 活跃用户数最近1天； act_usr_cnt_1w_001 最近7天活跃用户数； active_mbr_cnt_std_001 历史截至当日激活会员数； active_ratio 激活率； ding_index_1d 最近1天钉钉指数； ding_index_1w 最近7天钉钉指数； mbr_cnt_std_063 历史截至当日企业会员数 ； micro_app_use_ratio_1d 最近1天使用钉钉微应用用户比率；micro_app_use_ratio_1w 最近7天使用钉钉微应用用户比率；micro_app_user_cnt_1d 最近1天使用钉钉微应用用户数；micro_app_user_cnt_1w 最近7天使用钉钉微应用用户数；pm_form_cnt_001 审批模板数； pm_form_cnt_002 自定义模板数； pm_form_self_def_ratio 自定义模板比率； process_user_cnt_1d 最近1天使用审批用户数； process_user_cnt_1w 最近7天使用审批用户数；process_user_ratio_1d 最近1天使用审批的用户比率；process_user_ratio_1w 最近7天使用审批的用户比率；send_message_user_cnt_1d 最近1天沟通用户数；send_message_user_cnt_1w 最近7天沟通用户数；send_message_user_ratio_1d 最近1天沟通率； send_message_user_ratio_1w 最近7天沟通率； sub_org_area_lat 所辖组织的地理纬度 ； sub_org_area_lng 所辖组织的地理经度 ； sub_org_name 所辖组织名称；
        /// </summary>
        public string ReturnFields { get; set; }

        /// <summary>
        /// 查询时间
        /// </summary>
        public string StatDate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.enterprise.suborg.totaldata.stat";
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
            RequestValidator.ValidateMaxListSize("return_fields", this.ReturnFields, 50);
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
