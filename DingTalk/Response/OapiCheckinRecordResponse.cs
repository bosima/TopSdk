using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCheckinRecordResponse.
    /// </summary>
    public class OapiCheckinRecordResponse : DingTalkResponse
    {
        /// <summary>
        /// data
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("data")]
        public List<DataDomain> Data { get; set; }

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
/// DataDomain Data Structure.
/// </summary>
[Serializable]

public class DataDomain : TopObject
{
	        /// <summary>
	        /// 头像url
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// 签到详细地址
	        /// </summary>
	        [XmlElement("detailPlace")]
	        public string DetailPlace { get; set; }
	
	        /// <summary>
	        /// 签到照片url列表
	        /// </summary>
	        [XmlArray("imageList")]
	        [XmlArrayItem("string")]
	        public List<string> ImageList { get; set; }
	
	        /// <summary>
	        /// 纬度
	        /// </summary>
	        [XmlElement("latitude")]
	        public string Latitude { get; set; }
	
	        /// <summary>
	        /// 经度
	        /// </summary>
	        [XmlElement("longitude")]
	        public string Longitude { get; set; }
	
	        /// <summary>
	        /// 成员名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 签到地址
	        /// </summary>
	        [XmlElement("place")]
	        public string Place { get; set; }
	
	        /// <summary>
	        /// 签到备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 签到时间
	        /// </summary>
	        [XmlElement("timestamp")]
	        public long Timestamp { get; set; }
	
	        /// <summary>
	        /// 员工唯一标识ID（不可修改）
	        /// </summary>
	        [XmlElement("userId")]
	        public string UserId { get; set; }
}

    }
}
