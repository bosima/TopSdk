using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.processinstance.cspace.preview
    /// </summary>
    public class OapiProcessinstanceCspacePreviewRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessinstanceCspacePreviewResponse>
    {
        /// <summary>
        /// request
        /// </summary>
        public string Request { get; set; }

        public GrantCspaceRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.processinstance.cspace.preview";
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
/// GrantCspaceRequestDomain Data Structure.
/// </summary>
[Serializable]

public class GrantCspaceRequestDomain : TopObject
{
	        /// <summary>
	        /// 应用id
	        /// </summary>
	        [XmlElement("agentid")]
	        public Nullable<long> Agentid { get; set; }
	
	        /// <summary>
	        /// 附件id
	        /// </summary>
	        [XmlElement("file_id")]
	        public string FileId { get; set; }
	
	        /// <summary>
	        /// 附件id列表，支持批量授权
	        /// </summary>
	        [XmlArray("fileid_list")]
	        [XmlArrayItem("string")]
	        public List<string> FileidList { get; set; }
	
	        /// <summary>
	        /// 实例id
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
	
	        /// <summary>
	        /// 授权用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

        #endregion
    }
}
