using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkbenchShortcutDeleteResponse.
    /// </summary>
    public class OapiWorkbenchShortcutDeleteResponse : DingTalkResponse
    {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public IsvOrgShortcutStatusDTODomain Result { get; set; }

	/// <summary>
/// IsvOrgShortcutStatusDTODomain Data Structure.
/// </summary>
[Serializable]

public class IsvOrgShortcutStatusDTODomain : TopObject
{
	        /// <summary>
	        /// 系统交互唯一流水号(ISV维度下不可重复)
	        /// </summary>
	        [XmlElement("biz_no")]
	        public string BizNo { get; set; }
}

    }
}
