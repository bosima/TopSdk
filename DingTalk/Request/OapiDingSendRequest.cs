using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.ding.send
    /// </summary>
    public class OapiDingSendRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiDingSendResponse>
    {
        /// <summary>
        /// 发DING的请求体
        /// </summary>
        public string OpenDingSendVo { get; set; }

        public OpenDingSendVoDomain OpenDingSendVo_ { set { this.OpenDingSendVo = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.ding.send";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_ding_send_vo", this.OpenDingSendVo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_ding_send_vo", this.OpenDingSendVo);
        }

	/// <summary>
/// AttachmentVoDomain Data Structure.
/// </summary>
[Serializable]

public class AttachmentVoDomain : TopObject
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

	/// <summary>
/// OpenDingSendVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenDingSendVoDomain : TopObject
{
	        /// <summary>
	        /// 附件
	        /// </summary>
	        [XmlElement("attachment")]
	        public AttachmentVoDomain Attachment { get; set; }
	
	        /// <summary>
	        /// 接收者工号列表
	        /// </summary>
	        [XmlArray("receiver_uids")]
	        [XmlArrayItem("string")]
	        public List<string> ReceiverUids { get; set; }
	
	        /// <summary>
	        /// 提醒类型:1-应用内;2-短信
	        /// </summary>
	        [XmlElement("remind_type")]
	        public Nullable<long> RemindType { get; set; }
	
	        /// <summary>
	        /// 通知内容
	        /// </summary>
	        [XmlElement("text_content")]
	        public string TextContent { get; set; }
}

        #endregion
    }
}
