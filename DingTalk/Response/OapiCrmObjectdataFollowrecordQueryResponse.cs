using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmObjectdataFollowrecordQueryResponse.
    /// </summary>
    public class OapiCrmObjectdataFollowrecordQueryResponse : DingTalkResponse
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
        /// 分页结果
        /// </summary>
        [XmlElement("result")]
        public IterablePageDomain Result { get; set; }

	/// <summary>
/// DataPermissionVoDomain Data Structure.
/// </summary>
[Serializable]

public class DataPermissionVoDomain : TopObject
{
	        /// <summary>
	        /// 负责人用户ID列表
	        /// </summary>
	        [XmlArray("owner_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> OwnerUseridList { get; set; }
	
	        /// <summary>
	        /// 协同人用户ID列表
	        /// </summary>
	        [XmlArray("participant_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> ParticipantUseridList { get; set; }
}

	/// <summary>
/// ValuesDomain Data Structure.
/// </summary>
[Serializable]

public class ValuesDomain : TopObject
{
	        /// <summary>
	        /// 创建记录的用户昵称
	        /// </summary>
	        [XmlElement("creator_nick")]
	        public string CreatorNick { get; set; }
	
	        /// <summary>
	        /// 创建记录的用户ID
	        /// </summary>
	        [XmlElement("creator_userid")]
	        public string CreatorUserid { get; set; }
	
	        /// <summary>
	        /// 数据内容
	        /// </summary>
	        [XmlElement("data")]
	        public string Data { get; set; }
	
	        /// <summary>
	        /// 扩展数据内容
	        /// </summary>
	        [XmlElement("extend_data")]
	        public string ExtendData { get; set; }
	
	        /// <summary>
	        /// 记录创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 记录修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 数据ID
	        /// </summary>
	        [XmlElement("instance_id")]
	        public string InstanceId { get; set; }
	
	        /// <summary>
	        /// 数据类型
	        /// </summary>
	        [XmlElement("object_type")]
	        public string ObjectType { get; set; }
	
	        /// <summary>
	        /// 数据权限信息
	        /// </summary>
	        [XmlElement("permission")]
	        public DataPermissionVoDomain Permission { get; set; }
	
	        /// <summary>
	        /// 审批状态
	        /// </summary>
	        [XmlElement("proc_inst_status")]
	        public string ProcInstStatus { get; set; }
	
	        /// <summary>
	        /// 审批结果
	        /// </summary>
	        [XmlElement("proc_out_result")]
	        public string ProcOutResult { get; set; }
}

	/// <summary>
/// IterablePageDomain Data Structure.
/// </summary>
[Serializable]

public class IterablePageDomain : TopObject
{
	        /// <summary>
	        /// 是否有下一页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一页的游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
	
	        /// <summary>
	        /// 分页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 数据列表
	        /// </summary>
	        [XmlArray("values")]
	        [XmlArrayItem("values")]
	        public List<ValuesDomain> Values { get; set; }
}

    }
}
