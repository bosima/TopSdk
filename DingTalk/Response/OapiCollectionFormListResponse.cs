using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCollectionFormListResponse.
    /// </summary>
    public class OapiCollectionFormListResponse : DingTalkResponse
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
	        /// 0表示通用智能填表，1表示教育版填表
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
/// FormSchemaResponseDomain Data Structure.
/// </summary>
[Serializable]

public class FormSchemaResponseDomain : TopObject
{
	        /// <summary>
	        /// 创建人
	        /// </summary>
	        [XmlElement("creator")]
	        public string Creator { get; set; }
	
	        /// <summary>
	        /// 表单code
	        /// </summary>
	        [XmlElement("form_code")]
	        public string FormCode { get; set; }
	
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
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否有下一页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("form_schema_response")]
	        public List<FormSchemaResponseDomain> List { get; set; }
	
	        /// <summary>
	        /// 下次分页的起始offset
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
