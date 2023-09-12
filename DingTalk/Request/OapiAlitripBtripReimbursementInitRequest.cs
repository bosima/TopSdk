using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.reimbursement.init
    /// </summary>
    public class OapiAlitripBtripReimbursementInitRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripReimbursementInitResponse>
    {
        /// <summary>
        /// 入参，创建报销单参数
        /// </summary>
        public string Rq { get; set; }

        public OpenApiNewReimbursementRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.reimbursement.init";
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
/// OpenUserInfoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenUserInfoDomain : TopObject
{
	        /// <summary>
	        /// 报销人id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// ApproverNodeDomain Data Structure.
/// </summary>
[Serializable]

public class ApproverNodeDomain : TopObject
{
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("note")]
	        public string Note { get; set; }
	
	        /// <summary>
	        /// 审批操作时间
	        /// </summary>
	        [XmlElement("operate_time")]
	        public Nullable<DateTime> OperateTime { get; set; }
	
	        /// <summary>
	        /// 报销审批单状态：0审批中 1已同意 2已拒绝 3已转交，4已取消 5已终止
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
	
	        /// <summary>
	        /// 审批人id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenApiNewReimbursementRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiNewReimbursementRqDomain : TopObject
{
	        /// <summary>
	        /// 申请单编号
	        /// </summary>
	        [XmlElement("apply_flow_no")]
	        public Nullable<long> ApplyFlowNo { get; set; }
	
	        /// <summary>
	        /// 审批列表
	        /// </summary>
	        [XmlArray("audit_list")]
	        [XmlArrayItem("approver_node")]
	        public List<ApproverNodeDomain> AuditList { get; set; }
	
	        /// <summary>
	        /// corp id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 部门ID，不填时取用户所在部门id
	        /// </summary>
	        [XmlElement("depart_id")]
	        public string DepartId { get; set; }
	
	        /// <summary>
	        /// 部门名称，不填时取用户所在部门id
	        /// </summary>
	        [XmlElement("depart_name")]
	        public string DepartName { get; set; }
	
	        /// <summary>
	        /// 报销单详情
	        /// </summary>
	        [XmlElement("detail_url")]
	        public string DetailUrl { get; set; }
	
	        /// <summary>
	        /// isv标识
	        /// </summary>
	        [XmlElement("isv_code")]
	        public string IsvCode { get; set; }
	
	        /// <summary>
	        /// 报销人
	        /// </summary>
	        [XmlElement("operator")]
	        public OpenUserInfoDomain Operator { get; set; }
	
	        /// <summary>
	        /// 关联的报销订单id列表,<订单id:类型(机、酒、火、用车)>
	        /// </summary>
	        [XmlElement("order_ids")]
	        public string OrderIds { get; set; }
	
	        /// <summary>
	        /// 报销金额
	        /// </summary>
	        [XmlElement("pay_amount")]
	        public Nullable<long> PayAmount { get; set; }
	
	        /// <summary>
	        /// 状态  0：审批中，1：已同意，2：已拒绝，4：已撤销
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
	
	        /// <summary>
	        /// 第三方流程id
	        /// </summary>
	        [XmlElement("thirdparty_flow_id")]
	        public string ThirdpartyFlowId { get; set; }
	
	        /// <summary>
	        /// 报销单标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

        #endregion
    }
}
