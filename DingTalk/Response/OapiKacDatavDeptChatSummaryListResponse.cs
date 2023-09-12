using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavDeptChatSummaryListResponse.
    /// </summary>
    public class OapiKacDatavDeptChatSummaryListResponse : DingTalkResponse
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
        /// resut
        /// </summary>
        [XmlElement("result")]
        public ImDeptSummaryResponseDomain Result { get; set; }

	/// <summary>
/// ImDeptSummaryVoDomain Data Structure.
/// </summary>
[Serializable]

public class ImDeptSummaryVoDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 最近天一天群聊消息数
	        /// </summary>
	        [XmlElement("group_message_cnt")]
	        public long GroupMessageCnt { get; set; }
	
	        /// <summary>
	        /// 最近1天发送群文件数
	        /// </summary>
	        [XmlElement("group_send_file_message_cnt")]
	        public string GroupSendFileMessageCnt { get; set; }
	
	        /// <summary>
	        /// 最近1天发消息数
	        /// </summary>
	        [XmlElement("message_cnt")]
	        public long MessageCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天群聊消息人数
	        /// </summary>
	        [XmlElement("send_group_message_user_cnt")]
	        public long SendGroupMessageUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天人均发送消息数
	        /// </summary>
	        [XmlElement("send_message_avg_cnt")]
	        public string SendMessageAvgCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天发消息人数
	        /// </summary>
	        [XmlElement("send_message_user_cnt")]
	        public long SendMessageUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天单聊消息人数
	        /// </summary>
	        [XmlElement("send_single_message_user_cnt")]
	        public long SendSingleMessageUserCnt { get; set; }
	
	        /// <summary>
	        /// 最近一天单聊消息数
	        /// </summary>
	        [XmlElement("single_message_cnt")]
	        public long SingleMessageCnt { get; set; }
}

	/// <summary>
/// ImDeptSummaryResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ImDeptSummaryResponseDomain : TopObject
{
	        /// <summary>
	        /// data
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("im_dept_summary_vo")]
	        public List<ImDeptSummaryVoDomain> Data { get; set; }
	
	        /// <summary>
	        /// 是否有下一页；true则存在更多分页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一次请求的分页游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
