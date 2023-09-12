using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.relation.del
    /// </summary>
    public class OapiImpaasRelationDelRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasRelationDelResponse>
    {
        /// <summary>
        /// 关系
        /// </summary>
        public string Request { get; set; }

        public DelRelationReqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.relation.del";
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
/// DelRelationReqDomain Data Structure.
/// </summary>
[Serializable]

public class DelRelationReqDomain : TopObject
{
	        /// <summary>
	        /// 接受者的im的openid
	        /// </summary>
	        [XmlElement("dst_im_openid")]
	        public string DstImOpenid { get; set; }
	
	        /// <summary>
	        /// 是否双向关系
	        /// </summary>
	        [XmlElement("is_double_way")]
	        public Nullable<bool> IsDoubleWay { get; set; }
	
	        /// <summary>
	        /// 发送者的im的openid
	        /// </summary>
	        [XmlElement("src_im_openid")]
	        public string SrcImOpenid { get; set; }
}

        #endregion
    }
}
