using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiInspectTaskListResponse.
    /// </summary>
    public class OapiInspectTaskListResponse : DingTalkResponse
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
        /// 分页结果
        /// </summary>
        [XmlElement("result")]
        public PageResultDomain Result { get; set; }

	/// <summary>
/// TopInspectTaskVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopInspectTaskVoDomain : TopObject
{
	        /// <summary>
	        /// 签到时间戳，单位毫秒
	        /// </summary>
	        [XmlElement("check_in_time")]
	        public long CheckInTime { get; set; }
	
	        /// <summary>
	        /// 签退时间戳，单位毫秒
	        /// </summary>
	        [XmlElement("check_out_time")]
	        public long CheckOutTime { get; set; }
	
	        /// <summary>
	        /// 巡店时间，单位秒
	        /// </summary>
	        [XmlElement("duration")]
	        public string Duration { get; set; }
	
	        /// <summary>
	        /// 位置唯一标识，如果是B1等硬件设备则为设备唯一标识
	        /// </summary>
	        [XmlElement("position_id")]
	        public string PositionId { get; set; }
	
	        /// <summary>
	        /// 位置名称
	        /// </summary>
	        [XmlElement("position_name")]
	        public string PositionName { get; set; }
	
	        /// <summary>
	        /// 任务状态，1已签到，2已正常签退，3已异常签退
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 任务id 唯一标识一个任务
	        /// </summary>
	        [XmlElement("task_id")]
	        public string TaskId { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 工作日期时间戳，单位毫秒
	        /// </summary>
	        [XmlElement("work_date")]
	        public long WorkDate { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否还有数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 巡店任务列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("top_inspect_task_vo")]
	        public List<TopInspectTaskVoDomain> List { get; set; }
	
	        /// <summary>
	        /// 游标，下次分页请求使用
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
