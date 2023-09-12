using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCollectionInstanceGetResponse.
    /// </summary>
    public class OapiCollectionInstanceGetResponse : DingTalkResponse
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
        public FormInstanceVoDomain Result { get; set; }

	/// <summary>
/// FormDataDomain Data Structure.
/// </summary>
[Serializable]

public class FormDataDomain : TopObject
{
	        /// <summary>
	        /// 控件名
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 表单标签名
	        /// </summary>
	        [XmlElement("label")]
	        public string Label { get; set; }
	
	        /// <summary>
	        /// 表单值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// FormInstanceVoDomain Data Structure.
/// </summary>
[Serializable]

public class FormInstanceVoDomain : TopObject
{
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public string CreateTime { get; set; }
	
	        /// <summary>
	        /// 创建者userid
	        /// </summary>
	        [XmlElement("creator")]
	        public string Creator { get; set; }
	
	        /// <summary>
	        /// 表单code
	        /// </summary>
	        [XmlElement("form_code")]
	        public string FormCode { get; set; }
	
	        /// <summary>
	        /// 表单具体数据
	        /// </summary>
	        [XmlArray("form_list")]
	        [XmlArrayItem("form_data")]
	        public List<FormDataDomain> FormList { get; set; }
	
	        /// <summary>
	        /// 修改时间
	        /// </summary>
	        [XmlElement("modify_time")]
	        public string ModifyTime { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
