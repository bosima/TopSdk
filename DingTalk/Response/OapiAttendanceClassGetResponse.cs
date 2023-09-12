using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiAttendanceClassGetResponse.
    /// </summary>
    public class OapiAttendanceClassGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 异常错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回对象
        /// </summary>
        [XmlElement("result")]
        public AtClassForTopVoDomain Result { get; set; }

	/// <summary>
/// AtTimeVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtTimeVoDomain : TopObject
{
	        /// <summary>
	        /// 是否跨天
	        /// </summary>
	        [XmlElement("across")]
	        public long Across { get; set; }
	
	        /// <summary>
	        /// 允许开始分钟
	        /// </summary>
	        [XmlElement("begin_min")]
	        public long BeginMin { get; set; }
	
	        /// <summary>
	        /// 时间
	        /// </summary>
	        [XmlElement("check_time")]
	        public string CheckTime { get; set; }
	
	        /// <summary>
	        /// 打卡类型枚举（Onduty和OffDuty）
	        /// </summary>
	        [XmlElement("check_type")]
	        public string CheckType { get; set; }
	
	        /// <summary>
	        /// 允许结束分钟
	        /// </summary>
	        [XmlElement("end_min")]
	        public long EndMin { get; set; }
}

	/// <summary>
/// AtClassSettingForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtClassSettingForTopVoDomain : TopObject
{
	        /// <summary>
	        /// classId
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// classSettingId
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
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
/// AtSectionVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtSectionVoDomain : TopObject
{
	        /// <summary>
	        /// 时间段列表
	        /// </summary>
	        [XmlArray("times")]
	        [XmlArrayItem("at_time_vo")]
	        public List<AtTimeVoDomain> Times { get; set; }
}

	/// <summary>
/// AtClassForTopVoDomain Data Structure.
/// </summary>
[Serializable]

public class AtClassForTopVoDomain : TopObject
{
	        /// <summary>
	        /// 考勤组班次配置
	        /// </summary>
	        [XmlElement("class_setting")]
	        public AtClassSettingForTopVoDomain ClassSetting { get; set; }
	
	        /// <summary>
	        /// 组织id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// classid
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 组织名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 班次打卡时间段,最多
	        /// </summary>
	        [XmlArray("sections")]
	        [XmlArrayItem("at_section_vo")]
	        public List<AtSectionVoDomain> Sections { get; set; }
	
	        /// <summary>
	        /// 固定班次的工作日班次
	        /// </summary>
	        [XmlArray("work_days")]
	        [XmlArrayItem("number")]
	        public List<long> WorkDays { get; set; }
}

    }
}
