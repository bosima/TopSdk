using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiSmartworkHrmNavigationbarConfigGetResponse.
    /// </summary>
    public class OapiSmartworkHrmNavigationbarConfigGetResponse : DingTalkResponse
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
        /// 导航栏VO
        /// </summary>
        [XmlElement("result")]
        public HrmNavigationBarVoDomain Result { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// HrmNavBarTreePointLevel5VoDomain Data Structure.
/// </summary>
[Serializable]

public class HrmNavBarTreePointLevel5VoDomain : TopObject
{
	        /// <summary>
	        /// 权限key
	        /// </summary>
	        [XmlElement("auth_key")]
	        public string AuthKey { get; set; }
	
	        /// <summary>
	        /// 权限类型
	        /// </summary>
	        [XmlElement("auth_type")]
	        public string AuthType { get; set; }
	
	        /// <summary>
	        /// 节点code，全局唯一
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 节点图标
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 节点名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 是否无权限
	        /// </summary>
	        [XmlElement("no_permission")]
	        public bool NoPermission { get; set; }
	
	        /// <summary>
	        /// 顺序
	        /// </summary>
	        [XmlElement("order")]
	        public long Order { get; set; }
	
	        /// <summary>
	        /// 路径
	        /// </summary>
	        [XmlElement("path")]
	        public string Path { get; set; }
	
	        /// <summary>
	        /// 前端跳转识别字段
	        /// </summary>
	        [XmlElement("sub_app_code")]
	        public string SubAppCode { get; set; }
	
	        /// <summary>
	        /// 跳转链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// HrmNavBarTreePointLevel4VoDomain Data Structure.
/// </summary>
[Serializable]

public class HrmNavBarTreePointLevel4VoDomain : TopObject
{
	        /// <summary>
	        /// 权限key
	        /// </summary>
	        [XmlElement("auth_key")]
	        public string AuthKey { get; set; }
	
	        /// <summary>
	        /// 权限类型
	        /// </summary>
	        [XmlElement("auth_type")]
	        public string AuthType { get; set; }
	
	        /// <summary>
	        /// 四级子节点
	        /// </summary>
	        [XmlArray("children")]
	        [XmlArrayItem("hrm_nav_bar_tree_point_level5_vo")]
	        public List<HrmNavBarTreePointLevel5VoDomain> Children { get; set; }
	
	        /// <summary>
	        /// 节点code，全局唯一
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 节点图标
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 节点名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 是否无权限
	        /// </summary>
	        [XmlElement("no_permission")]
	        public bool NoPermission { get; set; }
	
	        /// <summary>
	        /// 顺序
	        /// </summary>
	        [XmlElement("order")]
	        public long Order { get; set; }
	
	        /// <summary>
	        /// 路径
	        /// </summary>
	        [XmlElement("path")]
	        public string Path { get; set; }
	
	        /// <summary>
	        /// 前端跳转识别字段
	        /// </summary>
	        [XmlElement("sub_app_code")]
	        public string SubAppCode { get; set; }
	
	        /// <summary>
	        /// 跳转链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// HrmNavBarTreePointLevel3VoDomain Data Structure.
/// </summary>
[Serializable]

public class HrmNavBarTreePointLevel3VoDomain : TopObject
{
	        /// <summary>
	        /// 权限key
	        /// </summary>
	        [XmlElement("auth_key")]
	        public string AuthKey { get; set; }
	
	        /// <summary>
	        /// 权限类型
	        /// </summary>
	        [XmlElement("auth_type")]
	        public string AuthType { get; set; }
	
	        /// <summary>
	        /// 三级子节点
	        /// </summary>
	        [XmlArray("children")]
	        [XmlArrayItem("hrm_nav_bar_tree_point_level4_vo")]
	        public List<HrmNavBarTreePointLevel4VoDomain> Children { get; set; }
	
	        /// <summary>
	        /// 节点code，全局唯一
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 节点图标
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 节点名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 是否无权限
	        /// </summary>
	        [XmlElement("no_permission")]
	        public bool NoPermission { get; set; }
	
	        /// <summary>
	        /// 顺序
	        /// </summary>
	        [XmlElement("order")]
	        public long Order { get; set; }
	
	        /// <summary>
	        /// 路径
	        /// </summary>
	        [XmlElement("path")]
	        public string Path { get; set; }
	
	        /// <summary>
	        /// 前端跳转识别字段
	        /// </summary>
	        [XmlElement("sub_app_code")]
	        public string SubAppCode { get; set; }
	
	        /// <summary>
	        /// 跳转链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// HrmNavBarTreePointLevel2VoDomain Data Structure.
/// </summary>
[Serializable]

public class HrmNavBarTreePointLevel2VoDomain : TopObject
{
	        /// <summary>
	        /// 权限key
	        /// </summary>
	        [XmlElement("auth_key")]
	        public string AuthKey { get; set; }
	
	        /// <summary>
	        /// 权限类型
	        /// </summary>
	        [XmlElement("auth_type")]
	        public string AuthType { get; set; }
	
	        /// <summary>
	        /// 二级子节点
	        /// </summary>
	        [XmlArray("children")]
	        [XmlArrayItem("hrm_nav_bar_tree_point_level3_vo")]
	        public List<HrmNavBarTreePointLevel3VoDomain> Children { get; set; }
	
	        /// <summary>
	        /// 节点code，全局唯一
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 节点图标
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 节点名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 是否无权限
	        /// </summary>
	        [XmlElement("no_permission")]
	        public bool NoPermission { get; set; }
	
	        /// <summary>
	        /// 顺序
	        /// </summary>
	        [XmlElement("order")]
	        public long Order { get; set; }
	
	        /// <summary>
	        /// 路径
	        /// </summary>
	        [XmlElement("path")]
	        public string Path { get; set; }
	
	        /// <summary>
	        /// 前端跳转识别字段
	        /// </summary>
	        [XmlElement("sub_app_code")]
	        public string SubAppCode { get; set; }
	
	        /// <summary>
	        /// 跳转链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// HrmNavBarTreePointLevel1VoDomain Data Structure.
/// </summary>
[Serializable]

public class HrmNavBarTreePointLevel1VoDomain : TopObject
{
	        /// <summary>
	        /// 权限key
	        /// </summary>
	        [XmlElement("auth_key")]
	        public string AuthKey { get; set; }
	
	        /// <summary>
	        /// 权限类型
	        /// </summary>
	        [XmlElement("auth_type")]
	        public string AuthType { get; set; }
	
	        /// <summary>
	        /// 一级子节点
	        /// </summary>
	        [XmlArray("children")]
	        [XmlArrayItem("hrm_nav_bar_tree_point_level2_vo")]
	        public List<HrmNavBarTreePointLevel2VoDomain> Children { get; set; }
	
	        /// <summary>
	        /// 节点code，全局唯一
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 节点图标
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 节点名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 是否无权限
	        /// </summary>
	        [XmlElement("no_permission")]
	        public bool NoPermission { get; set; }
	
	        /// <summary>
	        /// 顺序
	        /// </summary>
	        [XmlElement("order")]
	        public long Order { get; set; }
	
	        /// <summary>
	        /// 路径
	        /// </summary>
	        [XmlElement("path")]
	        public string Path { get; set; }
	
	        /// <summary>
	        /// 前端跳转识别字段
	        /// </summary>
	        [XmlElement("sub_app_code")]
	        public string SubAppCode { get; set; }
	
	        /// <summary>
	        /// 跳转链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// EmpBaseInfoVoDomain Data Structure.
/// </summary>
[Serializable]

public class EmpBaseInfoVoDomain : TopObject
{
	        /// <summary>
	        /// 管理员头像
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// 管理员名字
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 管理员员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

	/// <summary>
/// HrmNavigationBarVoDomain Data Structure.
/// </summary>
[Serializable]

public class HrmNavigationBarVoDomain : TopObject
{
	        /// <summary>
	        /// 企业id
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 导航栏节点VO
	        /// </summary>
	        [XmlArray("menu_list")]
	        [XmlArrayItem("hrm_nav_bar_tree_point_level1_vo")]
	        public List<HrmNavBarTreePointLevel1VoDomain> MenuList { get; set; }
	
	        /// <summary>
	        /// 管理员列表
	        /// </summary>
	        [XmlArray("super_admins")]
	        [XmlArrayItem("emp_base_info_vo")]
	        public List<EmpBaseInfoVoDomain> SuperAdmins { get; set; }
	
	        /// <summary>
	        /// 员工id
	        /// </summary>
	        [XmlElement("userid")]
	        public string Userid { get; set; }
}

    }
}
