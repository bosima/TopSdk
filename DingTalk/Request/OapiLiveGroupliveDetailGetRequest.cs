using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.live.grouplive.detail.get
    /// </summary>
    public class OapiLiveGroupliveDetailGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiLiveGroupliveDetailGetResponse>
    {
        /// <summary>
        /// 群直播详情请求
        /// </summary>
        public string Req { get; set; }

        public GroupLiveStatisticsReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.live.grouplive.detail.get";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("req", this.Req);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("req", this.Req);
        }

	/// <summary>
/// GroupLiveStatisticsReqDomain Data Structure.
/// </summary>
[Serializable]

public class GroupLiveStatisticsReqDomain : TopObject
{
	        /// <summary>
	        /// 直播所属群对应部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public Nullable<long> DeptId { get; set; }
	
	        /// <summary>
	        /// 群直播id
	        /// </summary>
	        [XmlElement("live_uuid")]
	        public string LiveUuid { get; set; }
}

        #endregion
    }
}
