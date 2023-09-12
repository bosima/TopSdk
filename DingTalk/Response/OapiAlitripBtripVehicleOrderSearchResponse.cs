using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripVehicleOrderSearchResponse.
    /// </summary>
    public class OapiAlitripBtripVehicleOrderSearchResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [XmlElement("page_info")]
        public PageInfoRsDomain PageInfo { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlArray("vehicle_order_list")]
        [XmlArrayItem("open_vehicle_order_rs")]
        public List<OpenVehicleOrderRsDomain> VehicleOrderList { get; set; }

	/// <summary>
/// OpenPriceInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPriceInfoDomain : TopObject
{
	        /// <summary>
	        /// 交易类型：用车支付, 服务费, 用车取消后收费, 用车退款, 用车赔付
	        /// </summary>
	        [XmlElement("category")]
	        public string Category { get; set; }
	
	        /// <summary>
	        /// 交易类目编码
	        /// </summary>
	        [XmlElement("category_code")]
	        public long CategoryCode { get; set; }
	
	        /// <summary>
	        /// 交易类目类型1-飞机，2-酒店，3-火车，4-用车
	        /// </summary>
	        [XmlElement("category_type")]
	        public long CategoryType { get; set; }
	
	        /// <summary>
	        /// 流水创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 出行人，多个用‘,’分割
	        /// </summary>
	        [XmlElement("passenger_name")]
	        public string PassengerName { get; set; }
	
	        /// <summary>
	        /// 结算方式:1：个人现付，2:企业现付,4:企业月结，8、企业预存
	        /// </summary>
	        [XmlElement("pay_type")]
	        public long PayType { get; set; }
	
	        /// <summary>
	        /// 价格
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// 交易流水ID
	        /// </summary>
	        [XmlElement("tradeId")]
	        public string TradeId { get; set; }
	
	        /// <summary>
	        /// 资金流向:1:支出，2:收入
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
}

	/// <summary>
/// OpenUserAffiliateDoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenUserAffiliateDoDomain : TopObject
{
	        /// <summary>
	        /// 出行人名称
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 出行人ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenVehicleOrderRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenVehicleOrderRsDomain : TopObject
{
	        /// <summary>
	        /// 商旅系统审批单id
	        /// </summary>
	        [XmlElement("apply_id")]
	        public long ApplyId { get; set; }
	
	        /// <summary>
	        /// 商旅审批单展示id(非审批api对接企业)
	        /// </summary>
	        [XmlElement("apply_show_id")]
	        public string ApplyShowId { get; set; }
	
	        /// <summary>
	        /// 申请单名称
	        /// </summary>
	        [XmlElement("btrip_title")]
	        public string BtripTitle { get; set; }
	
	        /// <summary>
	        /// 用车原因：TRAVEL: 差旅, TRAFFIC: 市内交通, WORK: 加班, OTHER: 其它
	        /// </summary>
	        [XmlElement("business_category")]
	        public string BusinessCategory { get; set; }
	
	        /// <summary>
	        /// 取消时间
	        /// </summary>
	        [XmlElement("cancel_time")]
	        public string CancelTime { get; set; }
	
	        /// <summary>
	        /// 车辆类型
	        /// </summary>
	        [XmlElement("car_info")]
	        public string CarInfo { get; set; }
	
	        /// <summary>
	        /// 类型级别：1经济型、2舒适型、3豪华型
	        /// </summary>
	        [XmlElement("car_level")]
	        public string CarLevel { get; set; }
	
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
	        /// 商旅成本中心id
	        /// </summary>
	        [XmlElement("cost_center_id")]
	        public long CostCenterId { get; set; }
	
	        /// <summary>
	        /// 成本中心名称
	        /// </summary>
	        [XmlElement("cost_center_name")]
	        public string CostCenterName { get; set; }
	
	        /// <summary>
	        /// 成本中心编号
	        /// </summary>
	        [XmlElement("cost_center_number")]
	        public string CostCenterNumber { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("deptid")]
	        public string Deptid { get; set; }
	
	        /// <summary>
	        /// 司机到达目的地时间
	        /// </summary>
	        [XmlElement("driver_confirm_time")]
	        public string DriverConfirmTime { get; set; }
	
	        /// <summary>
	        /// 订单预估价格
	        /// </summary>
	        [XmlElement("estimate_price")]
	        public string EstimatePrice { get; set; }
	
	        /// <summary>
	        /// 出发地
	        /// </summary>
	        [XmlElement("from_address")]
	        public string FromAddress { get; set; }
	
	        /// <summary>
	        /// 出发城市
	        /// </summary>
	        [XmlElement("from_city_name")]
	        public string FromCityName { get; set; }
	
	        /// <summary>
	        /// 订单创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 订单更新时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 商旅发票id
	        /// </summary>
	        [XmlElement("invoice_id")]
	        public long InvoiceId { get; set; }
	
	        /// <summary>
	        /// 发票抬头
	        /// </summary>
	        [XmlElement("invoice_title")]
	        public string InvoiceTitle { get; set; }
	
	        /// <summary>
	        /// 是否特殊订单
	        /// </summary>
	        [XmlElement("is_special")]
	        public bool IsSpecial { get; set; }
	
	        /// <summary>
	        /// 打车事由
	        /// </summary>
	        [XmlElement("memo")]
	        public string Memo { get; set; }
	
	        /// <summary>
	        /// 订单状态:0：待派单（初始化）  1：订单已结束 (终态，第三方关单)  2：派单成功（行程有效状态）  3：订单已结束 (终态，派单失败)  4：已退款（终态，退款成功）  5：已支付（行程有效状态，除非有客诉，会流转到已退款）  6：取消成功（终态，用户取消）  8：订单已结束（终态，无人接单）
	        /// </summary>
	        [XmlElement("order_status")]
	        public long OrderStatus { get; set; }
	
	        /// <summary>
	        /// 乘客名称
	        /// </summary>
	        [XmlElement("passenger_name")]
	        public string PassengerName { get; set; }
	
	        /// <summary>
	        /// 支付时间
	        /// </summary>
	        [XmlElement("pay_time")]
	        public string PayTime { get; set; }
	
	        /// <summary>
	        /// 价目详情列表
	        /// </summary>
	        [XmlArray("price_info_list")]
	        [XmlArrayItem("open_price_info")]
	        public List<OpenPriceInfoDomain> PriceInfoList { get; set; }
	
	        /// <summary>
	        /// 项目编号
	        /// </summary>
	        [XmlElement("project_code")]
	        public string ProjectCode { get; set; }
	
	        /// <summary>
	        /// 项目id
	        /// </summary>
	        [XmlElement("project_id")]
	        public long ProjectId { get; set; }
	
	        /// <summary>
	        /// 项目名称
	        /// </summary>
	        [XmlElement("project_title")]
	        public string ProjectTitle { get; set; }
	
	        /// <summary>
	        /// 服务商：2滴滴；3:曹操；4:首汽；5:阳光。可能会有其他服务商的增加。
	        /// </summary>
	        [XmlElement("provider")]
	        public long Provider { get; set; }
	
	        /// <summary>
	        /// 乘客发布用车时间
	        /// </summary>
	        [XmlElement("publish_time")]
	        public string PublishTime { get; set; }
	
	        /// <summary>
	        /// 真实出发地
	        /// </summary>
	        [XmlElement("real_from_address")]
	        public string RealFromAddress { get; set; }
	
	        /// <summary>
	        /// 实际出发城市
	        /// </summary>
	        [XmlElement("real_from_city_name")]
	        public string RealFromCityName { get; set; }
	
	        /// <summary>
	        /// 真实到达地
	        /// </summary>
	        [XmlElement("real_to_address")]
	        public string RealToAddress { get; set; }
	
	        /// <summary>
	        /// 实际到达城市
	        /// </summary>
	        [XmlElement("real_to_city_name")]
	        public string RealToCityName { get; set; }
	
	        /// <summary>
	        /// 打车服务类型 1:出租车, 2:专车, 3:快车
	        /// </summary>
	        [XmlElement("service_type")]
	        public long ServiceType { get; set; }
	
	        /// <summary>
	        /// 特殊订单类型；v_sp_t_1:用车里程，v_sp_t_2:实际下车点，v_sp_t_3:用车金额，v_sp_t_4:用车次数，v_sp_t_5:跨城订单
	        /// </summary>
	        [XmlArray("special_types")]
	        [XmlArrayItem("string")]
	        public List<string> SpecialTypes { get; set; }
	
	        /// <summary>
	        /// 乘客上车时间
	        /// </summary>
	        [XmlElement("taken_time")]
	        public string TakenTime { get; set; }
	
	        /// <summary>
	        /// 第三方项目id
	        /// </summary>
	        [XmlElement("third_part_project_id")]
	        public string ThirdPartProjectId { get; set; }
	
	        /// <summary>
	        /// 第三方申请单ID
	        /// </summary>
	        [XmlElement("thirdpart_apply_id")]
	        public string ThirdpartApplyId { get; set; }
	
	        /// <summary>
	        /// 第三方行程id
	        /// </summary>
	        [XmlElement("thirdpart_itinerary_id")]
	        public string ThirdpartItineraryId { get; set; }
	
	        /// <summary>
	        /// 目的地
	        /// </summary>
	        [XmlElement("to_address")]
	        public string ToAddress { get; set; }
	
	        /// <summary>
	        /// 目的城市
	        /// </summary>
	        [XmlElement("to_city_name")]
	        public string ToCityName { get; set; }
	
	        /// <summary>
	        /// 行驶公里数
	        /// </summary>
	        [XmlElement("travel_distance")]
	        public string TravelDistance { get; set; }
	
	        /// <summary>
	        /// 出行人列表
	        /// </summary>
	        [XmlArray("user_affiliate_list")]
	        [XmlArrayItem("open_user_affiliate_do")]
	        public List<OpenUserAffiliateDoDomain> UserAffiliateList { get; set; }
	
	        /// <summary>
	        /// 用户确认状态：0未确认；1已确认；2有异议；3系统检查不合理
	        /// </summary>
	        [XmlElement("user_confirm")]
	        public long UserConfirm { get; set; }
	
	        /// <summary>
	        /// 预定人名称
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 预定人id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// PageInfoRsDomain Data Structure.
/// </summary>
[Serializable]

public class PageInfoRsDomain : TopObject
{
	        /// <summary>
	        /// 当前页
	        /// </summary>
	        [XmlElement("page")]
	        public long Page { get; set; }
	
	        /// <summary>
	        /// 每页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 总记录数
	        /// </summary>
	        [XmlElement("total_number")]
	        public long TotalNumber { get; set; }
}

    }
}
