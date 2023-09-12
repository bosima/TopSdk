using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.enterprise.mainorg.totaldata.stat
    /// </summary>
    public class OapiEnterpriseMainorgTotaldataStatRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEnterpriseMainorgTotaldataStatResponse>
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
        /// active_mbr_cnt_std 在线组织激活用户数 ； all_group_cnt 全员群数量； carbon_amount_1d 最近1天降低碳排量G； carbon_amount_1w 最近7天降低碳排量G； corp_id 企业ID； dept_group_cnt 部门群数量； ding_save_hour_1d 最近1天钉办节约小时； ding_save_hour_1w 最近7天钉办节约小时； inner_group_cnt 内部群数量； live_launch_succ_cnt_1d 最近1天成功发起直播次数；live_launch_succ_cnt_1w 最近7天成功发起直播次数； mbr_cnt_std 在线组织通讯录人数（注册人数）；online_conference_cnt_1d 最近1天在线会议次数；online_conference_cnt_7d 最近7天在线会议次数； online_org_cnt 在线组织数； org_online_ratio 组织覆盖率； real_org_cnt 实际组织数； receive_ding_user_cnt_1d 最近1天接收DING的用户数；receive_ding_user_cnt_1w 最近7天接收DING的用户数； rel_org_cnt 关联组织数 send_message_user_cnt_1d 最近1天发送消息人数；send_message_user_cnt_1w 最近7天发送消息人数； stat_date 统计日期
        /// </summary>
        public string ReturnFields { get; set; }

        /// <summary>
        /// 查询时间
        /// </summary>
        public string StatDate { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.enterprise.mainorg.totaldata.stat";
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
