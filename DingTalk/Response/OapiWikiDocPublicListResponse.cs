using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWikiDocPublicListResponse.
    /// </summary>
    public class OapiWikiDocPublicListResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public OpenPageResultDomain Result { get; set; }

        /// <summary>
        /// 是否操作成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OpenDocVoDomain Data Structure.
/// </summary>
[Serializable]

public class OpenDocVoDomain : TopObject
{
	        /// <summary>
	        /// 知识页所在知识库id（加密后的值）
	        /// </summary>
	        [XmlElement("group_id")]
	        public string GroupId { get; set; }
	
	        /// <summary>
	        /// 知识页ID（加密后的值）
	        /// </summary>
	        [XmlElement("id")]
	        public string Id { get; set; }
	
	        /// <summary>
	        /// 文档最近一次cp的url
	        /// </summary>
	        [XmlElement("latest_cp_url")]
	        public string LatestCpUrl { get; set; }
	
	        /// <summary>
	        /// 知识页的名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 知识页所在知识本id（加密后的值）
	        /// </summary>
	        [XmlElement("repo_id")]
	        public string RepoId { get; set; }
	
	        /// <summary>
	        /// 文档分享链接的url
	        /// </summary>
	        [XmlElement("share_url")]
	        public string ShareUrl { get; set; }
}

	/// <summary>
/// OpenPageResultDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPageResultDomain : TopObject
{
	        /// <summary>
	        /// 知识页列表
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("open_doc_vo")]
	        public List<OpenDocVoDomain> Data { get; set; }
	
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
