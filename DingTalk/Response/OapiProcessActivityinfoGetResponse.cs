using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessActivityinfoGetResponse.
    /// </summary>
    public class OapiProcessActivityinfoGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 流程节点信息
        /// </summary>
        [XmlElement("result")]
        public ProcessActivityTopVoDomain Result { get; set; }

        /// <summary>
        /// 接口状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ActivityModelDomain Data Structure.
/// </summary>
[Serializable]

public class ActivityModelDomain : TopObject
{
	        /// <summary>
	        /// 节点id
	        /// </summary>
	        [XmlElement("activity_id")]
	        public string ActivityId { get; set; }
	
	        /// <summary>
	        /// 节点名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// ProcessActivityTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessActivityTopVoDomain : TopObject
{
	        /// <summary>
	        /// 节点信息列表
	        /// </summary>
	        [XmlArray("models")]
	        [XmlArrayItem("activity_model")]
	        public List<ActivityModelDomain> Models { get; set; }
	
	        /// <summary>
	        /// 模板code
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
}

    }
}
