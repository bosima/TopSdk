using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCollectionInstanceListResponse.
    /// </summary>
    public class OapiCollectionInstanceListResponse : DingTalkResponse
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
/// FormDataDomain Data Structure.
/// </summary>
[Serializable]

public class FormDataDomain : TopObject
{
	        /// <summary>
	        /// 表单控件key
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 名称。当label字段为空或不存在时，忽略这个label和value
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// 表单的值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// FormInstanceResponseDomain Data Structure.
/// </summary>
[Serializable]

public class FormInstanceResponseDomain : TopObject
{
	        /// <summary>
	        /// 毫秒级时间戳，填表提交时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public string CreateTime { get; set; }
	
	        /// <summary>
	        /// 实例id
	        /// </summary>
	        [XmlElement("form_instance_id")]
	        public string FormInstanceId { get; set; }
	
	        /// <summary>
	        /// 表单内容列表
	        /// </summary>
	        [XmlArray("forms")]
	        [XmlArrayItem("form_data")]
	        public List<FormDataDomain> Forms { get; set; }
	
	        /// <summary>
	        /// 更新时间
	        /// </summary>
	        [XmlElement("modify_time")]
	        public string ModifyTime { get; set; }
	
	        /// <summary>
	        /// 学生班级id
	        /// </summary>
	        [XmlElement("student_class_id")]
	        public long StudentClassId { get; set; }
	
	        /// <summary>
	        /// 学生班级名称
	        /// </summary>
	        [XmlElement("student_class_name")]
	        public string StudentClassName { get; set; }
	
	        /// <summary>
	        /// 学生名称
	        /// </summary>
	        [XmlElement("student_name")]
	        public string StudentName { get; set; }
	
	        /// <summary>
	        /// 学生id
	        /// </summary>
	        [XmlElement("student_user_id")]
	        public string StudentUserId { get; set; }
	
	        /// <summary>
	        /// 提交人姓名
	        /// </summary>
	        [XmlElement("submitter_user_name")]
	        public string SubmitterUserName { get; set; }
	
	        /// <summary>
	        /// 提交人userid
	        /// </summary>
	        [XmlElement("submitter_userid")]
	        public string SubmitterUserid { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否还有下一页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("form_instance_response")]
	        public List<FormInstanceResponseDomain> List { get; set; }
	
	        /// <summary>
	        /// 下一次分页offset的值
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
