using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduCampusListResponse.
    /// </summary>
    public class OapiEduCampusListResponse : DingTalkResponse
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
        /// result
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("campus_response")]
        public List<CampusResponseDomain> Result { get; set; }

        /// <summary>
        /// 成功状态
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// CampusResponseDomain Data Structure.
/// </summary>
[Serializable]

public class CampusResponseDomain : TopObject
{
	        /// <summary>
	        /// 校区ID
	        /// </summary>
	        [XmlElement("campus_id")]
	        public long CampusId { get; set; }
	
	        /// <summary>
	        /// 校区名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 校区别名
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
}

    }
}
