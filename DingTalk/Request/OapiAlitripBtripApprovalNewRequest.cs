using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.approval.new
    /// </summary>
    public class OapiAlitripBtripApprovalNewRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripApprovalNewResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Rq { get; set; }

        public OpenApiNewApplyRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.approval.new";
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
/// OpenItineraryInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenItineraryInfoDomain : TopObject
{
	        /// <summary>
	        /// 到达城市
	        /// </summary>
	        [XmlElement("arr_city")]
	        public string ArrCity { get; set; }
	
	        /// <summary>
	        /// 到达城市编码
	        /// </summary>
	        [XmlElement("arr_city_code")]
	        public string ArrCityCode { get; set; }
	
	        /// <summary>
	        /// 到达日期
	        /// </summary>
	        [XmlElement("arr_date")]
	        public Nullable<DateTime> ArrDate { get; set; }
	
	        /// <summary>
	        /// 商旅成本中心id，若不填则第三方成本中心id必填
	        /// </summary>
	        [XmlElement("cost_center_id")]
	        public Nullable<long> CostCenterId { get; set; }
	
	        /// <summary>
	        /// 出发城市
	        /// </summary>
	        [XmlElement("dep_city")]
	        public string DepCity { get; set; }
	
	        /// <summary>
	        /// 出发城市编码
	        /// </summary>
	        [XmlElement("dep_city_code")]
	        public string DepCityCode { get; set; }
	
	        /// <summary>
	        /// 出发日期
	        /// </summary>
	        [XmlElement("dep_date")]
	        public Nullable<DateTime> DepDate { get; set; }
	
	        /// <summary>
	        /// 商旅发票id，和第三方发票id选填一个即可
	        /// </summary>
	        [XmlElement("invoice_id")]
	        public Nullable<long> InvoiceId { get; set; }
	
	        /// <summary>
	        /// 行程id
	        /// </summary>
	        [XmlElement("itinerary_id")]
	        public string ItineraryId { get; set; }
	
	        /// <summary>
	        /// 行程是否需要预定酒店，不传默认需要
	        /// </summary>
	        [XmlElement("need_hotel")]
	        public Nullable<bool> NeedHotel { get; set; }
	
	        /// <summary>
	        /// 行程是否需要预定交通工具，不传默认需要
	        /// </summary>
	        [XmlElement("need_traffic")]
	        public Nullable<bool> NeedTraffic { get; set; }
	
	        /// <summary>
	        /// 项目编号
	        /// </summary>
	        [XmlElement("project_code")]
	        public string ProjectCode { get; set; }
	
	        /// <summary>
	        /// 项目名称
	        /// </summary>
	        [XmlElement("project_title")]
	        public string ProjectTitle { get; set; }
	
	        /// <summary>
	        /// 第三方发票id，和商旅发票id选填一个即可
	        /// </summary>
	        [XmlElement("third_part_invoice_id")]
	        public string ThirdPartInvoiceId { get; set; }
	
	        /// <summary>
	        /// 第三方成本中心id，若不填则商旅成本中心id必填
	        /// </summary>
	        [XmlElement("thirdpart_cost_center_id")]
	        public string ThirdpartCostCenterId { get; set; }
	
	        /// <summary>
	        /// 交通方式： 0 飞机、酒店,  1 火车、酒店,  2 汽车、酒店,  3 酒店，5 不限，6 飞机，7 火车，9 飞机、火车、酒店，10 飞机、火车，11 用车
	        /// </summary>
	        [XmlElement("traffic_type")]
	        public Nullable<long> TrafficType { get; set; }
	
	        /// <summary>
	        /// 行程类型：0单程，1往返
	        /// </summary>
	        [XmlElement("trip_way")]
	        public Nullable<long> TripWay { get; set; }
}

	/// <summary>
/// OpenUserInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenUserInfoDomain : TopObject
{
	        /// <summary>
	        /// 出行人名称
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 出行人id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenApiNewApplyRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiNewApplyRqDomain : TopObject
{
	        /// <summary>
	        /// 企业名称
	        /// </summary>
	        [XmlElement("corp_name")]
	        public string CorpName { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 部门id，如果不传，会根据user相关信息去获取对应的部门信息，如果传的是错误的部门信息，后面无法做部门的费用归属；部门ID只能是数字
	        /// </summary>
	        [XmlElement("deptid")]
	        public string Deptid { get; set; }
	
	        /// <summary>
	        /// 外部出行人列表
	        /// </summary>
	        [XmlArray("external_traveler_list")]
	        [XmlArrayItem("open_user_info")]
	        public List<OpenUserInfoDomain> ExternalTravelerList { get; set; }
	
	        /// <summary>
	        /// 审批单酒店预算，单位分
	        /// </summary>
	        [XmlElement("hotel_budget")]
	        public Nullable<long> HotelBudget { get; set; }
	
	        /// <summary>
	        /// 行程列表
	        /// </summary>
	        [XmlArray("itinerary_list")]
	        [XmlArrayItem("open_itinerary_info")]
	        public List<OpenItineraryInfoDomain> ItineraryList { get; set; }
	
	        /// <summary>
	        /// 审批单状态，不传入默认为0：0审批中，1同意，2拒绝
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
	
	        /// <summary>
	        /// 外部申请单id
	        /// </summary>
	        [XmlElement("thirdpart_apply_id")]
	        public string ThirdpartApplyId { get; set; }
	
	        /// <summary>
	        /// 用户展示的外部审批单id信息
	        /// </summary>
	        [XmlElement("thirdpart_business_id")]
	        public string ThirdpartBusinessId { get; set; }
	
	        /// <summary>
	        /// 出行人列表
	        /// </summary>
	        [XmlArray("traveler_list")]
	        [XmlArrayItem("open_user_info")]
	        public List<OpenUserInfoDomain> TravelerList { get; set; }
	
	        /// <summary>
	        /// 出差事由
	        /// </summary>
	        [XmlElement("trip_cause")]
	        public string TripCause { get; set; }
	
	        /// <summary>
	        /// 出差天数
	        /// </summary>
	        [XmlElement("trip_day")]
	        public Nullable<long> TripDay { get; set; }
	
	        /// <summary>
	        /// 申请单标题
	        /// </summary>
	        [XmlElement("trip_title")]
	        public string TripTitle { get; set; }
	
	        /// <summary>
	        /// 1：代提交 2：本人提交 注意：当申请单为代提交时，申请单提交人自己无法为自己下单
	        /// </summary>
	        [XmlElement("type")]
	        public Nullable<long> Type { get; set; }
	
	        /// <summary>
	        /// 关联单号
	        /// </summary>
	        [XmlElement("union_no")]
	        public string UnionNo { get; set; }
	
	        /// <summary>
	        /// 用户名称，如果要传必须传真实姓名，如果不传则会以系统当前维护userId对应的名称进行预订
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
