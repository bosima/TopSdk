using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripTrainOrderSearchResponse.
    /// </summary>
    public class OapiAlitripBtripTrainOrderSearchResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 分页相关信息
        /// </summary>
        [XmlElement("page_info")]
        public PageInfoRsDomain PageInfo { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// module
        /// </summary>
        [XmlArray("train_order_list")]
        [XmlArrayItem("open_train_order_rs")]
        public List<OpenTrainOrderRsDomain> TrainOrderList { get; set; }

	/// <summary>
/// OpenInvoiceDoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenInvoiceDoDomain : TopObject
{
	        /// <summary>
	        /// 商旅发票id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 发票抬头
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// OpenCostCenterDoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCostCenterDoDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 商旅成本中心id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 成本中心名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 成本中心编号
	        /// </summary>
	        [XmlElement("number")]
	        public string Number { get; set; }
}

	/// <summary>
/// OpenPriceInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPriceInfoDomain : TopObject
{
	        /// <summary>
	        /// 消费类型
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
	        /// 改签目的地
	        /// </summary>
	        [XmlElement("endCity")]
	        public string EndCity { get; set; }
	
	        /// <summary>
	        /// 改签开始时间
	        /// </summary>
	        [XmlElement("endTime")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 流水创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 改签前车次号
	        /// </summary>
	        [XmlElement("originalTrainNo")]
	        public string OriginalTrainNo { get; set; }
	
	        /// <summary>
	        /// 乘车人名称，多个用‘,’分割
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
	        /// 改签坐席
	        /// </summary>
	        [XmlElement("seatType")]
	        public string SeatType { get; set; }
	
	        /// <summary>
	        /// 改签始发地
	        /// </summary>
	        [XmlElement("startCity")]
	        public string StartCity { get; set; }
	
	        /// <summary>
	        /// 改签结束时间
	        /// </summary>
	        [XmlElement("startTime")]
	        public string StartTime { get; set; }
	
	        /// <summary>
	        /// 流水单号
	        /// </summary>
	        [XmlElement("tradeId")]
	        public string TradeId { get; set; }
	
	        /// <summary>
	        /// 改签车次号
	        /// </summary>
	        [XmlElement("trainNo")]
	        public string TrainNo { get; set; }
	
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
	        /// 乘车人名称
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 乘车人ID
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenTrainOrderRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenTrainOrderRsDomain : TopObject
{
	        /// <summary>
	        /// 商旅审批单id
	        /// </summary>
	        [XmlElement("apply_id")]
	        public long ApplyId { get; set; }
	
	        /// <summary>
	        /// 到达城市
	        /// </summary>
	        [XmlElement("arr_city")]
	        public string ArrCity { get; set; }
	
	        /// <summary>
	        /// 到达站
	        /// </summary>
	        [XmlElement("arr_station")]
	        public string ArrStation { get; set; }
	
	        /// <summary>
	        /// 到达时间
	        /// </summary>
	        [XmlElement("arr_time")]
	        public string ArrTime { get; set; }
	
	        /// <summary>
	        /// 申请单名称
	        /// </summary>
	        [XmlElement("btrip_title")]
	        public string BtripTitle { get; set; }
	
	        /// <summary>
	        /// 联系人名称
	        /// </summary>
	        [XmlElement("contact_name")]
	        public string ContactName { get; set; }
	
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
	        /// 成本中心对象
	        /// </summary>
	        [XmlElement("cost_center")]
	        public OpenCostCenterDoDomain CostCenter { get; set; }
	
	        /// <summary>
	        /// 出发城市
	        /// </summary>
	        [XmlElement("dep_city")]
	        public string DepCity { get; set; }
	
	        /// <summary>
	        /// 出发站
	        /// </summary>
	        [XmlElement("dep_station")]
	        public string DepStation { get; set; }
	
	        /// <summary>
	        /// 出发时间
	        /// </summary>
	        [XmlElement("dep_time")]
	        public string DepTime { get; set; }
	
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
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 更新时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 发票对象
	        /// </summary>
	        [XmlElement("invoice")]
	        public OpenInvoiceDoDomain Invoice { get; set; }
	
	        /// <summary>
	        /// 价目信息
	        /// </summary>
	        [XmlArray("price_info_list")]
	        [XmlArrayItem("open_price_info")]
	        public List<OpenPriceInfoDomain> PriceInfoList { get; set; }
	
	        /// <summary>
	        /// 项目code
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
	        /// 乘客姓名
	        /// </summary>
	        [XmlElement("rider_name")]
	        public string RiderName { get; set; }
	
	        /// <summary>
	        /// 运行时长
	        /// </summary>
	        [XmlElement("run_time")]
	        public string RunTime { get; set; }
	
	        /// <summary>
	        /// 座位类型
	        /// </summary>
	        [XmlElement("seat_type")]
	        public string SeatType { get; set; }
	
	        /// <summary>
	        /// 订单状态：0待支付,1出票中,2已关闭,3,改签成功,4退票成功,5出票完成,6退票申请中,7改签申请中,8已出票,已发货,9出票失败,10改签失败,11退票失败
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 第三方项目Id
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
	        /// 票的数量
	        /// </summary>
	        [XmlElement("ticket_count")]
	        public long TicketCount { get; set; }
	
	        /// <summary>
	        /// 12306票号
	        /// </summary>
	        [XmlElement("ticket_no_12306")]
	        public string TicketNo12306 { get; set; }
	
	        /// <summary>
	        /// 车次
	        /// </summary>
	        [XmlElement("train_number")]
	        public string TrainNumber { get; set; }
	
	        /// <summary>
	        /// 车次类型
	        /// </summary>
	        [XmlElement("train_type")]
	        public string TrainType { get; set; }
	
	        /// <summary>
	        /// 乘车人列表
	        /// </summary>
	        [XmlArray("user_affiliate_list")]
	        [XmlArrayItem("open_user_affiliate_do")]
	        public List<OpenUserAffiliateDoDomain> UserAffiliateList { get; set; }
	
	        /// <summary>
	        /// 用户名称
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 用户id
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
