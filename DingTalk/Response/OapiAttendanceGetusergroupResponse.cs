using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceGetusergroupResponse.
    /// </summary>
    public class OapiAttendanceGetusergroupResponse : DingTalkResponse
    {
        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public AtGroupFullForTopVoDomain Result { get; set; }

	/// <summary>
/// AtTimeVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtTimeVoDomain : TopObject
{
	        /// <summary>
	        /// 打卡时间跨几天
	        /// </summary>
	        [XmlElement("across")]
	        public long Across { get; set; }
	
	        /// <summary>
	        /// 允许的最早提前打卡时间，分钟为单位
	        /// </summary>
	        [XmlElement("begin_min")]
	        public long BeginMin { get; set; }
	
	        /// <summary>
	        /// 打卡时间
	        /// </summary>
	        [XmlElement("check_time")]
	        public string CheckTime { get; set; }
	
	        /// <summary>
	        /// 打卡类型OnDuty：上班，OffDuty：下班
	        /// </summary>
	        [XmlElement("check_type")]
	        public string CheckType { get; set; }
	
	        /// <summary>
	        /// 允许的最晚延后打卡时间，分钟为单位
	        /// </summary>
	        [XmlElement("end_min")]
	        public long EndMin { get; set; }
}

	/// <summary>
/// AtSectionVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtSectionVoDomain : TopObject
{
	        /// <summary>
	        /// 班次中上下班详情列表
	        /// </summary>
	        [XmlArray("times")]
	        [XmlArrayItem("at_time_vo")]
	        public List<AtTimeVoDomain> Times { get; set; }
}

	/// <summary>
/// ClassSettingVoDomain Data Structure.
/// </summary>
[Serializable]

public class ClassSettingVoDomain : TopObject
{
	        /// <summary>
	        /// 休息开始时间
	        /// </summary>
	        [XmlElement("rest_begin_time")]
	        public AtTimeVoDomain RestBeginTime { get; set; }
	
	        /// <summary>
	        /// 休息结束时间
	        /// </summary>
	        [XmlElement("rest_end_time")]
	        public AtTimeVoDomain RestEndTime { get; set; }
}

	/// <summary>
/// AtClassVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtClassVoDomain : TopObject
{
	        /// <summary>
	        /// 班次id
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 班次名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 班次中上下班列表
	        /// </summary>
	        [XmlArray("sections")]
	        [XmlArrayItem("at_section_vo")]
	        public List<AtSectionVoDomain> Sections { get; set; }
	
	        /// <summary>
	        /// 班次配置
	        /// </summary>
	        [XmlElement("setting")]
	        public ClassSettingVoDomain Setting { get; set; }
}

	/// <summary>
/// AtGroupFullForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtGroupFullForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 考勤组中的班次列表
	        /// </summary>
	        [XmlArray("classes")]
	        [XmlArrayItem("at_class_vo")]
	        public List<AtClassVoDomain> Classes { get; set; }
	
	        /// <summary>
	        /// 考勤组id
	        /// </summary>
	        [XmlElement("group_id")]
	        public long GroupId { get; set; }
	
	        /// <summary>
	        /// 考勤组名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 考勤组类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

    }
}
