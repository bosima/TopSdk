using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiServiceaccountMenuGetResponse.
    /// </summary>
    public class OapiServiceaccountMenuGetResponse : DingTalkResponse
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
        /// 菜单
        /// </summary>
        [XmlElement("menu")]
        public MenuConfigDTODomain Menu { get; set; }

	/// <summary>
/// MenuSubButtonDTODomain Data Structure.
/// </summary>
[Serializable]

public class MenuSubButtonDTODomain : TopObject
{
	        /// <summary>
	        /// 菜单绑定的key值
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 素材id
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
	
	        /// <summary>
	        /// 名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 菜单绑定的URL
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// MenuButtonDTODomain Data Structure.
/// </summary>
[Serializable]

public class MenuButtonDTODomain : TopObject
{
	        /// <summary>
	        /// 菜单绑定的key值
	        /// </summary>
	        [XmlElement("key")]
	        public string Key { get; set; }
	
	        /// <summary>
	        /// 素材id
	        /// </summary>
	        [XmlElement("media_id")]
	        public string MediaId { get; set; }
	
	        /// <summary>
	        /// 名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 子菜单按钮列表
	        /// </summary>
	        [XmlArray("sub_button")]
	        [XmlArrayItem("menu_sub_button_d_t_o")]
	        public List<MenuSubButtonDTODomain> SubButton { get; set; }
	
	        /// <summary>
	        /// 类型
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// 菜单绑定的URL
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// MenuConfigDTODomain Data Structure.
/// </summary>
[Serializable]

public class MenuConfigDTODomain : TopObject
{
	        /// <summary>
	        /// 菜单按钮列表
	        /// </summary>
	        [XmlArray("button")]
	        [XmlArrayItem("menu_button_d_t_o")]
	        public List<MenuButtonDTODomain> Button { get; set; }
	
	        /// <summary>
	        /// 是否允许用户输入
	        /// </summary>
	        [XmlElement("enable_input")]
	        public bool EnableInput { get; set; }
	
	        /// <summary>
	        /// 状态，0-正常，1-停用
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
}

    }
}
