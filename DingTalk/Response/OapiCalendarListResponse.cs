using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCalendarListResponse.
    /// </summary>
    public class OapiCalendarListResponse : DingTalkResponse
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
        /// api返回的结果对象
        /// </summary>
        [XmlElement("result")]
        public OpenCalendarListResponseDomain Result { get; set; }

        /// <summary>
        /// 调用成功标识位
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// AttendeesDomain Data Structure.
/// </summary>
[Serializable]

public class AttendeesDomain : TopObject
{
	        /// <summary>
	        /// 展示姓名
	        /// </summary>
	        [XmlElement("display_name")]
	        public string DisplayName { get; set; }
	
	        /// <summary>
	        /// 是否组织者
	        /// </summary>
	        [XmlElement("organizer")]
	        public bool Organizer { get; set; }
	
	        /// <summary>
	        /// 响应状态（accepted, declined, needsAction）
	        /// </summary>
	        [XmlElement("response_status")]
	        public string ResponseStatus { get; set; }
	
	        /// <summary>
	        /// 是否自己
	        /// </summary>
	        [XmlElement("self")]
	        public bool Self { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// UserDomain Data Structure.
/// </summary>
[Serializable]

public class UserDomain : TopObject
{
	        /// <summary>
	        /// 展示姓名
	        /// </summary>
	        [XmlElement("display_name")]
	        public string DisplayName { get; set; }
	
	        /// <summary>
	        /// 是否自己
	        /// </summary>
	        [XmlElement("self")]
	        public bool Self { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// DateTimeDomain Data Structure.
/// </summary>
[Serializable]

public class DateTimeDomain : TopObject
{
	        /// <summary>
	        /// 全天事件的时候使用 yyyy-MM-dd（date_time和date不可以同时出现）
	        /// </summary>
	        [XmlElement("date")]
	        public string Date { get; set; }
	
	        /// <summary>
	        /// 时间 'yyyy-MM-ddTHH:mm:ssZ',
	        /// </summary>
	        [XmlElement("date_time")]
	        public string DateTime_ { get; set; }
	
	        /// <summary>
	        /// 时区
	        /// </summary>
	        [XmlElement("time_zone")]
	        public string TimeZone { get; set; }
}

	/// <summary>
/// ItemsDomain Data Structure.
/// </summary>
[Serializable]

public class ItemsDomain : TopObject
{
	        /// <summary>
	        /// 参与者,考虑性能问题，该字段不向外透出
	        /// </summary>
	        [XmlArray("attendees")]
	        [XmlArrayItem("attendees")]
	        public List<AttendeesDomain> Attendees { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("created")]
	        public DateTimeDomain Created { get; set; }
	
	        /// <summary>
	        /// 内容描述
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end")]
	        public DateTimeDomain End { get; set; }
	
	        /// <summary>
	        /// 日程事件id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 地点
	        /// </summary>
	        [XmlElement("location")]
	        public string Location { get; set; }
	
	        /// <summary>
	        /// 组织者
	        /// </summary>
	        [XmlElement("organizer")]
	        public UserDomain Organizer { get; set; }
	
	        /// <summary>
	        /// 循环的规则
	        /// </summary>
	        [XmlArray("recurrence")]
	        [XmlArrayItem("string")]
	        public List<string> Recurrence { get; set; }
	
	        /// <summary>
	        /// 循环日程中对应的序列id
	        /// </summary>
	        [XmlElement("recurrence_id")]
	        public string RecurrenceId { get; set; }
	
	        /// <summary>
	        /// 响应状态（accepted, declined, needsAction）
	        /// </summary>
	        [XmlElement("response_status")]
	        public string ResponseStatus { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start")]
	        public DateTimeDomain Start { get; set; }
	
	        /// <summary>
	        /// 状态（confirmed、cancelled）
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 标题简述
	        /// </summary>
	        [XmlElement("summary")]
	        public string Summary { get; set; }
	
	        /// <summary>
	        /// 日程的唯一ID, 周期日程的所有序列的unique_id为同一个
	        /// </summary>
	        [XmlElement("unique_id")]
	        public string UniqueId { get; set; }
	
	        /// <summary>
	        /// 最后一次更新时间
	        /// </summary>
	        [XmlElement("updated")]
	        public DateTimeDomain Updated { get; set; }
}

	/// <summary>
/// OpenCalendarListResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenCalendarListResponseDomain : TopObject
{
	        /// <summary>
	        /// 日程的实体
	        /// </summary>
	        [XmlArray("items")]
	        [XmlArrayItem("items")]
	        public List<ItemsDomain> Items { get; set; }
	
	        /// <summary>
	        /// 请求结果若还有更多，则返回下一页的token值
	        /// </summary>
	        [XmlElement("next_page_token")]
	        public string NextPageToken { get; set; }
	
	        /// <summary>
	        /// 文件夹描述
	        /// </summary>
	        [XmlElement("summary")]
	        public string Summary { get; set; }
}

    }
}
