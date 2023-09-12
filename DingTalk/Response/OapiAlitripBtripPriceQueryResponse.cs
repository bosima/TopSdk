using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripPriceQueryResponse.
    /// </summary>
    public class OapiAlitripBtripPriceQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 接口返回
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// HotelFeeDetailDomain Data Structure.
/// </summary>
[Serializable]

public class HotelFeeDetailDomain : TopObject
{
	        /// <summary>
	        /// 城市
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 费用
	        /// </summary>
	        [XmlElement("criterion")]
	        public long Criterion { get; set; }
}

	/// <summary>
/// MostExpensiveDomain Data Structure.
/// </summary>
[Serializable]

public class MostExpensiveDomain : TopObject
{
	        /// <summary>
	        /// 到达时间
	        /// </summary>
	        [XmlElement("arr_time")]
	        public string ArrTime { get; set; }
	
	        /// <summary>
	        /// 出发时间
	        /// </summary>
	        [XmlElement("dep_time")]
	        public string DepTime { get; set; }
	
	        /// <summary>
	        /// 费用
	        /// </summary>
	        [XmlElement("fee")]
	        public long Fee { get; set; }
	
	        /// <summary>
	        /// 坐席级别
	        /// </summary>
	        [XmlElement("seat_grade")]
	        public string SeatGrade { get; set; }
	
	        /// <summary>
	        /// 班次
	        /// </summary>
	        [XmlElement("vehicle_no")]
	        public string VehicleNo { get; set; }
}

	/// <summary>
/// CheapestDomain Data Structure.
/// </summary>
[Serializable]

public class CheapestDomain : TopObject
{
	        /// <summary>
	        /// 到达时间
	        /// </summary>
	        [XmlElement("arr_time")]
	        public string ArrTime { get; set; }
	
	        /// <summary>
	        /// 出发时间
	        /// </summary>
	        [XmlElement("dep_time")]
	        public string DepTime { get; set; }
	
	        /// <summary>
	        /// 费用
	        /// </summary>
	        [XmlElement("fee")]
	        public long Fee { get; set; }
	
	        /// <summary>
	        /// 坐席级别
	        /// </summary>
	        [XmlElement("seat_grade")]
	        public string SeatGrade { get; set; }
	
	        /// <summary>
	        /// 班次
	        /// </summary>
	        [XmlElement("vehicle_no")]
	        public string VehicleNo { get; set; }
}

	/// <summary>
/// BtripRoutesDomain Data Structure.
/// </summary>
[Serializable]

public class BtripRoutesDomain : TopObject
{
	        /// <summary>
	        /// 最低价
	        /// </summary>
	        [XmlElement("cheapest")]
	        public CheapestDomain Cheapest { get; set; }
	
	        /// <summary>
	        /// 出发时间
	        /// </summary>
	        [XmlElement("dep_date")]
	        public string DepDate { get; set; }
	
	        /// <summary>
	        /// 目的地
	        /// </summary>
	        [XmlElement("dest_city")]
	        public string DestCity { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("err_msg")]
	        public string ErrMsg { get; set; }
	
	        /// <summary>
	        /// 最高价
	        /// </summary>
	        [XmlElement("most_expensive")]
	        public MostExpensiveDomain MostExpensive { get; set; }
	
	        /// <summary>
	        /// 出发地
	        /// </summary>
	        [XmlElement("org_city")]
	        public string OrgCity { get; set; }
	
	        /// <summary>
	        /// 查询是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

	/// <summary>
/// TrafficFeeDomain Data Structure.
/// </summary>
[Serializable]

public class TrafficFeeDomain : TopObject
{
	        /// <summary>
	        /// 行程费用
	        /// </summary>
	        [XmlArray("btrip_routes")]
	        [XmlArrayItem("btrip_routes")]
	        public List<BtripRoutesDomain> BtripRoutes { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("err_msg")]
	        public string ErrMsg { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

	/// <summary>
/// ModuleDomain Data Structure.
/// </summary>
[Serializable]

public class ModuleDomain : TopObject
{
	        /// <summary>
	        /// 酒店差标
	        /// </summary>
	        [XmlArray("hotel_fee_detail")]
	        [XmlArrayItem("hotel_fee_detail")]
	        public List<HotelFeeDetailDomain> HotelFeeDetail { get; set; }
	
	        /// <summary>
	        /// 异步查询key。需要client再次尝试请求
	        /// </summary>
	        [XmlElement("query_key")]
	        public string QueryKey { get; set; }
	
	        /// <summary>
	        /// 费用
	        /// </summary>
	        [XmlElement("traffic_fee")]
	        public TrafficFeeDomain TrafficFee { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
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
	        /// 接口返回model
	        /// </summary>
	        [XmlElement("module")]
	        public ModuleDomain Module { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
