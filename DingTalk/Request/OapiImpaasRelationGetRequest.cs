using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.relation.get
    /// </summary>
    public class OapiImpaasRelationGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasRelationGetResponse>
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        public string Request { get; set; }

        public GetRelationReqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.relation.get";
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
/// GetRelationReqDomain Data Structure.
/// </summary>
[Serializable]

public class GetRelationReqDomain : TopObject
{
	        /// <summary>
	        /// 接收者钉钉的openid
	        /// </summary>
	        [XmlArray("dst_im_openids")]
	        [XmlArrayItem("string")]
	        public List<string> DstImOpenids { get; set; }
	
	        /// <summary>
	        /// 发送者钉钉的openid
	        /// </summary>
	        [XmlElement("src_im_openid")]
	        public string SrcImOpenid { get; set; }
}

        #endregion
    }
}
