using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.edu.user.classroles.get
    /// </summary>
    public class OapiEduUserClassrolesGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiEduUserClassrolesGetResponse>
    {
        /// <summary>
        /// 请求对象
        /// </summary>
        public string Request { get; set; }

        public OpenUserClassRoleListRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.edu.user.classroles.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request", this.Request);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("request", this.Request);
        }

	/// <summary>
/// OpenUserClassRoleListRequestDomain Data Structure.
/// </summary>
[Serializable]

public class OpenUserClassRoleListRequestDomain : TopObject
{
	        /// <summary>
	        /// 员工ID
	        /// </summary>
	        [XmlElement("user_id")]
	        public string UserId { get; set; }
}

        #endregion
    }
}
