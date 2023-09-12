using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduUserListResponse.
    /// </summary>
    public class OapiEduUserListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码，只有当success为false时才有效
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息，只有当success为false时才有效
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果值
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenEduUserDetailDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduUserDetailDomain : TopObject
{
	        /// <summary>
	        /// 班级id
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 人员各个身份属性
	        /// </summary>
	        [XmlElement("feature")]
	        public string Feature { get; set; }
	
	        /// <summary>
	        /// 创建时间，时间戳
	        /// </summary>
	        [XmlElement("gmtCreate")]
	        public long GmtCreate { get; set; }
	
	        /// <summary>
	        /// 修改时间，时间戳
	        /// </summary>
	        [XmlElement("gmtModified")]
	        public long GmtModified { get; set; }
	
	        /// <summary>
	        /// 在班级中的监护人名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 角色
	        /// </summary>
	        [XmlElement("role")]
	        public string Role { get; set; }
	
	        /// <summary>
	        /// unionid
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
	
	        /// <summary>
	        /// 人员id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 人员身份列表
	        /// </summary>
	        [XmlArray("details")]
	        [XmlArrayItem("open_edu_user_detail")]
	        public List<OpenEduUserDetailDomain> Details { get; set; }
	
	        /// <summary>
	        /// 是否还有数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
}

    }
}
