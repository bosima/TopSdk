using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceProjectCreateV2Response.
    /// </summary>
    public class OapiWorkspaceProjectCreateV2Response : DingTalkResponse
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
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public OpenWorkspaceDtoDomain Result { get; set; }

        /// <summary>
        /// 创建项目成功
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
	        /// code
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// name
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
	        /// corpid
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 拥有者名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 拥有者标签
	        /// </summary>
	        [XmlArray("tags")]
	        [XmlArrayItem("open_tag_dto")]
	        public List<OpenTagDtoDomain> Tags { get; set; }
	
	        /// <summary>
	        /// userid
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
	        /// corpid
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// corp secret
	        /// </summary>
	        [XmlElement("corp_secret")]
	        public string CorpSecret { get; set; }
	
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
	        /// 描述
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 项目名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 关联ID
	        /// </summary>
	        [XmlElement("outer_id")]
	        public string OuterId { get; set; }
	
	        /// <summary>
	        /// 拥有者人
	        /// </summary>
	        [XmlElement("owner")]
	        public OpenMemberDtoDomain Owner { get; set; }
	
	        /// <summary>
	        /// 类型
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
}

    }
}
