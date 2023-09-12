using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.instance.execute
    /// </summary>
    public class OapiProcessinstanceExecuteV2Request : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessinstanceExecuteV2Response>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public ExecuteTaskRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.instance.execute";
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
/// AttachmentDomain Data Structure.
/// </summary>
[Serializable]

public class AttachmentDomain : TopObject
{
	        /// <summary>
	        /// 文件id
	        /// </summary>
	        [XmlElement("file_id")]
	        public string FileId { get; set; }
	
	        /// <summary>
	        /// 文件名
	        /// </summary>
	        [XmlElement("file_name")]
	        public string FileName { get; set; }
	
	        /// <summary>
	        /// 文件大小
	        /// </summary>
	        [XmlElement("file_size")]
	        public string FileSize { get; set; }
	
	        /// <summary>
	        /// 文件类型
	        /// </summary>
	        [XmlElement("file_type")]
	        public string FileType { get; set; }
	
	        /// <summary>
	        /// 钉盘spaceId
	        /// </summary>
	        [XmlElement("space_id")]
	        public string SpaceId { get; set; }
}

	/// <summary>
/// FileDomain Data Structure.
/// </summary>
[Serializable]

public class FileDomain : TopObject
{
	        /// <summary>
	        /// 附件
	        /// </summary>
	        [XmlArray("attachments")]
	        [XmlArrayItem("attachment")]
	        public List<AttachmentDomain> Attachments { get; set; }
	
	        /// <summary>
	        /// 图片
	        /// </summary>
	        [XmlArray("photos")]
	        [XmlArrayItem("string")]
	        public List<string> Photos { get; set; }
}

	/// <summary>
/// ExecuteTaskRequestDomain Data Structure.
/// </summary>
[Serializable]

public class ExecuteTaskRequestDomain : TopObject
{
	        /// <summary>
	        /// 操作人id，通过dingtalk.smartwork.bpms.processinstance.get这个接口可以获取
	        /// </summary>
	        [XmlElement("actioner_userid")]
	        public string ActionerUserid { get; set; }
	
	        /// <summary>
	        /// 文件
	        /// </summary>
	        [XmlElement("file")]
	        public FileDomain File { get; set; }
	
	        /// <summary>
	        /// 审批实例id
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
	
	        /// <summary>
	        /// 操作评论，可为空
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 审批操作，同意-agree，拒绝-refuse
	        /// </summary>
	        [XmlElement("result")]
	        public string Result { get; set; }
	
	        /// <summary>
	        /// 任务节点id，dingtalk.smartwork.bpms.processinstance.get接口可获取
	        /// </summary>
	        [XmlElement("task_id")]
	        public Nullable<long> TaskId { get; set; }
}

        #endregion
    }
}
