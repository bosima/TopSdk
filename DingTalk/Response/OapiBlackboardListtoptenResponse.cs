using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiBlackboardListtoptenResponse.
    /// </summary>
    public class OapiBlackboardListtoptenResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlArray("blackboard_list")]
        [XmlArrayItem("oapi_blackboard_vo")]
        public List<OapiBlackboardVoDomain> BlackboardList { get; set; }

        /// <summary>
        /// errcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errmsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

	/// <summary>
/// OapiBlackboardVoDomain Data Structure.
/// </summary>
[Serializable]

public class OapiBlackboardVoDomain : TopObject
{
	        /// <summary>
	        /// 分类id
	        /// </summary>
	        [XmlElement("categoryId")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// 分类名称
	        /// </summary>
	        [XmlElement("categoryName")]
	        public string CategoryName { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 公告id
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 置顶公告标识。0为非置顶，1为置顶
	        /// </summary>
	        [XmlElement("isPushTop")]
	        public long IsPushTop { get; set; }
	
	        /// <summary>
	        /// 公告保密等级。0为非保密，20为保密
	        /// </summary>
	        [XmlElement("privateLevel")]
	        public long PrivateLevel { get; set; }
	
	        /// <summary>
	        /// 标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 跳转URL。参数解释：{2}：公告来源；{4}：企业corpId；{5}：公告id
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

    }
}
