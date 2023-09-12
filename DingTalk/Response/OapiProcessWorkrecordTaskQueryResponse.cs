using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessWorkrecordTaskQueryResponse.
    /// </summary>
    public class OapiProcessWorkrecordTaskQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果集
        /// </summary>
        [XmlElement("result")]
        public PageResultDomain Result { get; set; }

	/// <summary>
/// FormItemVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormItemVoDomain : TopObject
{
	        /// <summary>
	        /// 内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// WorkRecordVoDomain Data Structure.
/// </summary>
[Serializable]

public class WorkRecordVoDomain : TopObject
{
	        /// <summary>
	        /// 表单列表
	        /// </summary>
	        [XmlArray("forms")]
	        [XmlArrayItem("form_item_vo")]
	        public List<FormItemVoDomain> Forms { get; set; }
	
	        /// <summary>
	        /// 实例id
	        /// </summary>
	        [XmlElement("instance_id")]
	        public string InstanceId { get; set; }
	
	        /// <summary>
	        /// 任务id
	        /// </summary>
	        [XmlElement("task_id")]
	        public string TaskId { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 跳转链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否有更多数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("work_record_vo")]
	        public List<WorkRecordVoDomain> List { get; set; }
}

    }
}
