using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessBizsuiteGetResponse.
    /// </summary>
    public class OapiProcessBizsuiteGetResponse : DingTalkResponse
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
        /// 出参
        /// </summary>
        [XmlElement("result")]
        public BaseSuiteResponseDomain Result { get; set; }

        /// <summary>
        /// 成功失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// FormDataResponseVODomain Data Structure.
/// </summary>
[Serializable]

public class FormDataResponseVODomain : TopObject
{
	        /// <summary>
	        /// 表单组件别名
	        /// </summary>
	        [XmlElement("biz_alias")]
	        public string BizAlias { get; set; }
	
	        /// <summary>
	        /// 表单组件扩展字段
	        /// </summary>
	        [XmlElement("extend_value")]
	        public string ExtendValue { get; set; }
	
	        /// <summary>
	        /// 表单组件key
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 表单组件标签
	        /// </summary>
	        [XmlElement("lable")]
	        public string Lable { get; set; }
	
	        /// <summary>
	        /// 表单组件值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
}

	/// <summary>
/// BaseSuiteResponseDomain Data Structure.
/// </summary>
[Serializable]

public class BaseSuiteResponseDomain : TopObject
{
	        /// <summary>
	        /// 组件属性值
	        /// </summary>
	        [XmlArray("form_data_list")]
	        [XmlArrayItem("form_data_response_v_o")]
	        public List<FormDataResponseVODomain> FormDataList { get; set; }
	
	        /// <summary>
	        /// 组件属性值
	        /// </summary>
	        [XmlElement("seq_id")]
	        public long SeqId { get; set; }
}

    }
}
