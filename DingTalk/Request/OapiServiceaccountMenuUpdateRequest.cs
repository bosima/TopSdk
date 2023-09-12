using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.serviceaccount.menu.update
    /// </summary>
    public class OapiServiceaccountMenuUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServiceaccountMenuUpdateResponse>
    {
        /// <summary>
        /// 菜单
        /// </summary>
        public string Menu { get; set; }

        public MenuConfigDTODomain Menu_ { set { this.Menu = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 服务号的unionid
        /// </summary>
        public string Unionid { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.serviceaccount.menu.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("menu", this.Menu);
            parameters.Add("unionid", this.Unionid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("unionid", this.Unionid);
        }

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
	        public Nullable<bool> EnableInput { get; set; }
	
	        /// <summary>
	        /// 状态，0-正常，1-停用
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
}

        #endregion
    }
}
