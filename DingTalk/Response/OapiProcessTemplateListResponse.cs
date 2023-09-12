using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessTemplateListResponse.
    /// </summary>
    public class OapiProcessTemplateListResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public CorpTemplateVoDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// TemplatelistDomain Data Structure.
/// </summary>
[Serializable]

public class TemplatelistDomain : TopObject
{
	        /// <summary>
	        /// 是否可升级，加入收款账户组件
	        /// </summary>
	        [XmlElement("can_be_upgraded")]
	        public bool CanBeUpgraded { get; set; }
	
	        /// <summary>
	        /// 是否有管理权限
	        /// </summary>
	        [XmlElement("can_modify")]
	        public bool CanModify { get; set; }
	
	        /// <summary>
	        /// 模板内容
	        /// </summary>
	        [XmlElement("form_content")]
	        public string FormContent { get; set; }
	
	        /// <summary>
	        /// 模板图标url
	        /// </summary>
	        [XmlElement("icon_url")]
	        public string IconUrl { get; set; }
	
	        /// <summary>
	        /// 模板名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 模板code
	        /// </summary>
	        [XmlElement("process_code")]
	        public string ProcessCode { get; set; }
	
	        /// <summary>
	        /// 模板跳转地址
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// CorpTemplateVoDomain Data Structure.
/// </summary>
[Serializable]

public class CorpTemplateVoDomain : TopObject
{
	        /// <summary>
	        /// 下次调用时的offset入参
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("template_list")]
	        [XmlArrayItem("templatelist")]
	        public List<TemplatelistDomain> TemplateList { get; set; }
}

    }
}
