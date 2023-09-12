using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.alitrip.btrip.approval.update
    /// </summary>
    public class OapiAlitripBtripApprovalUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAlitripBtripApprovalUpdateResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Rq { get; set; }

        public OpenApiUpdateApplyRqDomain Rq_ { set { this.Rq = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.alitrip.btrip.approval.update";
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
/// OpenApiUpdateApplyRqDomain Data Structure.
/// </summary>
[Serializable]

public class OpenApiUpdateApplyRqDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("note")]
	        public string Note { get; set; }
	
	        /// <summary>
	        /// 操作时间
	        /// </summary>
	        [XmlElement("operate_time")]
	        public Nullable<DateTime> OperateTime { get; set; }
	
	        /// <summary>
	        /// 1已同意 2已拒绝 3已转交 4已取消
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
	
	        /// <summary>
	        /// 外部申请单id
	        /// </summary>
	        [XmlElement("thirdpart_apply_id")]
	        public string ThirdpartApplyId { get; set; }
	
	        /// <summary>
	        /// 审批人名字
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 审批人id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
