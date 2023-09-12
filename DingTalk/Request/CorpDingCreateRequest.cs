using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.corp.ding.create
    /// </summary>
    public class CorpDingCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.CorpDingCreateResponse>
    {
        /// <summary>
        /// 附件内容
        /// </summary>
        public string Attachment { get; set; }

        public AttachmentVODomain Attachment_ { set { this.Attachment = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 发送者工号
        /// </summary>
        public string CreatorUserid { get; set; }

        /// <summary>
        /// 接收者工号列表
        /// </summary>
        public string ReceiverUserids { get; set; }

        /// <summary>
        /// 发送时间(单位:毫秒)
        /// </summary>
        public Nullable<long> RemindTime { get; set; }

        /// <summary>
        /// 提醒类型:1-应用内;2-短信
        /// </summary>
        public Nullable<long> RemindType { get; set; }

        /// <summary>
        /// 通知内容
        /// </summary>
        public string TextContent { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.corp.ding.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_TOP;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attachment", this.Attachment);
            parameters.Add("creator_userid", this.CreatorUserid);
            parameters.Add("receiver_userids", this.ReceiverUserids);
            parameters.Add("remind_time", this.RemindTime);
            parameters.Add("remind_type", this.RemindType);
            parameters.Add("text_content", this.TextContent);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("creator_userid", this.CreatorUserid);
            RequestValidator.ValidateRequired("receiver_userids", this.ReceiverUserids);
            RequestValidator.ValidateMaxListSize("receiver_userids", this.ReceiverUserids, 20);
            RequestValidator.ValidateRequired("remind_time", this.RemindTime);
            RequestValidator.ValidateRequired("remind_type", this.RemindType);
            RequestValidator.ValidateRequired("text_content", this.TextContent);
            RequestValidator.ValidateMaxLength("text_content", this.TextContent, 5000);
        }

	/// <summary>
/// AttachmentVODomain Data Structure.
/// </summary>
[Serializable]

public class AttachmentVODomain : TopObject
{
	        /// <summary>
	        /// 文件后缀, 用于展示文件对应图标
	        /// </summary>
	        [XmlElement("detail_type")]
	        public string DetailType { get; set; }
	
	        /// <summary>
	        /// 上传DING盘后的文件ID
	        /// </summary>
	        [XmlElement("file_id")]
	        public string FileId { get; set; }
	
	        /// <summary>
	        /// 文件名
	        /// </summary>
	        [XmlElement("file_name")]
	        public string FileName { get; set; }
	
	        /// <summary>
	        /// 文件大小(单位:Byte, 最大2G)
	        /// </summary>
	        [XmlElement("file_size")]
	        public Nullable<long> FileSize { get; set; }
	
	        /// <summary>
	        /// 上传DING盘后的SpaceId
	        /// </summary>
	        [XmlElement("file_space_id")]
	        public string FileSpaceId { get; set; }
	
	        /// <summary>
	        /// 链接缩略图
	        /// </summary>
	        [XmlElement("link_pic_url")]
	        public string LinkPicUrl { get; set; }
	
	        /// <summary>
	        /// 链接摘要
	        /// </summary>
	        [XmlElement("link_text")]
	        public string LinkText { get; set; }
	
	        /// <summary>
	        /// 链接标题
	        /// </summary>
	        [XmlElement("link_title")]
	        public string LinkTitle { get; set; }
	
	        /// <summary>
	        /// 链接URL
	        /// </summary>
	        [XmlElement("link_url")]
	        public string LinkUrl { get; set; }
	
	        /// <summary>
	        /// 附件类型:img-图片,link-链接,file-文件
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

        #endregion
    }
}
