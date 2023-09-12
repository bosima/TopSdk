using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiWorkbenchShortcutAddResponse.
    /// </summary>
    public class OapiWorkbenchShortcutAddResponse : DingTalkResponse
    {
        /// <summary>
        /// 服务返回码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 服务返回信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("result")]
        public IsvOrgShortcutStatusDtoDomain Result { get; set; }

	/// <summary>
/// IsvOrgShortcutStatusDtoDomain Data Structure.
/// </summary>
[Serializable]

public class IsvOrgShortcutStatusDtoDomain : TopObject
{
	        /// <summary>
	        /// 唯一流水号-系统交互唯一识别码
	        /// </summary>
	        [XmlElement("biz_no")]
	        public string BizNo { get; set; }
}

    }
}
