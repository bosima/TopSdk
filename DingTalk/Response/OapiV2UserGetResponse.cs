using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2UserGetResponse.
    /// </summary>
    public class OapiV2UserGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码。0代表成功。
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 业务返回结果
        /// </summary>
        [XmlElement("result")]
        public UserGetResponseDomain Result { get; set; }

	/// <summary>
/// DeptOrderDomain Data Structure.
/// </summary>
[Serializable]

public class DeptOrderDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 员工在部门中的排序。
	        /// </summary>
	        [XmlElement("order")]
	        public long Order { get; set; }
}

	/// <summary>
/// DeptLeaderDomain Data Structure.
/// </summary>
[Serializable]

public class DeptLeaderDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 是否领导
	        /// </summary>
	        [XmlElement("leader")]
	        public bool Leader { get; set; }
}

	/// <summary>
/// UserRoleDomain Data Structure.
/// </summary>
[Serializable]

public class UserRoleDomain : TopObject
{
	        /// <summary>
	        /// 角色组名称
	        /// </summary>
	        [XmlElement("group_name")]
	        public string GroupName { get; set; }
	
	        /// <summary>
	        /// 角色id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 角色名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
}

	/// <summary>
/// UnionEmpMapVoDomain Data Structure.
/// </summary>
[Serializable]

public class UnionEmpMapVoDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// UnionEmpExtDomain Data Structure.
/// </summary>
[Serializable]

