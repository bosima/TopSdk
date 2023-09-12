using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRobotMessageStatisticsListbyconversationidResponse.
    /// </summary>
    public class OapiRobotMessageStatisticsListbyconversationidResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误值
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public RobotMsgStatPageResponseDomain Result { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// MsgStatByCIdResVoDomain Data Structure.
/// </summary>
[Serializable]

public class MsgStatByCIdResVoDomain : TopObject
{
	        /// <summary>
	        /// 群Id
	        /// </summary>
	        [XmlElement("conversation_id")]
	        public string ConversationId { get; set; }
	
	        /// <summary>
	        /// 钉钉id
	        /// </summary>
	        [XmlElement("dingtalk_id")]
	        public string DingtalkId { get; set; }
	
	        /// <summary>
	        /// 成员名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 机器人消息推送Id
	        /// </summary>
	        [XmlElement("push_id")]
	        public string PushId { get; set; }
	
	        /// <summary>
	        /// 是否已读
	        /// </summary>
	        [XmlElement("read_status")]
	        public bool ReadStatus { get; set; }
}

	/// <summary>
/// PaginationVoDomain Data Structure.
/// </summary>
[Serializable]

public class PaginationVoDomain : TopObject
{
	        /// <summary>
	        /// 当前页数
	        /// </summary>
	        [XmlElement("current_page")]
	        public long CurrentPage { get; set; }
	
	        /// <summary>
	        /// 总页数
	        /// </summary>
	        [XmlElement("total_page")]
	        public long TotalPage { get; set; }
	
	        /// <summary>
	        /// 总记录数
	        /// </summary>
	        [XmlElement("total_record_num")]
	        public long TotalRecordNum { get; set; }
}

	/// <summary>
/// RobotMsgStatPageResponseDomain Data Structure.
/// </summary>
[Serializable]

public class RobotMsgStatPageResponseDomain : TopObject
{
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("msg_stat_by_c_id_res_vo")]
	        public List<MsgStatByCIdResVoDomain> List { get; set; }
	
	        /// <summary>
	        /// pagination
	        /// </summary>
	        [XmlElement("pagination")]
	        public PaginationVoDomain Pagination { get; set; }
}

    }
}
