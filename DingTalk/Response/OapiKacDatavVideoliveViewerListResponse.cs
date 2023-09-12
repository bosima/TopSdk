using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavVideoliveViewerListResponse.
    /// </summary>
    public class OapiKacDatavVideoliveViewerListResponse : DingTalkResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public GroupLiveViewerPageResultDomain Result { get; set; }

	/// <summary>
/// GroupLiveViewerDomain Data Structure.
/// </summary>
[Serializable]

public class GroupLiveViewerDomain : TopObject
{
	        /// <summary>
	        /// 观看直播时长（毫秒）
	        /// </summary>
	        [XmlElement("play_duration")]
	        public long PlayDuration { get; set; }
	
	        /// <summary>
	        /// 观看直播时长（分钟）
	        /// </summary>
	        [XmlElement("play_duration_min")]
	        public string PlayDurationMin { get; set; }
	
	        /// <summary>
	        /// 观看直播回放时长（毫秒）
	        /// </summary>
	        [XmlElement("play_record_duration")]
	        public long PlayRecordDuration { get; set; }
	
	        /// <summary>
	        /// 观看直播回放时长（分钟）
	        /// </summary>
	        [XmlElement("play_record_duration_min")]
	        public string PlayRecordDurationMin { get; set; }
	
	        /// <summary>
	        /// 员工在当前企业内的唯一标识，也称staffId。可由企业在创建时指定，并代表一定含义比如工号，创建后不可修改
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// GroupLiveViewerPageResultDomain Data Structure.
/// </summary>
[Serializable]

public class GroupLiveViewerPageResultDomain : TopObject
{
	        /// <summary>
	        /// 列表数据项
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("group_live_viewer")]
	        public List<GroupLiveViewerDomain> Data { get; set; }
	
	        /// <summary>
	        /// 是否有下一页；true则存在更多分页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一次请求的分页游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
