using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.hrm.employee.delemployeedismissionandhandover
    /// </summary>
    public class CorpHrmEmployeeDelemployeedismissionandhandoverRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpHrmEmployeeDelemployeedismissionandhandoverResponse>
    {
        /// <summary>
        /// 确认离职对象
        /// </summary>
        public string DismissionInfoWithHandOver { get; set; }

        public EmpDismissionInfoWithHandOverVoDomain DismissionInfoWithHandOver_ { set { this.DismissionInfoWithHandOver = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 操作人userid
        /// </summary>
        public string OpUserid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.hrm.employee.delemployeedismissionandhandover";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dismission_info_with_hand_over", this.DismissionInfoWithHandOver);
            parameters.Add("op_userid", this.OpUserid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("dismission_info_with_hand_over", this.DismissionInfoWithHandOver);
            RequestValidator.ValidateRequired("op_userid", this.OpUserid);
        }

	/// <summary>
/// EmpDismissionInfoWithHandOverVoDomain Data Structure.
/// </summary>
[Serializable]

public class EmpDismissionInfoWithHandOverVoDomain : TopObject
{
	        /// <summary>
	        /// 离职描述
	        /// </summary>
	        [XmlElement("dismission_memo")]
	        public string DismissionMemo { get; set; }
	
	        /// <summary>
	        /// 离职原因（1：家庭原因，2:个人原因，3：发展原因，4：合同到期不续签，5：协议解除，6：无法胜任工作，7：经济性裁员，8：严重违法违纪，9：其他）
	        /// </summary>
	        [XmlElement("dismission_reason")]
	        public string DismissionReason { get; set; }
	
	        /// <summary>
	        /// 离职人userid
	        /// </summary>
	        [XmlElement("dismission_userid")]
	        public string DismissionUserid { get; set; }
	
	        /// <summary>
	        /// 交接人userid
	        /// </summary>
	        [XmlElement("hand_over_userid")]
	        public string HandOverUserid { get; set; }
	
	        /// <summary>
	        /// 最后工作日
	        /// </summary>
	        [XmlElement("last_work_date")]
	        public Nullable<DateTime> LastWorkDate { get; set; }
}

        #endregion
    }
}
