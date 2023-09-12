using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiLiveGroupliveViewrecordResponse.
    /// </summary>
    public class OapiLiveGroupliveViewrecordResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public QueryLiveViewRecordDetailDomain Result { get; set; }

	/// <summary>
/// UserViewRecordDetailModelListDomain Data Structure.
/// </summary>
[Serializable]

public class UserViewRecordDetailModelListDomain : TopObject
{
	        /// <summary>
	        /// 开始观看时间戳
	        /// </summary>
	        [XmlElement("live_begin_unix_time")]
	        public long LiveBeginUnixTime { get; set; }
	
	        /// <summary>
	        /// 结束观看时间戳
	        /// </summary>
	        [XmlElement("live_end_unix_time")]
	        public long LiveEndUnixTime { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("user_id")]
	        public string UserId { get; set; }
	
	        /// <summary>
	        /// 用户名
	        /// </summary>
	        [XmlElement("user_name")]
	        public string UserName { get; set; }
	
	        /// <summary>
	        /// 0：直播 1：回放
	        /// </summary>
	        [XmlElement("view_type")]
	        public long ViewType { get; set; }
	
	        /// <summary>
	        /// 观看时长，单位s
	        /// </summary>
	        [XmlElement("watch_time_second")]
	        public long WatchTimeSecond { get; set; }
}

	/// <summary>
/// QueryLiveViewRecordDetailDomain Data Structure.
/// </summary>
[Serializable]

public class QueryLiveViewRecordDetailDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 群名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
	
	        /// <summary>
	        /// 是否分页拉取完成，true：完成
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 直播uuid
	        /// </summary>
	        [XmlElement("live_uuid")]
	        public string LiveUuid { get; set; }
	
	        /// <summary>
	        /// 用户观看记录
	        /// </summary>
	        [XmlArray("record_list")]
	        [XmlArrayItem("user_view_record_detail_model_list")]
	        public List<UserViewRecordDetailModelListDomain> RecordList { get; set; }
	
	        /// <summary>
	        /// 直播标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

    }
}
