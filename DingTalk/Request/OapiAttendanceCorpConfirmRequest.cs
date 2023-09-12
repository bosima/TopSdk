using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.corp.confirm
    /// </summary>
    public class OapiAttendanceCorpConfirmRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceCorpConfirmResponse>
    {
        /// <summary>
        /// 企业id
        /// </summary>
        public string CorpId { get; set; }

        /// <summary>
        /// 企业明细
        /// </summary>
        public string CorpList { get; set; }

        public List<CorpDomain> CorpList_ { set { this.CorpList = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.corp.confirm";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("corp_id", this.CorpId);
            parameters.Add("corp_list", this.CorpList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("corp_id", this.CorpId);
            RequestValidator.ValidateRequired("corp_list", this.CorpList);
            RequestValidator.ValidateObjectMaxListSize("corp_list", this.CorpList, 10);
        }

	/// <summary>
/// CorpDomain Data Structure.
/// </summary>
[Serializable]

public class CorpDomain : TopObject
{
	        /// <summary>
	        /// 管理员名称
	        /// </summary>
	        [XmlElement("admin_name")]
	        public string AdminName { get; set; }
	
	        /// <summary>
	        /// 管理员手机号
	        /// </summary>
	        [XmlElement("admin_phone")]
	        public string AdminPhone { get; set; }
	
	        /// <summary>
	        /// 企业人数
	        /// </summary>
	        [XmlElement("staff_amount")]
	        public Nullable<long> StaffAmount { get; set; }
}

        #endregion
    }
}
