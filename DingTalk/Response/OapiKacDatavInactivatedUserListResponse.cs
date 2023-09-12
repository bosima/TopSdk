using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiKacDatavInactivatedUserListResponse.
    /// </summary>
    public class OapiKacDatavInactivatedUserListResponse : DingTalkResponse
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
        /// 结果对象
        /// </summary>
        [XmlElement("result")]
        public UnactivatedUserResponseDomain Result { get; set; }

	/// <summary>
/// UnactivatedUserVoDomain Data Structure.
/// </summary>
[Serializable]

public class UnactivatedUserVoDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 部门名称
	        /// </summary>
	        [XmlElement("dept_name")]
	        public string DeptName { get; set; }
	
	        /// <summary>
	        /// 员工工号
	        /// </summary>
	        [XmlElement("staff_job_num")]
	        public string StaffJobNum { get; set; }
	
	        /// <summary>
	        /// 员工姓名
	        /// </summary>
	        [XmlElement("staff_name")]
	        public string StaffName { get; set; }
	
	        /// <summary>
	        /// 员工在当前企业内的唯一标识，也称staffId。可由企业在创建时指定，并代表一定含义比如工号，创建后不可修改
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// UnactivatedUserResponseDomain Data Structure.
/// </summary>
[Serializable]

public class UnactivatedUserResponseDomain : TopObject
{
	        /// <summary>
	        /// 人员列表
	        /// </summary>
	        [XmlArray("data")]
	        [XmlArrayItem("unactivated_user_vo")]
	        public List<UnactivatedUserVoDomain> Data { get; set; }
	
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
