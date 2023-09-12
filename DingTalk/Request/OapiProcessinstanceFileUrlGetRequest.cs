using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.processinstance.file.url.get
    /// </summary>
    public class OapiProcessinstanceFileUrlGetRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessinstanceFileUrlGetResponse>
    {
        /// <summary>
        /// 入参
        /// </summary>
        public string Request { get; set; }

        public GrantCspaceRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.processinstance.file.url.get";
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
/// GrantCspaceRequestDomain Data Structure.
/// </summary>
[Serializable]

public class GrantCspaceRequestDomain : TopObject
{
	        /// <summary>
	        /// 文件id
	        /// </summary>
	        [XmlElement("file_id")]
	        public string FileId { get; set; }
	
	        /// <summary>
	        /// 审批单实例id
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
}

        #endregion
    }
}
