using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiImChatScenegroupGetResponse.
    /// </summary>
    public class OapiImChatScenegroupGetResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public DecorationGroupQueryResponseDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ManagementOptionsDomain Data Structure.
/// </summary>
[Serializable]

public class ManagementOptionsDomain : TopObject
{
	        /// <summary>
	        /// 群禁言，0-默认，不禁言，1-全员禁言
	        /// </summary>
	        [XmlElement("chat_banned_type")]
	        public string ChatBannedType { get; set; }
	
	        /// <summary>
	        /// 管理类型，0-默认，所有人可管理，1-仅群主可管理
	        /// </summary>
	        [XmlElement("management_type")]
	        public string ManagementType { get; set; }
	
	        /// <summary>
	        /// @all 权限，0-默认，所有人，1-仅群主可@all
	        /// </summary>
	        [XmlElement("mention_all_authority")]
	        public string MentionAllAuthority { get; set; }
	
	        /// <summary>
	        /// 群可搜索，0-默认，不可搜索，1-可搜索
	        /// </summary>
	        [XmlElement("searchable")]
	        public string Searchable { get; set; }
	
	        /// <summary>
	        /// 新成员是否可查看聊天历史消息，0-默认，否，1-是
	        /// </summary>
	        [XmlElement("show_history_type")]
	        public string ShowHistoryType { get; set; }
	
	        /// <summary>
	        /// 入群验证，0：不入群验证（默认） 1：入群验证
	        /// </summary>
	        [XmlElement("validation_type")]
	        public string ValidationType { get; set; }
}

	/// <summary>
/// DecorationGroupQueryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DecorationGroupQueryResponseDomain : TopObject
{
	        /// <summary>
	        /// 入群链接（需特殊申请才返回）
	        /// </summary>
	        [XmlElement("group_url")]
	        public string GroupUrl { get; set; }
	
	        /// <summary>
	        /// 群头像
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 群配置
	        /// </summary>
	        [XmlElement("management_options")]
	        public ManagementOptionsDomain ManagementOptions { get; set; }
	
	        /// <summary>
	        /// 群成员数量
	        /// </summary>
	        [XmlElement("member_amount")]
	        public long MemberAmount { get; set; }
	
	        /// <summary>
	        /// 群id
	        /// </summary>
	        [XmlElement("open_conversation_id")]
	        public string OpenConversationId { get; set; }
	
	        /// <summary>
	        /// 群主id
	        /// </summary>
	        [XmlElement("owner_staff_id")]
	        public string OwnerStaffId { get; set; }
	
	        /// <summary>
	        /// 场景化数据，在特定场景群有数据
	        /// </summary>
	        [XmlElement("scene_data")]
	        public string SceneData { get; set; }
	
	        /// <summary>
	        /// 群管理id
	        /// </summary>
	        [XmlArray("sub_admin_staff_ids")]
	        [XmlArrayItem("string")]
	        public List<string> SubAdminStaffIds { get; set; }
	
	        /// <summary>
	        /// 模板id
	        /// </summary>
	        [XmlElement("template_id")]
	        public string TemplateId { get; set; }
	
	        /// <summary>
	        /// 群标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
