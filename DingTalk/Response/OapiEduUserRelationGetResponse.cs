using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduUserRelationGetResponse.
    /// </summary>
    public class OapiEduUserRelationGetResponse : DingTalkResponse
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
        /// 关系详情
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenEduUserRelationDetailDomain Data Structure.
/// </summary>
[Serializable]

public class OpenEduUserRelationDetailDomain : TopObject
{
	        /// <summary>
	        /// 班级id
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 监护人id
	        /// </summary>
	        [XmlElement("from_userid")]
	        public string FromUserid { get; set; }
	
	        /// <summary>
	        /// 关系code
	        /// </summary>
	        [XmlElement("relation_code")]
	        public string RelationCode { get; set; }
	
	        /// <summary>
	        /// 关系名
	        /// </summary>
	        [XmlElement("relation_name")]
	        public string RelationName { get; set; }
	
	        /// <summary>
	        /// 学生id
	        /// </summary>
	        [XmlElement("to_userid")]
	        public string ToUserid { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 关系详情列表
	        /// </summary>
	        [XmlArray("relations")]
	        [XmlArrayItem("open_edu_user_relation_detail")]
	        public List<OpenEduUserRelationDetailDomain> Relations { get; set; }
}

    }
}
