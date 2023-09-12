using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCustomerserviceActionQueryResponse.
    /// </summary>
    public class OapiCustomerserviceActionQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// TicketFieldDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TicketFieldDtoDomain : TopObject
{
	        /// <summary>
	        /// 标签名
	        /// </summary>
	        [XmlElement("display_name")]
	        public string DisplayName { get; set; }
	
	        /// <summary>
	        /// 标签值
	        /// </summary>
	        [XmlElement("display_value")]
	        public string DisplayValue { get; set; }
	
	        /// <summary>
	        /// 键
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 值
	        /// </summary>
	        [XmlElement("value")]
	        public string Value { get; set; }
	
	        /// <summary>
	        /// 附件类型
	        /// </summary>
	        [XmlElement("value_type")]
	        public string ValueType { get; set; }
}

	/// <summary>
/// TicketActionDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TicketActionDtoDomain : TopObject
{
	        /// <summary>
	        /// 动作表单字段列表
	        /// </summary>
	        [XmlArray("action_content")]
	        [XmlArrayItem("ticket_field_dto")]
	        public List<TicketFieldDtoDomain> ActionContent { get; set; }
	
	        /// <summary>
	        /// 执行人
	        /// </summary>
	        [XmlElement("operator")]
	        public string Operator { get; set; }
	
	        /// <summary>
	        /// 创建者1；客服 4；
	        /// </summary>
	        [XmlElement("operator_role")]
	        public string OperatorRole { get; set; }
}

	/// <summary>
/// PageQueryCursorResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageQueryCursorResultDomain : TopObject
{
	        /// <summary>
	        /// 动作列表
	        /// </summary>
	        [XmlArray("action_list")]
	        [XmlArrayItem("ticket_action_dto")]
	        public List<TicketActionDtoDomain> ActionList { get; set; }
	
	        /// <summary>
	        /// 还有数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一页的游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
	
	        /// <summary>
	        /// 总数
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("errcode")]
	        public long Errcode { get; set; }
	
	        /// <summary>
	        /// 文案
	        /// </summary>
	        [XmlElement("errmsg")]
	        public string Errmsg { get; set; }
	
	        /// <summary>
	        /// 分页查询结果
	        /// </summary>
	        [XmlElement("result")]
	        public PageQueryCursorResultDomain Result { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
