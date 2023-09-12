using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCustomerserviceTicketQueryResponse.
    /// </summary>
    public class OapiCustomerserviceTicketQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// TicketBaseDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TicketBaseDtoDomain : TopObject
{
	        /// <summary>
	        /// 新建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 最新修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 模板id
	        /// </summary>
	        [XmlElement("template_id")]
	        public string TemplateId { get; set; }
	
	        /// <summary>
	        /// 工单id
	        /// </summary>
	        [XmlElement("ticket_id")]
	        public string TicketId { get; set; }
	
	        /// <summary>
	        /// 工单状态
	        /// </summary>
	        [XmlElement("ticket_status")]
	        public string TicketStatus { get; set; }
	
	        /// <summary>
	        /// 工单标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// PageQueryCursorResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageQueryCursorResultDomain : TopObject
{
	        /// <summary>
	        /// 是否有更多数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一次分页的游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
	
	        /// <summary>
	        /// 工单列表
	        /// </summary>
	        [XmlArray("ticket_list")]
	        [XmlArrayItem("ticket_base_dto")]
	        public List<TicketBaseDtoDomain> TicketList { get; set; }
	
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
	        /// 错误吗
	        /// </summary>
	        [XmlElement("errcode")]
	        public long Errcode { get; set; }
	
	        /// <summary>
	        /// 错误消息
	        /// </summary>
	        [XmlElement("errmsg")]
	        public string Errmsg { get; set; }
	
	        /// <summary>
	        /// 分页结果对象
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
