using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.reimbursement.update
    /// </summary>
    public class OapiAlitripBtripReimbursementUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripReimbursementUpdateResponse>
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public string Rq { get; set; }

        public OpenApiUpdateReimbursementRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.reimbursement.update";
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
/// AuditlistDomain Data Structure.
/// </summary>
[Serializable]

public class AuditlistDomain : TopObject
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
	        /// 审批状态：0审批中 1已同意 2已拒绝 3已转交，4已取消 5已终止
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
/// OpenApiUpdateReimbursementRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiUpdateReimbursementRqDomain : TopObject
{
	        /// <summary>
	        /// 申请单编号,如不做变更，请与创建报销单时保持一致
	        /// </summary>
	        [XmlElement("apply_flow_no")]
	        public Nullable<long> ApplyFlowNo { get; set; }
	
	        /// <summary>
	        /// 审批人列表
	        /// </summary>
	        [XmlArray("audit_list")]
	        [XmlArrayItem("auditlist")]
	        public List<AuditlistDomain> AuditList { get; set; }
	
	        /// <summary>
	        /// corp id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 审批单号
	        /// </summary>
	        [XmlElement("flow_no")]
	        public Nullable<long> FlowNo { get; set; }
	
	        /// <summary>
	        /// 审批操作时间
	        /// </summary>
	        [XmlElement("operate_time")]
	        public Nullable<DateTime> OperateTime { get; set; }
	
	        /// <summary>
	        /// 关联的报销订单id列表,<订单id:类型(机、酒、火、用车)>如不做变更，请与创建报销单时保持一致
	        /// </summary>
	        [XmlElement("order_ids")]
	        public string OrderIds { get; set; }
	
	        /// <summary>
	        /// 审批状态
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
	
	        /// <summary>
	        /// 第三方报销单id
	        /// </summary>
	        [XmlElement("thirdparty_flow_id")]
	        public string ThirdpartyFlowId { get; set; }
}

        #endregion
    }
}
