using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCardTaskTodayListResponse.
    /// </summary>
    public class OapiEduCardTaskTodayListResponse : DingTalkResponse
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
        /// 返回数据
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("card_task_d_t_o")]
        public List<CardTaskDTODomain> Result { get; set; }

        /// <summary>
        /// 表示结果是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CardTaskDTODomain Data Structure.
/// </summary>
[Serializable]

public class CardTaskDTODomain : TopObject
{
	        /// <summary>
	        /// 卡片id
	        /// </summary>
	        [XmlElement("card_id")]
	        public long CardId { get; set; }
	
	        /// <summary>
	        /// 班级名称
	        /// </summary>
	        [XmlElement("class_name")]
	        public string ClassName { get; set; }
	
	        /// <summary>
	        /// 打卡内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 打卡日期
	        /// </summary>
	        [XmlElement("date")]
	        public string Date { get; set; }
	
	        /// <summary>
	        /// 是否完成打卡 N当日未完成打卡  Y完成打卡
	        /// </summary>
	        [XmlElement("is_finish_task")]
	        public string IsFinishTask { get; set; }
	
	        /// <summary>
	        /// 学生名字
	        /// </summary>
	        [XmlElement("student_name")]
	        public string StudentName { get; set; }
	
	        /// <summary>
	        /// 打卡任务名字
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 任务id
	        /// </summary>
	        [XmlElement("user_card_task_id")]
	        public long UserCardTaskId { get; set; }
}

    }
}
