using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiV2UserListResponse.
    /// </summary>
    public class OapiV2UserListResponse : DingTalkResponse
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
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public PageResultDomain Result { get; set; }

	/// <summary>
/// ListUserResponseDomain Data Structure.
/// </summary>
[Serializable]

public class ListUserResponseDomain : TopObject
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
	        /// 员工在部门中的排序。
	        /// </summary>
	        [XmlElement("dept_order")]
	        public long DeptOrder { get; set; }
	
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
	        /// 专属帐号类型
	        /// </summary>
	        [XmlElement("exclusive_account_type")]
	        public string ExclusiveAccountType { get; set; }
	
	        /// <summary>
	        /// 扩展属性
	        /// </summary>
	        [XmlElement("extension")]
	        public string Extension { get; set; }
	
	        /// <summary>
	        /// 性别
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
	        /// 是否领导
	        /// </summary>
	        [XmlElement("leader")]
	        public bool Leader { get; set; }
	
	        /// <summary>
	        /// 本组织专属帐号登录名
	        /// </summary>
	        [XmlElement("login_id")]
	        public string LoginId { get; set; }
	
	        /// <summary>
	        /// 手机号码
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 用户姓名
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
	        /// 备注
	        /// </summary>
	        [XmlElement("remark")]
	        public string Remark { get; set; }
	
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

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 是否还有更多的数据
	        /// </summary>
	        [XmlElement("has_more")]
	        public bool HasMore { get; set; }
	
	        /// <summary>
	        /// 用户信息列表
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("list_user_response")]
	        public List<ListUserResponseDomain> List { get; set; }
	
	        /// <summary>
	        /// 下一次分页的游标，如果has_more为false，表示没有更多的分页数据
	        /// </summary>
	        [XmlElement("next_cursor")]
	        public long NextCursor { get; set; }
}

    }
}
