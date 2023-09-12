using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.smartwork.hrm.navigationbar.config.get
    /// </summary>
    public class OapiSmartworkHrmNavigationbarConfigGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiSmartworkHrmNavigationbarConfigGetResponse>
    {
        /// <summary>
        /// isv变更导航栏属性
        /// </summary>
        public string ChangeParam { get; set; }

        public List<HrmNavChangeVoDomain> ChangeParam_ { set { this.ChangeParam = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 基础导航了类型，枚举值, "pc"-PC端, "oa"-OA端
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 导航栏访问员工ID
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.smartwork.hrm.navigationbar.config.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("change_param", this.ChangeParam);
            parameters.Add("type", this.Type);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("change_param", this.ChangeParam, 20);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

	/// <summary>
/// HrmNavChangeVoDomain Data Structure.
/// </summary>
[Serializable]

public class HrmNavChangeVoDomain : TopObject
{
	        /// <summary>
	        /// 变更的节点code
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 变更的链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

        #endregion
    }
}
