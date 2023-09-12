using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiIndustryUserListResponse.
    /// </summary>
    public class OapiIndustryUserListResponse : DingTalkResponse
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
        public ResultWrapperDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenRoleDomain Data Structure.
/// </summary>
[Serializable]

public class OpenRoleDomain : TopObject
{
	        /// <summary>
	        /// 标签id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 标签名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// OpenIndustryEmpDomain Data Structure.
/// </summary>
[Serializable]

public class OpenIndustryEmpDomain : TopObject
{
	        /// <summary>
	        /// 员工特征
	        /// </summary>
	        [XmlElement("feature")]
	        public string Feature { get; set; }
	
	        /// <summary>
	        /// 员工名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 标签列表
	        /// </summary>
	        [XmlArray("roles")]
	        [XmlArrayItem("open_role")]
	        public List<OpenRoleDomain> Roles { get; set; }
	
	        /// <summary>
	        /// 钉钉唯一标示
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// ResultWrapperDomain Data Structure.
/// </summary>
[Serializable]

public class ResultWrapperDomain : TopObject
{
	        /// <summary>
	        /// 员工列表
	        /// </summary>
	        [XmlArray("details")]
	        [XmlArrayItem("open_industry_emp")]
	        public List<OpenIndustryEmpDomain> Details { get; set; }
	
	        /// <summary>
	        /// 是否有更多
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 游标位置
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
