using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.process.instance.comment.add
    /// </summary>
    public class OapiProcessInstanceCommentAddRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiProcessInstanceCommentAddResponse>
    {
        /// <summary>
        /// 请求
        /// </summary>
        public string Request { get; set; }

        public AddCommentRequestDomain Request_ { set { this.Request = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.process.instance.comment.add";
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
/// AddCommentRequestDomain Data Structure.
/// </summary>
[Serializable]

public class AddCommentRequestDomain : TopObject
{
	        /// <summary>
	        /// 评论人工号
	        /// </summary>
	        [XmlElement("comment_userid")]
	        public string CommentUserid { get; set; }
	
	        /// <summary>
	        /// 文件类
	        /// </summary>
	        [XmlElement("file")]
	        public FileDomain File { get; set; }
	
	        /// <summary>
	        /// 实例id
	        /// </summary>
	        [XmlElement("process_instance_id")]
	        public string ProcessInstanceId { get; set; }
	
	        /// <summary>
	        /// 评论内容
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
}

        #endregion
    }
}
