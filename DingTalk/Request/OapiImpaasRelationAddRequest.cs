using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.impaas.relation.add
    /// </summary>
    public class OapiImpaasRelationAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiImpaasRelationAddResponse>
    {
        /// <summary>
        /// 关系
        /// </summary>
        public string Request { get; set; }

        public AddRelationReqDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.impaas.relation.add";
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
/// AddRelationReqDomain Data Structure.
/// </summary>
[Serializable]

public class AddRelationReqDomain : TopObject
{
	        /// <summary>
	        /// 时间戳精确到毫秒
	        /// </summary>
	        [XmlElement("begin_time")]
	        public Nullable<long> BeginTime { get; set; }
	
	        /// <summary>
	        /// 接收者钉钉的openid
	        /// </summary>
	        [XmlElement("dst_im_openid")]
	        public string DstImOpenid { get; set; }
	
	        /// <summary>
	        /// 时间戳精确到毫秒
	        /// </summary>
	        [XmlElement("end_time")]
	        public Nullable<long> EndTime { get; set; }
	
	        /// <summary>
	        /// 是否双向关系
	        /// </summary>
	        [XmlElement("is_double_way")]
	        public Nullable<bool> IsDoubleWay { get; set; }
	
	        /// <summary>
	        /// 发送者钉钉的openid
	        /// </summary>
	        [XmlElement("src_im_openid")]
	        public string SrcImOpenid { get; set; }
}

        #endregion
    }
}
