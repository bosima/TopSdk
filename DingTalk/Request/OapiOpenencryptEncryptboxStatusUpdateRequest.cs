using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.openencrypt.encryptbox.status.update
    /// </summary>
    public class OapiOpenencryptEncryptboxStatusUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiOpenencryptEncryptboxStatusUpdateResponse>
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        public string TopEncryptBoxStatus { get; set; }

        public TopEncryptBoxStatusDomain TopEncryptBoxStatus_ { set { this.TopEncryptBoxStatus = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.openencrypt.encryptbox.status.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("top_encrypt_box_status", this.TopEncryptBoxStatus);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("top_encrypt_box_status", this.TopEncryptBoxStatus);
        }

	/// <summary>
/// TopEncryptBoxStatusDomain Data Structure.
/// </summary>
[Serializable]

public class TopEncryptBoxStatusDomain : TopObject
{
	        /// <summary>
	        /// 微应用的id
	        /// </summary>
	        [XmlElement("appid")]
	        public Nullable<long> Appid { get; set; }
	
	        /// <summary>
	        /// 组织的id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 附加信息，方便扩展
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 请求的id
	        /// </summary>
	        [XmlElement("request_id")]
	        public string RequestId { get; set; }
	
	        /// <summary>
	        /// 加密盒子状态，1表示盒子掉线，2表示盒子上线，3表示企业之前有盒子，现在变成了无盒子的状态
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
}

        #endregion
    }
}
