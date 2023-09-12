using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavVideoconfDetailListResponse.
    /// </summary>
    public class OapiKacDatavVideoconfDetailListResponse : DingTalkResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public McsDetailResponseDomain Result { get; set; }

	/// <summary>
/// McsDetailVoDomain Data Structure.
/// </summary>
[Serializable]

public class McsDetailVoDomain : TopObject
{
	        /// <summary>
	        /// 会议id
	        /// </summary>
	        [XmlElement("conf_id")]
	        public string ConfId { get; set; }
	
	        /// <summary>
	        /// 会议时长（分钟）
	        /// </summary>
	        [XmlElement("conf_len_min")]
	        public string ConfLenMin { get; set; }
	
	        /// <summary>
	        /// 发起人部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 发起人部门
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 会议结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 参与人数
	        /// </summary>
	        [XmlElement("join_user_count")]
	        public long JoinUserCount { get; set; }
	
	        /// <summary>
	        /// 发起人工号
	        /// </summary>
	        [XmlElement("staff_job_num")]
	        public string StaffJobNum { get; set; }
	
	        /// <summary>
	        /// 发起人姓名
	        /// </summary>
	        [XmlElement("staff_name")]
	        public string StaffName { get; set; }
	
	        /// <summary>
	        /// 会议开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public string StartTime { get; set; }
	
	        /// <summary>
	        /// 员工在当前企业内的唯一标识，也称staffId。可由企业在创建时指定，并代表一定含义比如工号，创建后不可修改
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// McsDetailResponseDomain Data Structure.
/// </summary>
[Serializable]

public class McsDetailResponseDomain : TopObject
{
	        /// <summary>
	        /// data
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("mcs_detail_vo")]
	        public List<McsDetailVoDomain> Data { get; set; }
	
	        /// <summary>
	        /// 是否有下一页；true则存在更多分页
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 下一次请求的分页游标
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
