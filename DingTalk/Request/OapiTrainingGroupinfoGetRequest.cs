using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.training.groupinfo.get
    /// </summary>
    public class OapiTrainingGroupinfoGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiTrainingGroupinfoGetResponse>
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string Request { get; set; }

        public RequestVODomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.training.groupinfo.get";
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
        }

	/// <summary>
/// RequestVODomain Data Structure.
/// </summary>
[Serializable]

public class RequestVODomain : TopObject
{
	        /// <summary>
	        /// 组织唯一标识corpid
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 群id
	        /// </summary>
	        [XmlArray("ids")]
	        [XmlArrayItem("string")]
	        public List<string> Ids { get; set; }
}

        #endregion
    }
}
