using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceUpdateResponse.
    /// </summary>
    public class OapiWorkspaceUpdateResponse : DingTalkResponse
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
        /// 更新后的结果
        /// </summary>
        [XmlElement("result")]
        public OpenWorkspaceDtoDomain Result { get; set; }

        /// <summary>
        /// 请求成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenTagDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenTagDtoDomain : TopObject
{
	        /// <summary>
	        /// 角色code
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 角色名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// OpenMemberDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenMemberDtoDomain : TopObject
{
	        /// <summary>
	        /// 项目corpid
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 角色
	        /// </summary>
	        [XmlArray("tags")]
	        [XmlArrayItem("open_tag_dto")]
	        public List<OpenTagDtoDomain> Tags { get; set; }
	
	        /// <summary>
	        /// 项目组织内userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenWorkspaceDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenWorkspaceDtoDomain : TopObject
{
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public long CreateTime { get; set; }
	
	        /// <summary>
	        /// 创建人
	        /// </summary>
	        [XmlElement("creator")]
	        public OpenMemberDtoDomain Creator { get; set; }
	
	        /// <summary>
	        /// 项目描述
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 项目名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 外部系统id
	        /// </summary>
	        [XmlElement("outer_id")]
	        public string OuterId { get; set; }
	
	        /// <summary>
	        /// 管理员（负责人）
	        /// </summary>
	        [XmlElement("owner")]
	        public OpenMemberDtoDomain Owner { get; set; }
	
	        /// <summary>
	        /// 1项目 2圈子
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
}

    }
}
