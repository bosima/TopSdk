using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduClassListbyteacherResponse.
    /// </summary>
    public class OapiEduClassListbyteacherResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误编码
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
        [XmlArray("result")]
        [XmlArrayItem("result")]
        public List<ResultDomain> Result { get; set; }

        /// <summary>
        /// 成功状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ConversationInfoDomain Data Structure.
/// </summary>
[Serializable]

public class ConversationInfoDomain : TopObject
{
	        /// <summary>
	        /// 班级群名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 群类型，officialClassGroup: 家校群; teacherStudentGroup: 师生群
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 部门ID
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 群信息列表
	        /// </summary>
	        [XmlArray("conversation_list")]
	        [XmlArrayItem("conversation_info")]
	        public List<ConversationInfoDomain> ConversationList { get; set; }
	
	        /// <summary>
	        /// 每个班级的corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 班级学生人数
	        /// </summary>
	        [XmlElement("count")]
	        public long Count { get; set; }
	
	        /// <summary>
	        /// 是否毕业班
	        /// </summary>
	        [XmlElement("graduate")]
	        public bool Graduate { get; set; }
	
	        /// <summary>
	        /// 班级名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 父部门ID
	        /// </summary>
	        [XmlElement("super_id")]
	        public long SuperId { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 不再过滤群类型
	        /// </summary>
	        [XmlElement("warning")]
	        public string Warning { get; set; }
}

    }
}
