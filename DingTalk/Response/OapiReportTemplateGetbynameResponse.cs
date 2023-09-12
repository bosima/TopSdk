using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiReportTemplateGetbynameResponse.
    /// </summary>
    public class OapiReportTemplateGetbynameResponse : DingTalkResponse
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ReportTemplateResponseVoDomain Result { get; set; }

	/// <summary>
/// DefaultReceiversDomain Data Structure.
/// </summary>
[Serializable]

public class DefaultReceiversDomain : TopObject
{
	        /// <summary>
	        /// 默认接收人名称
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 默认接收人员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// FieldsDomain Data Structure.
/// </summary>
[Serializable]

public class FieldsDomain : TopObject
{
	        /// <summary>
	        /// 模板字段名称
	        /// </summary>
	        [XmlElement("field_name")]
	        public string FieldName { get; set; }
	
	        /// <summary>
	        /// 模板字段唯一标识
	        /// </summary>
	        [XmlElement("sort")]
	        public long Sort { get; set; }
	
	        /// <summary>
	        /// 字段类型
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
}

	/// <summary>
/// BaseConversationVoDomain Data Structure.
/// </summary>
[Serializable]

public class BaseConversationVoDomain : TopObject
{
	        /// <summary>
	        /// 默认接收群id
	        /// </summary>
	        [XmlElement("conversation_id")]
	        public string ConversationId { get; set; }
	
	        /// <summary>
	        /// 群名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// ReportTemplateResponseVoDomain Data Structure.
/// </summary>
[Serializable]

public class ReportTemplateResponseVoDomain : TopObject
{
	        /// <summary>
	        /// 默认接收群
	        /// </summary>
	        [XmlArray("default_received_convs")]
	        [XmlArrayItem("base_conversation_vo")]
	        public List<BaseConversationVoDomain> DefaultReceivedConvs { get; set; }
	
	        /// <summary>
	        /// 模板默认接收人
	        /// </summary>
	        [XmlArray("default_receivers")]
	        [XmlArrayItem("default_receivers")]
	        public List<DefaultReceiversDomain> DefaultReceivers { get; set; }
	
	        /// <summary>
	        /// 模板字段
	        /// </summary>
	        [XmlArray("fields")]
	        [XmlArrayItem("fields")]
	        public List<FieldsDomain> Fields { get; set; }
	
	        /// <summary>
	        /// 模板id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 模板名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 用户名称
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
