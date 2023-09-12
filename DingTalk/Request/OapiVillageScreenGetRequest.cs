using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.village.screen.get
    /// </summary>
    public class OapiVillageScreenGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiVillageScreenGetResponse>
    {
        /// <summary>
        /// -
        /// </summary>
        public string Req { get; set; }

        public DataVScreenRequestDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.village.screen.get";
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
        }

	/// <summary>
/// DataVScreenRequestDomain Data Structure.
/// </summary>
[Serializable]

public class DataVScreenRequestDomain : TopObject
{
	        /// <summary>
	        /// -
	        /// </summary>
	        [XmlElement("params")]
	        public string Params { get; set; }
}

        #endregion
    }
}
