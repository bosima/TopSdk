using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkbenchShortcutUpdateResponse.
    /// </summary>
    public class OapiWorkbenchShortcutUpdateResponse : DingTalkResponse
    {
        /// <summary>
        /// 服务结果码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 服务结果信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public IsvOrgShortcutDtoDomain Result { get; set; }

	/// <summary>
/// IsvOrgShortcutDtoDomain Data Structure.
/// </summary>
[Serializable]

public class IsvOrgShortcutDtoDomain : TopObject
{
	        /// <summary>
	        /// 系统交互唯一流水号
	        /// </summary>
	        [XmlElement("biz_no")]
	        public string BizNo { get; set; }
}

    }
}
