using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// SmartworkCheckinRecordGetResponse.
    /// </summary>
    public class SmartworkCheckinRecordGetResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// CheckinRecordVoDomain Data Structure.
/// </summary>
[Serializable]

public class CheckinRecordVoDomain : TopObject
{
	        /// <summary>
	        /// 签到时间,单位毫秒
	        /// </summary>
	        [XmlElement("checkin_time")]
	        public long CheckinTime { get; set; }
	
	        /// <summary>
	        /// 签到详细地址
	        /// </summary>
	        [XmlElement("detail_place")]
	        public string DetailPlace { get; set; }
	
	        /// <summary>
	        /// 签到照片url列表
	        /// </summary>
	        [XmlArray("image_list")]
	        [XmlArrayItem("string")]
	        public List<string> ImageList { get; set; }
	
	        /// <summary>
	        /// 签到位置维度（暂未开放）
	        /// </summary>
	        [XmlElement("latitude")]
	        public string Latitude { get; set; }
	
	        /// <summary>
	        /// 签到位置经度（暂未开放）
	        /// </summary>
	        [XmlElement("longitude")]
	        public string Longitude { get; set; }
	
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
	        /// 员工唯一标识
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 签到的拜访对象，可以为外部联系人的userid或者用户自己输入的名字
	        /// </summary>
	        [XmlElement("visit_user")]
	        public string VisitUser { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 表示下次查询的游标，为null代表没有更多的数据了
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
	
	        /// <summary>
	        /// 分页列表
	        /// </summary>
	        [XmlArray("page_list")]
	        [XmlArrayItem("checkin_record_vo")]
	        public List<CheckinRecordVoDomain> PageList { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// dingOpenErrcode
	        /// </summary>
	        [XmlElement("ding_open_errcode")]
	        public long DingOpenErrcode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlElement("result")]
	        public PageResultDomain Result { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
