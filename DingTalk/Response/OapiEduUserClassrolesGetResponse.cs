using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiEduUserClassrolesGetResponse.
    /// </summary>
    public class OapiEduUserClassrolesGetResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public DingOpenResultDomain Result { get; set; }

	/// <summary>
/// OpenOrgLocationDomain Data Structure.
/// </summary>
[Serializable]

public class OpenOrgLocationDomain : TopObject
{
	        /// <summary>
	        /// 学校所在市名称(如果有)
	        /// </summary>
	        [XmlElement("org_loc_city")]
	        public string OrgLocCity { get; set; }
	
	        /// <summary>
	        /// 学校所在省名称(如果有)
	        /// </summary>
	        [XmlElement("org_loc_province")]
	        public string OrgLocProvince { get; set; }
	
	        /// <summary>
	        /// 学校所在区名称(如果有)
	        /// </summary>
	        [XmlElement("org_loc_region")]
	        public string OrgLocRegion { get; set; }
	
	        /// <summary>
	        /// 学校所在地区编码(如果有)
	        /// </summary>
	        [XmlElement("region_id")]
	        public string RegionId { get; set; }
}

	/// <summary>
/// UserclassrolelistDomain Data Structure.
/// </summary>
[Serializable]

public class UserclassrolelistDomain : TopObject
{
	        /// <summary>
	        /// 所在班级ID
	        /// </summary>
	        [XmlElement("class_id")]
	        public long ClassId { get; set; }
	
	        /// <summary>
	        /// 班级名称
	        /// </summary>
	        [XmlElement("class_name")]
	        public string ClassName { get; set; }
	
	        /// <summary>
	        /// 组织id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 所在班级的姓名( 如果当前用户在班上为老师，则为老师姓名 ;如果当前用户在班上为家长， 则为孩子的学生姓名; 如果当前用户在班上为学生，则为学生姓名 )
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 学校的地址信息(如果有)
	        /// </summary>
	        [XmlElement("org_location")]
	        public OpenOrgLocationDomain OrgLocation { get; set; }
	
	        /// <summary>
	        /// 学校名称(如果有)
	        /// </summary>
	        [XmlElement("org_name")]
	        public string OrgName { get; set; }
	
	        /// <summary>
	        /// 所在班级的角色(学生:student，老师: teacher)
	        /// </summary>
	        [XmlElement("role_name")]
	        public string RoleName { get; set; }
	
	        /// <summary>
	        /// 所在班级的员工ID。 如果当前用户在班上为老师， 则为老师的员工ID; 如果当前用户在班上为家长， 则为孩子的学生员工ID; 如果当前用户在班上为学生， 则为学生的员工ID
	        /// </summary>
	        [XmlElement("user_id")]
	        public string UserId { get; set; }
}

	/// <summary>
/// OpenUserClassRoleListResponseDomain Data Structure.
/// </summary>
[Serializable]

public class OpenUserClassRoleListResponseDomain : TopObject
{
	        /// <summary>
	        /// 用户所有班级的角色列表
	        /// </summary>
	        [XmlArray("user_class_role_list")]
	        [XmlArrayItem("userclassrolelist")]
	        public List<UserclassrolelistDomain> UserClassRoleList { get; set; }
}

	/// <summary>
/// DingOpenResultDomain Data Structure.
/// </summary>
[Serializable]

public class DingOpenResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("errcode")]
	        public long Errcode { get; set; }
	
	        /// <summary>
	        /// 错误消息
	        /// </summary>
	        [XmlElement("errmsg")]
	        public string Errmsg { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlElement("result")]
	        public OpenUserClassRoleListResponseDomain Result { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
