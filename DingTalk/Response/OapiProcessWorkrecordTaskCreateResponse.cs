using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessWorkrecordTaskCreateResponse.
    /// </summary>
    public class OapiProcessWorkrecordTaskCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 0
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 任务列表
        /// </summary>
        [XmlArray("tasks")]
        [XmlArrayItem("task_top_vo")]
        public List<TaskTopVoDomain> Tasks { get; set; }

	/// <summary>
/// TaskTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class TaskTopVoDomain : TopObject
{
	        /// <summary>
	        /// 任务id
	        /// </summary>
	        [XmlElement("task_id")]
	        public long TaskId { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
