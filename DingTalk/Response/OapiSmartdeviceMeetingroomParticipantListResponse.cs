using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartdeviceMeetingroomParticipantListResponse.
    /// </summary>
    public class OapiSmartdeviceMeetingroomParticipantListResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误码信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public OpenPageResultDomain Result { get; set; }

	/// <summary>
/// MemeberOpenInfoDomain Data Structure.
/// </summary>
[Serializable]

public class MemeberOpenInfoDomain : TopObject
{
	        /// <summary>
	        /// 参会人userid
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// OpenPageResultDomain Data Structure.
/// </summary>
[Serializable]

public class OpenPageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否有下一页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public string NextCursor { get; set; }
	
	        /// <summary>
	        /// 参会人列表
	        /// </summary>
	        [XmlArray("participants")]
	        [XmlArrayItem("memeber_open_info")]
	        public List<MemeberOpenInfoDomain> Participants { get; set; }
}

    }
}
