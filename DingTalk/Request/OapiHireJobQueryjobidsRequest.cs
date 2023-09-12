using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.hire.job.queryjobids
    /// </summary>
    public class OapiHireJobQueryjobidsRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiHireJobQueryjobidsResponse>
    {
        /// <summary>
        /// 查询参数
        /// </summary>
        public string QueryParam { get; set; }

        public TopQueryJobIdsParamDomain QueryParam_ { set { this.QueryParam = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 员工标识
        /// </summary>
        public string Userid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.hire.job.queryjobids";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query_param", this.QueryParam);
            parameters.Add("userid", this.Userid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("userid", this.Userid);
        }

	/// <summary>
/// TopQueryJobIdsParamDomain Data Structure.
/// </summary>
[Serializable]

public class TopQueryJobIdsParamDomain : TopObject
{
	        /// <summary>
	        /// 角色类型：2表示职位负责人，4表示用人经理
	        /// </summary>
	        [XmlElement("role_type")]
	        public Nullable<long> RoleType { get; set; }
}

        #endregion
    }
}
