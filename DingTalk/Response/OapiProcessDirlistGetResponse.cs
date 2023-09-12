using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiProcessDirlistGetResponse.
    /// </summary>
    public class OapiProcessDirlistGetResponse : DingTalkResponse
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
        /// 分组信息列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("result")]
        public List<ResultDomain> Result { get; set; }

        /// <summary>
        /// 系统状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 分组id
	        /// </summary>
	        [XmlElement("dir_id")]
	        public string DirId { get; set; }
	
	        /// <summary>
	        /// 分组名称
	        /// </summary>
	        [XmlElement("dir_name")]
	        public string DirName { get; set; }
}

    }
}
