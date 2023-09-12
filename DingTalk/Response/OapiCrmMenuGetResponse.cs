using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCrmMenuGetResponse.
    /// </summary>
    public class OapiCrmMenuGetResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 接口返回model
        /// </summary>
        [XmlElement("result")]
        public OnlineNavigationModelDomain Result { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// OnlineNavigationModelDomain Data Structure.
/// </summary>
[Serializable]

public class OnlineNavigationModelDomain : TopObject
{
	        /// <summary>
	        /// 表单id 如果非表单类菜单，可为空
	        /// </summary>
	        [XmlElement("form_uuid")]
	        public string FormUuid { get; set; }
	
	        /// <summary>
	        /// 图标地址
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 是否新打开页面 0:不打开 1：新打开
	        /// </summary>
	        [XmlElement("is_new")]
	        public long IsNew { get; set; }
	
	        /// <summary>
	        /// 链接地址
	        /// </summary>
	        [XmlElement("link_url")]
	        public string LinkUrl { get; set; }
	
	        /// <summary>
	        /// 菜单排序序号
	        /// </summary>
	        [XmlElement("list_order")]
	        public long ListOrder { get; set; }
	
	        /// <summary>
	        /// 1:隐藏 0：不隐藏
	        /// </summary>
	        [XmlElement("mobile_hidden")]
	        public long MobileHidden { get; set; }
	
	        /// <summary>
	        /// 菜单名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 导航类型：sw_form：表单类到导航 group：分组类  outLinker：链接跳转
	        /// </summary>
	        [XmlElement("nav_type")]
	        public string NavType { get; set; }
	
	        /// <summary>
	        /// 树形结构 父菜单id
	        /// </summary>
	        [XmlElement("parent_id")]
	        public long ParentId { get; set; }
	
	        /// <summary>
	        /// 1:隐藏 0：不隐藏
	        /// </summary>
	        [XmlElement("pc_hidden")]
	        public long PcHidden { get; set; }
}

    }
}
