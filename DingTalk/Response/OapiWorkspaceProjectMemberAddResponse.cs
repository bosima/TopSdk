using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkspaceProjectMemberAddResponse.
    /// </summary>
    public class OapiWorkspaceProjectMemberAddResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误文案
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 项目成员
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("open_project_member_dto")]
        public List<OpenProjectMemberDtoDomain> Result { get; set; }

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
	        /// 角色的code
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 角色的名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// OpenProjectMemberDtoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenProjectMemberDtoDomain : TopObject
{
	        /// <summary>
	        /// 组织id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 从哪个组织选人
	        /// </summary>
	        [XmlElement("from_corp_id")]
	        public string FromCorpId { get; set; }
	
	        /// <summary>
	        /// 配合fromCorpId，在那个组织内的userid
	        /// </summary>
	        [XmlElement("from_user_id")]
	        public string FromUserId { get; set; }
	
	        /// <summary>
	        /// 角色
	        /// </summary>
	        [XmlArray("tags")]
	        [XmlArrayItem("open_tag_dto")]
	        public List<OpenTagDtoDomain> Tags { get; set; }
	
	        /// <summary>
	        /// 成员id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
