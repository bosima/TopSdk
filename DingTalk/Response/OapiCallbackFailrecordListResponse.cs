using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCallbackFailrecordListResponse.
    /// </summary>
    public class OapiCallbackFailrecordListResponse : DingTalkResponse
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
        /// 回调失败数据列表
        /// </summary>
        [XmlArray("failed_list")]
        [XmlArrayItem("failed_list")]
        public List<FailedListDomain> FailedList { get; set; }

        /// <summary>
        /// 是否更多
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

	/// <summary>
/// FailedListDomain Data Structure.
/// </summary>
[Serializable]

public class FailedListDomain : TopObject
{
	        /// <summary>
	        /// 回调数据。不同事件类型不同，通常为JSON String
	        /// </summary>
	        [XmlElement("call_back_data")]
	        public string CallBackData { get; set; }
	
	        /// <summary>
	        /// 事件类型
	        /// </summary>
	        [XmlElement("call_back_tag")]
	        public string CallBackTag { get; set; }
	
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corpid")]
	        public string Corpid { get; set; }
	
	        /// <summary>
	        /// 失败时间。单位：毫秒
	        /// </summary>
	        [XmlElement("event_time")]
	        public long EventTime { get; set; }
	
	        /// <summary>
	        /// 回调失败记录id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
}

    }
}
