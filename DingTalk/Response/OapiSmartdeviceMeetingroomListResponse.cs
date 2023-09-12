using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceMeetingroomListResponse.
    /// </summary>
    public class OapiSmartdeviceMeetingroomListResponse : DingTalkResponse
    {
        /// <summary>
        /// errorCode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("result")]
        public OpenPageResultDomain Result { get; set; }

	/// <summary>
/// MeetingRoomOpenInfoDomain Data Structure.
/// </summary>
[Serializable]

public class MeetingRoomOpenInfoDomain : TopObject
{
	        /// <summary>
	        /// 会议室容量
	        /// </summary>
	        [XmlElement("capacity")]
	        public string Capacity { get; set; }
	
	        /// <summary>
	        /// 支持的标签列表
	        /// </summary>
	        [XmlArray("labels")]
	        [XmlArrayItem("number")]
	        public List<long> Labels { get; set; }
	
	        /// <summary>
	        /// 会议室名称
	        /// </summary>
	        [XmlElement("room")]
	        public string Room { get; set; }
	
	        /// <summary>
	        /// 会议室id
	        /// </summary>
	        [XmlElement("room_id")]
	        public string RoomId { get; set; }
}

	/// <summary>
/// OpenPageResultDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否有下一页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 系统自动生成
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
	
	        /// <summary>
	        /// 结果
	        /// </summary>
	        [XmlArray("rooms")]
	        [XmlArrayItem("meeting_room_open_info")]
	        public List<MeetingRoomOpenInfoDomain> Rooms { get; set; }
}

    }
}
