using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.live.grouplive.listbytime
    /// </summary>
    public class OapiLiveGroupliveListbytimeRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiLiveGroupliveListbytimeResponse>
    {
        /// <summary>
        /// 查询直播参数
        /// </summary>
        public string Req { get; set; }

        public GroupLiveRecordReqDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.live.grouplive.listbytime";
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
/// GroupLiveRecordReqDomain Data Structure.
/// </summary>
[Serializable]

public class GroupLiveRecordReqDomain : TopObject
{
	        /// <summary>
	        /// 直播所属群对应的部门
	        /// </summary>
	        [XmlElement("dept_id")]
	        public Nullable<long> DeptId { get; set; }
	
	        /// <summary>
	        /// 结束时间，单位秒
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<long> EndTime { get; set; }
	
	        /// <summary>
	        /// 开始时间，单位秒
	        /// </summary>
	        [XmlElement("start_time")]
	        public Nullable<long> StartTime { get; set; }
}

        #endregion
    }
}
