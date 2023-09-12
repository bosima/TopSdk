using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiConferenceGetResponse.
    /// </summary>
    public class OapiConferenceGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 服务调用结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 服务调用结果码描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 服务调用结果对象
        /// </summary>
        [XmlElement("result")]
        public ConferenceInfoDoDomain Result { get; set; }

	/// <summary>
/// ConferenceInfoDoDomain Data Structure.
/// </summary>
[Serializable]

public class ConferenceInfoDoDomain : TopObject
{
	        /// <summary>
	        /// 会务地点
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 会务管理员userid
	        /// </summary>
	        [XmlElement("admin_userid")]
	        public string AdminUserid { get; set; }
	
	        /// <summary>
	        /// 会务筹备者userid列表
	        /// </summary>
	        [XmlArray("arrange_userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> ArrangeUseridList { get; set; }
	
	        /// <summary>
	        /// 会务Id
	        /// </summary>
	        [XmlElement("conference_id")]
	        public string ConferenceId { get; set; }
	
	        /// <summary>
	        /// 会务简介
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 举办会务的企业Id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 会务创建者userid
	        /// </summary>
	        [XmlElement("create_userid")]
	        public string CreateUserid { get; set; }
	
	        /// <summary>
	        /// 会务结束时间，时间戳格式，单位为毫秒
	        /// </summary>
	        [XmlElement("end_time")]
	        public long EndTime { get; set; }
	
	        /// <summary>
	        /// 最近更新会务信息的userid
	        /// </summary>
	        [XmlElement("modified_userid")]
	        public string ModifiedUserid { get; set; }
	
	        /// <summary>
	        /// 高德经纬度，格式:longitude,latitude
	        /// </summary>
	        [XmlElement("poi")]
	        public string Poi { get; set; }
	
	        /// <summary>
	        /// 会务开始时间，时间戳格式，单位为毫秒
	        /// </summary>
	        [XmlElement("start_time")]
	        public long StartTime { get; set; }
	
	        /// <summary>
	        /// 会务状态，2 - 筹备中，3 - 已发布，10 - 已结束
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 会务主题
	        /// </summary>
	        [XmlElement("topic")]
	        public string Topic { get; set; }
	
	        /// <summary>
	        /// 会务主题图片地址
	        /// </summary>
	        [XmlElement("topic_pic_url")]
	        public string TopicPicUrl { get; set; }
	
	        /// <summary>
	        /// 会务类型，1 - 年会，2 - 沙龙
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
	
	        /// <summary>
	        /// 会务信息版本号，信息更新时进行递增
	        /// </summary>
	        [XmlElement("version")]
	        public long Version { get; set; }
}

    }
}
