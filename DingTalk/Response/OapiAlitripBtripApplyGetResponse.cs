using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAlitripBtripApplyGetResponse.
    /// </summary>
    public class OapiAlitripBtripApplyGetResponse : DingTalkResponse
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
        /// 审批单对象
        /// </summary>
        [XmlElement("module")]
        public OpenApplyRsDomain Module { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

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
	        /// 到达时间
	        /// </summary>
	        [XmlElement("arr_date")]
	        public string ArrDate { get; set; }
	
	        /// <summary>
	        /// 成本中心
	        /// </summary>
	        [XmlElement("cost_center_name")]
	        public string CostCenterName { get; set; }
	
	        /// <summary>
	        /// 出发城市
	        /// </summary>
	        [XmlElement("dep_city")]
	        public string DepCity { get; set; }
	
	        /// <summary>
	        /// 出发时间
	        /// </summary>
	        [XmlElement("dep_date")]
	        public string DepDate { get; set; }
	
	        /// <summary>
	        /// 发票抬头
	        /// </summary>
	        [XmlElement("invoice_name")]
	        public string InvoiceName { get; set; }
	
	        /// <summary>
	        /// 行程id
	        /// </summary>
	        [XmlElement("itinerary_id")]
	        public string ItineraryId { get; set; }
	
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
	        /// 交通方式：0飞机 1火车 2汽车 3其他
	        /// </summary>
	        [XmlElement("traffic_type")]
	        public long TrafficType { get; set; }
	
	        /// <summary>
	        /// 行程方式：0单程 1往返
	        /// </summary>
	        [XmlElement("trip_way")]
	        public long TripWay { get; set; }
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
/// OpenApproverInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApproverInfoDomain : TopObject
{
	        /// <summary>
	        /// 审批意见
	        /// </summary>
	        [XmlElement("note")]
	        public string Note { get; set; }
	
	        /// <summary>
	        /// 操作时间
	        /// </summary>
	        [XmlElement("operate_time")]
	        public string OperateTime { get; set; }
	
	        /// <summary>
	        /// 审批人顺序
	        /// </summary>
	        [XmlElement("order")]
	        public long Order { get; set; }
	
	        /// <summary>
	        /// 审批状态：0审批中 1已同意 2已拒绝 3已转交，4已取消 5已终止 6发起审批 7评论
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 审批状态描述
	        /// </summary>
	        [XmlElement("status_desc")]
	        public string StatusDesc { get; set; }
	
	        /// <summary>
	        /// 审批人名称
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 审批人id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenApplyRsDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApplyRsDomain : TopObject
{
	        /// <summary>
	        /// 商旅审批展示id
	        /// </summary>
	        [XmlElement("apply_show_id")]
	        public string ApplyShowId { get; set; }
	
	        /// <summary>
	        /// 审批人列表
	        /// </summary>
	        [XmlArray("approver_list")]
	        [XmlArrayItem("open_approver_info")]
	        public List<OpenApproverInfoDomain> ApproverList { get; set; }
	
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
	        /// 部门id
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
	        /// 商旅审批单id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 行程列表
	        /// </summary>
	        [XmlArray("itinerary_list")]
	        [XmlArrayItem("open_itinerary_info")]
	        public List<OpenItineraryInfoDomain> ItineraryList { get; set; }
	
	        /// <summary>
	        /// 申请单状态：0申请 1同意 2拒绝 3转交 4取消 5修改已同意 6撤销已同意 7修改审批中 8已同意(修改被拒绝) 9撤销审批中 10已同意(撤销被拒绝) 11已同意(修改被取消) 12已同意(撤销被取消)
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 审批单状态描述
	        /// </summary>
	        [XmlElement("status_desc")]
	        public string StatusDesc { get; set; }
	
	        /// <summary>
	        /// 第三方审批单id,如果非第三方审批单则为空
	        /// </summary>
	        [XmlElement("thirdpart_id")]
	        public string ThirdpartId { get; set; }
	
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
	        public long TripDay { get; set; }
	
	        /// <summary>
	        /// 审批单标题
	        /// </summary>
	        [XmlElement("trip_title")]
	        public string TripTitle { get; set; }
	
	        /// <summary>
	        /// 申请单提交类型 1：代提交 2：本人提交 注意：当申请单为代提交时，申请单提交人自己无法为自己下单
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
	
	        /// <summary>
	        /// 第三方关联单号
	        /// </summary>
	        [XmlElement("union_no")]
	        public string UnionNo { get; set; }
	
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

    }
}
