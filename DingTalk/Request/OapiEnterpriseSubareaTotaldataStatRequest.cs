using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.enterprise.subarea.totaldata.stat
    /// </summary>
    public class OapiEnterpriseSubareaTotaldataStatRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEnterpriseSubareaTotaldataStatResponse>
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
        /// act_ratio_1d_001 所辖区域活跃率; act_usr_cnt_1d_001 活跃用户数最近1天; active_mbr_cnt_std_001 历史截至当日激活会员数; active_mbr_ratio 所辖区域用户的激活率; city_lat 所属城市维度; city_lng 所属城市经度; county_lat 区/县纬度; county_lng 区/县经度; mbr_cnt_std_063 历史截至当日企业会员数; online_org_cnt 所辖区域在线组织数 ; org_online_ratio 所辖区域组织覆盖率 ; real_org_cnt 所辖区域实际组织数 ; send_message_cnt_1d 发送消息数量; send_message_user_cnt_1d 发送消息人数;
        /// </summary>
        public string ReturnFields { get; set; }

        /// <summary>
        /// 查询时间
        /// </summary>
        public string StatDate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.enterprise.subarea.totaldata.stat";
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
