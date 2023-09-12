using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCollectionFormGetResponse.
    /// </summary>
    public class OapiCollectionFormGetResponse : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public PageResultDomain Result { get; set; }

	/// <summary>
/// ProcessVisibleValueVoDomain Data Structure.
/// </summary>
[Serializable]

public class ProcessVisibleValueVoDomain : TopObject
{
	        /// <summary>
	        /// 可见性类型 0部门 1人员 2角色 3群组cid
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
	
	        /// <summary>
	        /// 值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// FormSchemaSettingVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormSchemaSettingVoDomain : TopObject
{
	        /// <summary>
	        /// 表单类型
	        /// </summary>
	        [XmlElement("biz_type")]
	        public long BizType { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public string CreateTime { get; set; }
	
	        /// <summary>
	        /// 填表截止时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 是否循环填表
	        /// </summary>
	        [XmlElement("form_type")]
	        public long FormType { get; set; }
	
	        /// <summary>
	        /// 填表周期，周一到周日分别用1-7表示
	        /// </summary>
	        [XmlArray("loop_days")]
	        [XmlArrayItem("number")]
	        public List<long> LoopDays { get; set; }
	
	        /// <summary>
	        /// 填表时间
	        /// </summary>
	        [XmlElement("loop_time")]
	        public string LoopTime { get; set; }
	
	        /// <summary>
	        /// 应填人数
	        /// </summary>
	        [XmlElement("should_participation_cnt")]
	        public long ShouldParticipationCnt { get; set; }
	
	        /// <summary>
	        /// 填表是否终止的标记
	        /// </summary>
	        [XmlElement("stop")]
	        public bool Stop { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// schema
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 创建人
	        /// </summary>
	        [XmlElement("creator")]
	        public string Creator { get; set; }
	
	        /// <summary>
	        /// 填表提示
	        /// </summary>
	        [XmlElement("memo")]
	        public string Memo { get; set; }
	
	        /// <summary>
	        /// 填表名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 设置
	        /// </summary>
	        [XmlElement("setting")]
	        public FormSchemaSettingVoDomain Setting { get; set; }
	
	        /// <summary>
	        /// 应参与人数
	        /// </summary>
	        [XmlElement("should_participation_cnt")]
	        public long ShouldParticipationCnt { get; set; }
	
	        /// <summary>
	        /// 发送范围
	        /// </summary>
	        [XmlArray("visible_list")]
	        [XmlArrayItem("process_visible_value_vo")]
	        public List<ProcessVisibleValueVoDomain> VisibleList { get; set; }
}

    }
}
