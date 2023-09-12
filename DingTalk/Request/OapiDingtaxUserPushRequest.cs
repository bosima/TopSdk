using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.dingtax.user.push
    /// </summary>
    public class OapiDingtaxUserPushRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingtaxUserPushResponse>
    {
        /// <summary>
        /// 运营区域
        /// </summary>
        public string SourceRegion { get; set; }

        /// <summary>
        /// 运营数据
        /// </summary>
        public string UserInfoList { get; set; }

        public List<DingTaxUserInfoDTODomain> UserInfoList_ { set { this.UserInfoList = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.dingtax.user.push";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("source_region", this.SourceRegion);
            parameters.Add("user_info_list", this.UserInfoList);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("source_region", this.SourceRegion);
            RequestValidator.ValidateRequired("user_info_list", this.UserInfoList);
            RequestValidator.ValidateObjectMaxListSize("user_info_list", this.UserInfoList, 20);
        }

	/// <summary>
/// DingTaxUserInfoDTODomain Data Structure.
/// </summary>
[Serializable]

public class DingTaxUserInfoDTODomain : TopObject
{
	        /// <summary>
	        /// Y/N;Y代表新增用户，N代表存量用户
	        /// </summary>
	        [XmlElement("new_user")]
	        public string NewUser { get; set; }
	
	        /// <summary>
	        /// 自然人/企业/个体户
	        /// </summary>
	        [XmlElement("taxation_type")]
	        public string TaxationType { get; set; }
	
	        /// <summary>
	        /// 手机号
	        /// </summary>
	        [XmlElement("user_mobile")]
	        public string UserMobile { get; set; }
	
	        /// <summary>
	        /// CW/FR
	        /// </summary>
	        [XmlElement("user_role")]
	        public string UserRole { get; set; }
}

        #endregion
    }
}
