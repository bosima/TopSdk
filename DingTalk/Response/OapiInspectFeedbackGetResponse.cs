using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiInspectFeedbackGetResponse.
    /// </summary>
    public class OapiInspectFeedbackGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 反馈表单
        /// </summary>
        [XmlElement("feedback_form")]
        public TopInspectFeedbackVoDomain FeedbackForm { get; set; }

	/// <summary>
/// TopInspectFeedbackFormItemVODomain Data Structure.
/// </summary>
[Serializable]

public class TopInspectFeedbackFormItemVODomain : TopObject
{
	        /// <summary>
	        /// 表单项的业务别名
	        /// </summary>
	        [XmlElement("biz_alias")]
	        public string BizAlias { get; set; }
	
	        /// <summary>
	        /// 表单项的唯一标识
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 表单项标题
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// 表单项的类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 表单项的值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// TopInspectFeedbackVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopInspectFeedbackVoDomain : TopObject
{
	        /// <summary>
	        /// 表单内容
	        /// </summary>
	        [XmlArray("content")]
	        [XmlArrayItem("top_inspect_feedback_form_item_v_o")]
	        public List<TopInspectFeedbackFormItemVODomain> Content { get; set; }
	
	        /// <summary>
	        /// 表单唯一标识
	        /// </summary>
	        [XmlElement("form_inst_id")]
	        public string FormInstId { get; set; }
	
	        /// <summary>
	        /// 表单标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
