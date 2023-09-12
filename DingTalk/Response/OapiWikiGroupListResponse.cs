using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWikiGroupListResponse.
    /// </summary>
    public class OapiWikiGroupListResponse : DingTalkResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 对返回码的文本描述内容
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果数据
        /// </summary>
        [XmlElement("result")]
        public OpenPageResultDomain Result { get; set; }

        /// <summary>
        /// 是否操作成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenGroupVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenGroupVoDomain : TopObject
{
	        /// <summary>
	        /// 知识库的描述
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 知识库的图标
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 知识库ID（加密后的）
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 知识库的名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// OpenPageResultDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPageResultDomain : TopObject
{
	        /// <summary>
	        /// 组织内知识库列表
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("open_group_vo")]
	        public List<OpenGroupVoDomain> Data { get; set; }
	
	        /// <summary>
	        /// 是否还有更多的数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一次分页的游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