public class UnionEmpExtDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 关联映射关系
	        /// </summary>
	        [XmlArray("union_emp_map_list")]
	        [XmlArrayItem("union_emp_map_vo")]
	        public List<UnionEmpMapVoDomain> UnionEmpMapList { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// DeptPositionDomain Data Structure.
/// </summary>
[Serializable]

public class DeptPositionDomain : TopObject
{
	        /// <summary>
	        /// 部门id
	        /// </summary>
	        [XmlElement("dept_id")]
	        public long DeptId { get; set; }
	
	        /// <summary>
	        /// 是否是主任职
	        /// </summary>
	        [XmlElement("is_main")]
	        public bool IsMain { get; set; }
	
	        /// <summary>
	        /// 部门内职位
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 部门内工作地
	        /// </summary>
	        [XmlElement("work_place")]
	        public string WorkPlace { get; set; }
}

	/// <summary>
/// EmpExtAttrValueDomain Data Structure.
/// </summary>
[Serializable]

public class EmpExtAttrValueDomain : TopObject
{
	        /// <summary>
	        /// 自定义字段图片值
	        /// </summary>
	        [XmlArray("images")]
	        [XmlArrayItem("string")]
	        public List<string> Images { get; set; }
	
	        /// <summary>
	        /// 自定义字段文本值
	        /// </summary>
	        [XmlElement("text")]
	        public string Text { get; set; }
	
	        /// <summary>
	        /// 自定义字段链接值
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// EmpExtAttrDomain Data Structure.
/// </summary>
[Serializable]

public class EmpExtAttrDomain : TopObject
{
	        /// <summary>
	        /// 自定义字段编码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 自定义字段名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 自定义字段类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 自定义字段值
	        /// </summary>
	        [XmlElement("value")]
	        public EmpExtAttrValueDomain Value { get; set; }
}

	/// <summary>
/// UserGetResponseDomain Data Structure.
/// </summary>
[Serializable]

public class UserGetResponseDomain : TopObject
{
	        /// <summary>
	        /// 是否激活
	        /// </summary>
	        [XmlElement("active")]
	        public bool Active { get; set; }
	
	        /// <summary>
	        /// 是否管理员
	        /// </summary>
	        [XmlElement("admin")]
	        public bool Admin { get; set; }
	
	        /// <summary>
	        /// 头像
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// 是否老板
	        /// </summary>
	        [XmlElement("boss")]
	        public bool Boss { get; set; }
	
	        /// <summary>
	        /// 所属部门id列表
	        /// </summary>
	        [XmlArray("dept_id_list")]
	        [XmlArrayItem("number")]
	        public List<long> DeptIdList { get; set; }
	
	        /// <summary>
	        /// 员工在对应的部门中的排序。
	        /// </summary>
	        [XmlArray("dept_order_list")]
	        [XmlArrayItem("dept_order")]
	        public List<DeptOrderDomain> DeptOrderList { get; set; }
	
	        /// <summary>
	        /// 任职信息
	        /// </summary>
	        [XmlArray("dept_position_list")]
	        [XmlArrayItem("dept_position")]
	        public List<DeptPositionDomain> DeptPositionList { get; set; }
	
	        /// <summary>
	        /// 员工邮箱
	        /// </summary>
	        [XmlElement("email")]
	        public string Email { get; set; }
	
	        /// <summary>
	        /// 是否专属帐号
	        /// </summary>
	        [XmlElement("exclusive_account")]
	        public bool ExclusiveAccount { get; set; }
	
	        /// <summary>
	        /// 专属帐号归属组织的组织id
	        /// </summary>
	        [XmlElement("exclusive_account_corp_id")]
	        public string ExclusiveAccountCorpId { get; set; }
	
	        /// <summary>
	        /// 专属帐号归属组织的组织名称
	        /// </summary>
	        [XmlElement("exclusive_account_corp_name")]
	        public string ExclusiveAccountCorpName { get; set; }
	
	        /// <summary>
	        /// 专属帐号类型：{sso: 企业自定义idp;dingtalk: 钉钉idp}
	        /// </summary>
	        [XmlElement("exclusive_account_type")]
	        public string ExclusiveAccountType { get; set; }
	
	        /// <summary>
	        /// 自定义字段列表
	        /// </summary>
	        [XmlArray("ext_attrs")]
	        [XmlArrayItem("emp_ext_attr")]
	        public List<EmpExtAttrDomain> ExtAttrs { get; set; }
	
	        /// <summary>
	        /// 扩展属性，长度最大2000个字符。可以设置多种属性（手机上最多显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置）。 该字段的值支持链接类型填写，同时链接支持变量通配符自动替换，目前支持通配符有：userid，corpid。示例： [工位地址](http://www.dingtalk.com?userid=#userid#&corpid=#corpid#)
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 性别自定义字段
	        /// </summary>
	        [XmlElement("gender")]
	        public string Gender { get; set; }
	
	        /// <summary>
	        /// 是否号码隐藏。隐藏手机号后，手机号在个人资料页隐藏，但仍可对其发DING、发起钉钉免费商务电话。
	        /// </summary>
	        [XmlElement("hide_mobile")]
	        public bool HideMobile { get; set; }
	
	        /// <summary>
	        /// 入职时间，Unix时间戳，单位ms。
	        /// </summary>
	        [XmlElement("hired_date")]
	        public long HiredDate { get; set; }
	
	        /// <summary>
	        /// 员工工号
	        /// </summary>
	        [XmlElement("job_number")]
	        public string JobNumber { get; set; }
	
	        /// <summary>
	        /// 员工在对应的部门中是否领导。
	        /// </summary>
	        [XmlArray("leader_in_dept")]
	        [XmlArrayItem("dept_leader")]
	        public List<DeptLeaderDomain> LeaderInDept { get; set; }
	
	        /// <summary>
	        /// 本组织专属帐号登录名
	        /// </summary>
	        [XmlElement("login_id")]
	        public string LoginId { get; set; }
	
	        /// <summary>
	        /// 主管的ID，仅限企业内部开发调用
	        /// </summary>
	        [XmlElement("manager_userid")]
	        public string ManagerUserid { get; set; }
	
	        /// <summary>
	        /// 手机号码
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 员工名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 查询本组织专属帐号时可获得昵称
	        /// </summary>
	        [XmlElement("nickname")]
	        public string Nickname { get; set; }
	
	        /// <summary>
	        /// 员工的企业邮箱
	        /// </summary>
	        [XmlElement("org_email")]
	        public string OrgEmail { get; set; }
	
	        /// <summary>
	        /// 企业邮箱类型（profession：标准版，base：基础版）
	        /// </summary>
	        [XmlElement("org_email_type")]
	        public string OrgEmailType { get; set; }
	
	        /// <summary>
	        /// 是否实名认证
	        /// </summary>
	        [XmlElement("real_authed")]
	        public bool RealAuthed { get; set; }
	
	        /// <summary>
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
	        /// <summary>
	        /// 角色列表
	        /// </summary>
	        [XmlArray("role_list")]
	        [XmlArrayItem("user_role")]
	        public List<UserRoleDomain> RoleList { get; set; }
	
	        /// <summary>
	        /// 是否高管
	        /// </summary>
	        [XmlElement("senior")]
	        public bool Senior { get; set; }
	
	        /// <summary>
	        /// 国际电话区号
	        /// </summary>
	        [XmlElement("state_code")]
	        public string StateCode { get; set; }
	
	        /// <summary>
	        /// 分机号
	        /// </summary>
	        [XmlElement("telephone")]
	        public string Telephone { get; set; }
	
	        /// <summary>
	        /// 职位
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 关联信息
	        /// </summary>
	        [XmlElement("union_emp_ext")]
	        public UnionEmpExtDomain UnionEmpExt { get; set; }
	
	        /// <summary>
	        /// 员工在当前开发者企业账号范围内的唯一标识
	        /// </summary>
	        [XmlElement("unionid")]
	        public string Unionid { get; set; }
	
	        /// <summary>
	        /// 用户id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
	
	        /// <summary>
	        /// 办公地点
	        /// </summary>
	        [XmlElement("work_place")]
	        public string WorkPlace { get; set; }
}

    }
}
