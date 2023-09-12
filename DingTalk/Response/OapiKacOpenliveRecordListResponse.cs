using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacOpenliveRecordListResponse.
    /// </summary>
    public class OapiKacOpenliveRecordListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果集合
        /// </summary>
        [XmlElement("result")]
        public ResultListDomain Result { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ListOpenLiveRecordRspModelDomain Data Structure.
/// </summary>
[Serializable]

public class ListOpenLiveRecordRspModelDomain : TopObject
{
	        /// <summary>
	        /// 直播ID
	        /// </summary>
	        [XmlElement("live_id")]
	        public string LiveId { get; set; }
	
	        /// <summary>
	        /// 直播观看链接
	        /// </summary>
	        [XmlElement("live_link")]
	        public string LiveLink { get; set; }
	
	        /// <summary>
	        /// 公开类型 0: 不公开; 1: 完全公开; 2:组织内公开
	        /// </summary>
	        [XmlElement("public_type")]
	        public long PublicType { get; set; }
	
	        /// <summary>
	        /// 预约开始时间戳
	        /// </summary>
	        [XmlElement("start_time")]
	        public long StartTime { get; set; }
	
	        /// <summary>
	        /// 直播状态：init: 未开播, living: 直播中，end: 直播已结束
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 直播标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// ResultListDomain Data Structure.
/// </summary>
[Serializable]

public class ResultListDomain : TopObject
{
	        /// <summary>
	        /// 直播总数
	        /// </summary>
	        [XmlElement("total_cnt")]
	        public long TotalCnt { get; set; }
	
	        /// <summary>
	        /// 集合子对象
	        /// </summary>
	        [XmlArray("values")]
	        [XmlArrayItem("list_open_live_record_rsp_model")]
	        public List<ListOpenLiveRecordRspModelDomain> Values { get; set; }
}

    }
}
