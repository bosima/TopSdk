using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkbenchShortcutListResponse.
    /// </summary>
    public class OapiWorkbenchShortcutListResponse : DingTalkResponse
    {
        /// <summary>
        /// 服务结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 服务结果描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public IsvOrgShortcutListDTODomain Result { get; set; }

	/// <summary>
/// IsvOrgShortcutDTODomain Data Structure.
/// </summary>
[Serializable]

public class IsvOrgShortcutDTODomain : TopObject
{
	        /// <summary>
	        /// 业务单号,系统间交互唯一流水号
	        /// </summary>
	        [XmlElement("biz_no")]
	        public string BizNo { get; set; }
	
	        /// <summary>
	        /// 快捷方式图标
	        /// </summary>
	        [XmlElement("icon")]
	        public string Icon { get; set; }
	
	        /// <summary>
	        /// 快捷方式名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// PC端快捷方式地址
	        /// </summary>
	        [XmlElement("pc_shortcut_uri")]
	        public string PcShortcutUri { get; set; }
	
	        /// <summary>
	        /// 移动端快捷方式地址(默认地址)
	        /// </summary>
	        [XmlElement("shortcut_uri")]
	        public string ShortcutUri { get; set; }
}

	/// <summary>
/// IsvOrgShortcutListDTODomain Data Structure.
/// </summary>
[Serializable]

public class IsvOrgShortcutListDTODomain : TopObject
{
	        /// <summary>
	        /// 企业下指定应用已添加快捷方式列表
	        /// </summary>
	        [XmlArray("shortcut_list")]
	        [XmlArrayItem("isv_org_shortcut_d_t_o")]
	        public List<IsvOrgShortcutDTODomain> ShortcutList { get; set; }
}

    }
}
